using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Accord.Video.FFMPEG;
using System;

namespace FellowX
{
    class ScreenRecorder
    {
        private Rectangle bounds;
        private string outputPath = "";
        private string tempPath = "";
        private int fileCount = 1;
        private List<string> inputImageSequence = new List<string>();

        private string audioName = "mic.wav";
        private string videoName = "video.mp4";
        private string finalName = "FinalVideo.mp4";

        Stopwatch watch = new Stopwatch();

        public static class NativeMethods
        {
            [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
            public static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        }

        public ScreenRecorder(Rectangle b, string outPath)
        {
            CreateTempFolder("tempScreenCaps");

            bounds = b;
            outputPath = outPath;
        }

        private void CreateTempFolder(string name)
        {
            if (Directory.Exists("D://"))
            {
                string pathName = $"D://{name}";
                Directory.CreateDirectory(pathName);
                tempPath = pathName;
            }
            else
            {
                string pathName = $"C://Documents//{name}";
                Directory.CreateDirectory(pathName);
                tempPath = pathName;
            }
        }

        public void setVideoName(string name)
        {
            finalName = name;
        }

        private void DeletePath(string targetDir)
        {
            string[] files = Directory.GetFiles(targetDir);
            string[] dirs = Directory.GetDirectories(targetDir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeletePath(dir);
            }

            Directory.Delete(targetDir, false);
        }

        private void DeleteFilesExcept(string targetFile, string excFile)
        {
            string[] files = Directory.GetFiles(targetFile);

            foreach (string file in files)
            {
                if (file != excFile)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }
            }
        }

        public void cleanUp()
        {
            if (Directory.Exists(tempPath))
            {
                DeletePath(tempPath);
            }
        }

        public string getElapsed()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds);
        }

        public void RecordVideo()
        {
            watch.Start();

            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                string name = tempPath + "//screenshot-" + fileCount + ".png";
                bitmap.Save(name, ImageFormat.Png);
                inputImageSequence.Add(name);
                fileCount++;

                bitmap.Dispose();
            }
        }

        public void RecordAudio()
        {
            NativeMethods.record("open new Type waveaudio Alias recsound", "", 0, 0);
            NativeMethods.record("record recsound", "", 0, 0);
        }

        private void SaveAudio()
        {
            string audioPath = "save recsound " + outputPath + "//" + audioName;
            NativeMethods.record(audioPath, "", 0, 0);
            NativeMethods.record("close recsound", "", 0, 0);
        }

        private void SaveVideo(int width, int height, int frameRate)
        {
            using (VideoFileWriter vFWriter = new VideoFileWriter())
            {
                vFWriter.Open(outputPath + "//" + videoName, width, height, frameRate, VideoCodec.MPEG4);

                foreach (string imageLoc in inputImageSequence)
                {
                    Bitmap imageFrame = Image.FromFile(imageLoc) as Bitmap;
                    vFWriter.WriteVideoFrame(imageFrame);
                    imageFrame.Dispose();
                }

                vFWriter.Close();
            }
        }

        private void CombineVideoAndAudio(string video, string audio)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false,
                //FileName = "cmd.exe",
                FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg\\ffmpeg.exe"),
                WorkingDirectory = outputPath,
                Arguments = "ffmpeg -i video.mp4 -i mic.wav -shortest finalVideo.mp4"
            };
            Process proc = new Process();
            proc.StartInfo = startInfo;
            proc.Start();
        }

        public void Stop()
        {
            watch.Stop();

            int width = bounds.Width;
            int height = bounds.Height;
            int frameRate = 15;

            SaveAudio();
            SaveVideo(width, height, frameRate);
            CombineVideoAndAudio(videoName, audioName);
            DeletePath(tempPath);

            //DeleteFilesExcept(outputPath, outputPath + "\\" + finalName);
        }
    }
}
