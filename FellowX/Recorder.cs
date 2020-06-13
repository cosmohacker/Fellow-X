using FellowX.Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FellowX
{
    public partial class Recorder : Form
    {
        ScreenRecorder screenRec = new ScreenRecorder(new Rectangle(), "");
        AudioRecorder audioRecorder = new AudioRecorder();
        string finalVidName = "FinalVideo.mp4";
        bool pathSelected = false;
        string outputPath = "";

        public Recorder()
        {
            InitializeComponent();
        }

        #region Window State

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        #endregion

        #region Window Mover

        int mov, movX, movY;

        private void panelWindowMover_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelWindowMover_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }


        private void panelWindowMover_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        #endregion

        #region Record Events

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select an Output Folder";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                outputPath = @folderBrowser.SelectedPath;
                pathSelected = true;
                txtPath.Text = outputPath;

                Rectangle bounds = Screen.FromControl(this).Bounds;
                screenRec = new ScreenRecorder(bounds, outputPath);
            }
            else
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Please select an output folder.";
            }
        }

        private void tmrRecord_Tick(object sender, EventArgs e)
        {
            screenRec.RecordVideo();
            screenRec.RecordAudio();
            lblTimer.Text = screenRec.getElapsed();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!chcImage.Checked && !chcVideo.Checked && !chcAudio.Checked)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "You must select an option to record or capture the screen!";
            }
            else
            {
                if (btnStartStop.Text == "RECORD")
                {
                    record();
                }
                else if (btnStartStop.Text == "STOP")
                {
                    stop();
                }
                else if (btnStartStop.Text == "CAPTURE")
                {
                    capture();
                }
            }
        }

        private void record()
        {
            bool containsMP4 = finalVidName.Contains(".mp4");

            if (pathSelected && containsMP4)
            {
                screenRec.setVideoName(finalVidName);
                tmrRecord.Start();
                btnStartStop.Text = "STOP";
                lblError.Text = "";
            }
            else if (!pathSelected && containsMP4)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "You must select an output path first!";
            }
            else if (pathSelected && !containsMP4)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "You must select video name that ends in '.mp4'!";
                finalVidName = "FinalVideo.mp4";
            }
            else
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "You must select video name that ends in '.mp4' " + "and you must select an output path";
                finalVidName = "FinalVideo.mp4";
            }
        }

        private void stop()
        {
            if (btnStartStop.Text == "STOP")
            {
                tmrRecord.Stop();
                screenRec.Stop();
                Application.Restart();
            }
        }

        private void capture()
        {
            if (pathSelected)
            {
                screenRec.setVideoName(finalVidName);
                tmrRecord.Start();
                btnStartStop.Text = "STOP";
                lblError.Text = "";
            }
            else if (!pathSelected)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "You must select an output path first!";
            }
        }

        private void recordAudioAsMP3()
        {
            tmrRecord.Stop();
            audioRecorder.SaveAudioAsMP3();
            Application.Restart();
            btnStartStop.Text = "RECORD";
            lblTimer.Text = "00:00:00";
        }

        private void recordAudioAsWMA()
        {
            audioRecorder.SaveAudioAsWMA();
        }

        private void recordAudioAsWAV()
        {
            audioRecorder.SaveAudioAsWAV();
        }

        private void recordVideoAsMP4() { }

        private void recordVideoAsWMV() { }

        private void recordVideoAsAVI() { }

        #endregion

        #region Form Options

        private void Recorder_Load(object sender, EventArgs e)
        {
            btnStartStop.BackColor = ColorTranslator.FromHtml("#9c915d");
            panelWindowMover.ForeColor = ColorTranslator.FromHtml("#9c915d");
            btnSelectFolder.BackColor = ColorTranslator.FromHtml("#9c915d");
            lblAuthor.Text = "IRC(Hex), Steam, Uplay, PSN, Discord(#4761)  : cosmohacker || Origin, Epic : cosmoh4cker   Created By Yağızcan Yavuz";
            tmrSlideText.Enabled = true;
            this.KeyPreview = true;
        }

        private void Recorder_Paint(object sender, PaintEventArgs e)
        {
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 15))
            {
                this.Region = new Region(GraphPath);
            }
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        private void tmrSlideText_Tick(object sender, EventArgs e)
        {
            if (lblAuthor.Left > -1400)
            {
                lblAuthor.Left -= 1;
            }
            else
            {
                lblAuthor.Left = 100;
            }
        }

        #endregion

        #region Always On Top

        private void chcAOT_CheckedChanged(object sender, EventArgs e)
        {
            if (chcAOT.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        #endregion

        #region Check Events

        private void chcVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (chcVideo.Checked)
            {
                chcImage.Checked = false;
                radioMP4.Enabled = true;
                radioWMV.Enabled = true;
                radioAVI.Enabled = true;
            }
            else
            {
                radioMP4.Enabled = false;
                radioWMV.Enabled = false;
                radioAVI.Enabled = false;
            }

            if (chcVideo.Checked && chcAudio.Checked)
            {
                radioMP3.Enabled = false;
                radioWAV.Enabled = false;
                radioWMA.Enabled = false;
                radioMP4.Enabled = false;
                radioWMV.Enabled = false;
                radioAVI.Enabled = false;
            }

        }

        private void chcAudio_CheckedChanged(object sender, EventArgs e)
        {

            if (chcAudio.Checked)
            {
                radioMP3.Enabled = true;
                radioWAV.Enabled = true;
                radioWMA.Enabled = true;
            }
            else
            {
                radioMP3.Enabled = false;
                radioWAV.Enabled = false;
                radioWMA.Enabled = false;
            }
        }

        private void chcImage_CheckedChanged(object sender, EventArgs e)
        {
            if (chcImage.Checked)
            {
                btnStartStop.Text = "CAPTURE";
            }
            else
            {
                btnStartStop.Text = "RECORD";
            }
        }

        #endregion

        #region Hotkey

        private void Recorder_KeyDown(object sender, KeyEventArgs e)
        {
            String startHolder = txtStartHotkey.Text;
            String stopHolder = txtStopHotkey.Text;

            if (e.KeyCode.ToString() == startHolder)
            {
                e.SuppressKeyPress = true;
                btnStartStop.PerformClick();
            }
            else if (e.KeyCode.ToString() == stopHolder)
            {
                e.SuppressKeyPress = true;
                btnStartStop.PerformClick();
            }
        }

        private void txtStartHotkey_TextChanged(object sender, EventArgs e)
        {
            txtStartHotkey.Enabled = false;
        }

        private void txtStopHotkey_TextChanged(object sender, EventArgs e)
        {
            txtStopHotkey.Enabled = false;
        }

        private void txtStopHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            setKey(txtStopHotkey, e);
        }

        private void txtStartHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            setKey(txtStartHotkey, e);
        }

        private void btnStartHotkey_Click(object sender, EventArgs e)
        {
                txtStartHotkey.Enabled = true;
            txtStartHotkey.Text = "";
            txtStartHotkey.Focus();
        }

        private void btnStopHotkey_Click(object sender, EventArgs e)
        {
            txtStopHotkey.Enabled = true;
            txtStopHotkey.Text = "";
            txtStopHotkey.Focus();
        }

        private void setKey(TextBox textBox, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                textBox.Text = "F1";
            }
            else if (e.KeyCode == Keys.F2)
            {
                textBox.Text = "F2";
            }
            else if (e.KeyCode == Keys.F3)
            {
                textBox.Text = "F3";
            }
            else if (e.KeyCode == Keys.F4)
            {
                textBox.Text = "F4";
            }
            else if (e.KeyCode == Keys.F5)
            {
                textBox.Text = "F5";
            }
            else if (e.KeyCode == Keys.F6)
            {
                textBox.Text = "F6";
            }
            else if (e.KeyCode == Keys.F7)
            {
                textBox.Text = "F7";
            }
            else if (e.KeyCode == Keys.F8)
            {
                textBox.Text = "F8";
            }
            else if (e.KeyCode == Keys.F9)
            {
                textBox.Text = "F9";
            }
            else if (e.KeyCode == Keys.F10)
            {
                textBox.Text = "F10";
            }
            else if (e.KeyCode == Keys.F11)
            {
                textBox.Text = "F11";
            }
            else if (e.KeyCode == Keys.F12)
            {
                textBox.Text = "F12";
            }
        }

        #endregion

    }
}
