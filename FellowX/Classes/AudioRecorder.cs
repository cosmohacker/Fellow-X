using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FellowX.Classes
{
    class AudioRecorder
    {

        private string audioMP3 = "mic.mp3", audioWMA = "mic.wma", audioWAV = "mic.wav";
        Stopwatch watch = new Stopwatch();
        private string outputPath = "";

        public static class NativeMethods
        {
            [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
            public static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        }

        public void RecordAudio()
        {
            NativeMethods.record("open new Type waveaudio Alias recsound", "", 0, 0);
            NativeMethods.record("record recsound", "", 0, 0);
        }

        public void SaveAudioAsMP3()
        {
            string audioPath = "save recsound " + outputPath + "//" + audioMP3;
            NativeMethods.record(audioPath, "", 0, 0);
            NativeMethods.record("close recsound", "", 0, 0);
        }

        public void SaveAudioAsWMA()
        {
            string audioPath = "save recsound " + outputPath + "//" + audioWMA;
            NativeMethods.record(audioPath, "", 0, 0);
            NativeMethods.record("close recsound", "", 0, 0);
        }

        public void SaveAudioAsWAV()
        {
            string audioPath = "save recsound " + outputPath + "//" + audioWAV;
            NativeMethods.record(audioPath, "", 0, 0);
            NativeMethods.record("close recsound", "", 0, 0);
        }

        public void stopMP3()
        {
            watch.Stop();

            SaveAudioAsMP3();
        }

        public void stopWAV()
        {
            watch.Stop();

            SaveAudioAsWAV();
        }

        public void stopWMA()
        {
            watch.Stop();

            SaveAudioAsWMA();
        }
    }
}
