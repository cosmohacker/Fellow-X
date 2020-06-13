namespace FellowX
{
    partial class Recorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recorder));
            this.panelWindowMover = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.tmrRecord = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioAVI = new System.Windows.Forms.RadioButton();
            this.radioWMV = new System.Windows.Forms.RadioButton();
            this.radioMP4 = new System.Windows.Forms.RadioButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblVideoExtension = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.chcVideo = new System.Windows.Forms.CheckBox();
            this.chcAudio = new System.Windows.Forms.CheckBox();
            this.chcAOT = new System.Windows.Forms.CheckBox();
            this.txtStartHotkey = new System.Windows.Forms.TextBox();
            this.txtStopHotkey = new System.Windows.Forms.TextBox();
            this.lblStartHotkey = new System.Windows.Forms.Label();
            this.lblStopHotkey = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrSlideText = new System.Windows.Forms.Timer(this.components);
            this.lblAuthor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioWAV = new System.Windows.Forms.RadioButton();
            this.radioWMA = new System.Windows.Forms.RadioButton();
            this.radioMP3 = new System.Windows.Forms.RadioButton();
            this.lblAudioExtension = new System.Windows.Forms.Label();
            this.chcCam = new System.Windows.Forms.CheckBox();
            this.chcImage = new System.Windows.Forms.CheckBox();
            this.lblInclude = new System.Windows.Forms.Label();
            this.btnStartHotkey = new System.Windows.Forms.Button();
            this.btnStopHotkey = new System.Windows.Forms.Button();
            this.btnStartStop = new FellowX.Controls.RoundedButton();
            this.panelWindowMover.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindowMover
            // 
            this.panelWindowMover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWindowMover.Controls.Add(this.btnClose);
            this.panelWindowMover.Controls.Add(this.btnMinus);
            this.panelWindowMover.Location = new System.Drawing.Point(-1, -1);
            this.panelWindowMover.Name = "panelWindowMover";
            this.panelWindowMover.Size = new System.Drawing.Size(400, 37);
            this.panelWindowMover.TabIndex = 6;
            this.panelWindowMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWindowMover_MouseDown);
            this.panelWindowMover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelWindowMover_MouseMove);
            this.panelWindowMover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelWindowMover_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FellowX.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(359, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Image = global::FellowX.Properties.Resources.minus;
            this.btnMinus.Location = new System.Drawing.Point(325, -1);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 41);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // tmrRecord
            // 
            this.tmrRecord.Interval = 15;
            this.tmrRecord.Tick += new System.EventHandler(this.tmrRecord_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(131, 444);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(136, 20);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 70);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioAVI);
            this.panel1.Controls.Add(this.radioWMV);
            this.panel1.Controls.Add(this.radioMP4);
            this.panel1.Location = new System.Drawing.Point(13, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 29);
            this.panel1.TabIndex = 22;
            // 
            // radioAVI
            // 
            this.radioAVI.AutoSize = true;
            this.radioAVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioAVI.Enabled = false;
            this.radioAVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioAVI.ForeColor = System.Drawing.Color.White;
            this.radioAVI.Location = new System.Drawing.Point(116, 4);
            this.radioAVI.Name = "radioAVI";
            this.radioAVI.Size = new System.Drawing.Size(46, 17);
            this.radioAVI.TabIndex = 2;
            this.radioAVI.Text = ".avi";
            this.radioAVI.UseVisualStyleBackColor = true;
            // 
            // radioWMV
            // 
            this.radioWMV.AutoSize = true;
            this.radioWMV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioWMV.Enabled = false;
            this.radioWMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioWMV.ForeColor = System.Drawing.Color.White;
            this.radioWMV.Location = new System.Drawing.Point(63, 4);
            this.radioWMV.Name = "radioWMV";
            this.radioWMV.Size = new System.Drawing.Size(54, 17);
            this.radioWMV.TabIndex = 1;
            this.radioWMV.Text = ".wmv";
            this.radioWMV.UseVisualStyleBackColor = true;
            // 
            // radioMP4
            // 
            this.radioMP4.AutoSize = true;
            this.radioMP4.Checked = true;
            this.radioMP4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioMP4.Enabled = false;
            this.radioMP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioMP4.ForeColor = System.Drawing.Color.White;
            this.radioMP4.Location = new System.Drawing.Point(4, 4);
            this.radioMP4.Name = "radioMP4";
            this.radioMP4.Size = new System.Drawing.Size(52, 17);
            this.radioMP4.TabIndex = 0;
            this.radioMP4.TabStop = true;
            this.radioMP4.Text = ".mp4";
            this.radioMP4.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(12, 154);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(283, 20);
            this.txtPath.TabIndex = 23;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelectFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.Location = new System.Drawing.Point(304, 153);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 21);
            this.btnSelectFolder.TabIndex = 24;
            this.btnSelectFolder.Text = "SELECT";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelect.ForeColor = System.Drawing.Color.White;
            this.lblSelect.Location = new System.Drawing.Point(10, 138);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(124, 13);
            this.lblSelect.TabIndex = 25;
            this.lblSelect.Text = "Select Output Folder";
            // 
            // lblVideoExtension
            // 
            this.lblVideoExtension.AutoSize = true;
            this.lblVideoExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVideoExtension.ForeColor = System.Drawing.Color.White;
            this.lblVideoExtension.Location = new System.Drawing.Point(9, 196);
            this.lblVideoExtension.Name = "lblVideoExtension";
            this.lblVideoExtension.Size = new System.Drawing.Size(138, 13);
            this.lblVideoExtension.TabIndex = 26;
            this.lblVideoExtension.Text = "Select Video Extension";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(221, 196);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(102, 13);
            this.lblType.TabIndex = 27;
            this.lblType.Text = "Select Extension";
            // 
            // chcVideo
            // 
            this.chcVideo.AutoSize = true;
            this.chcVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chcVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chcVideo.ForeColor = System.Drawing.Color.White;
            this.chcVideo.Location = new System.Drawing.Point(224, 217);
            this.chcVideo.Name = "chcVideo";
            this.chcVideo.Size = new System.Drawing.Size(58, 17);
            this.chcVideo.TabIndex = 28;
            this.chcVideo.Text = "Video";
            this.chcVideo.UseVisualStyleBackColor = true;
            this.chcVideo.CheckedChanged += new System.EventHandler(this.chcVideo_CheckedChanged);
            // 
            // chcAudio
            // 
            this.chcAudio.AutoSize = true;
            this.chcAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chcAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chcAudio.ForeColor = System.Drawing.Color.White;
            this.chcAudio.Location = new System.Drawing.Point(288, 217);
            this.chcAudio.Name = "chcAudio";
            this.chcAudio.Size = new System.Drawing.Size(58, 17);
            this.chcAudio.TabIndex = 29;
            this.chcAudio.Text = "Audio";
            this.chcAudio.UseVisualStyleBackColor = true;
            this.chcAudio.CheckedChanged += new System.EventHandler(this.chcAudio_CheckedChanged);
            // 
            // chcAOT
            // 
            this.chcAOT.AutoSize = true;
            this.chcAOT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chcAOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chcAOT.ForeColor = System.Drawing.Color.White;
            this.chcAOT.Location = new System.Drawing.Point(12, 359);
            this.chcAOT.Name = "chcAOT";
            this.chcAOT.Size = new System.Drawing.Size(231, 17);
            this.chcAOT.TabIndex = 30;
            this.chcAOT.Text = "FELLOW - X Window always on top.";
            this.chcAOT.UseVisualStyleBackColor = true;
            this.chcAOT.CheckedChanged += new System.EventHandler(this.chcAOT_CheckedChanged);
            // 
            // txtStartHotkey
            // 
            this.txtStartHotkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStartHotkey.Enabled = false;
            this.txtStartHotkey.Location = new System.Drawing.Point(12, 323);
            this.txtStartHotkey.MaxLength = 3;
            this.txtStartHotkey.Name = "txtStartHotkey";
            this.txtStartHotkey.Size = new System.Drawing.Size(114, 20);
            this.txtStartHotkey.TabIndex = 32;
            this.txtStartHotkey.Text = "F12";
            this.txtStartHotkey.TextChanged += new System.EventHandler(this.txtStartHotkey_TextChanged);
            this.txtStartHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartHotkey_KeyDown);
            // 
            // txtStopHotkey
            // 
            this.txtStopHotkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStopHotkey.Enabled = false;
            this.txtStopHotkey.Location = new System.Drawing.Point(223, 323);
            this.txtStopHotkey.MaxLength = 3;
            this.txtStopHotkey.Name = "txtStopHotkey";
            this.txtStopHotkey.Size = new System.Drawing.Size(114, 20);
            this.txtStopHotkey.TabIndex = 33;
            this.txtStopHotkey.Text = "F11";
            this.txtStopHotkey.TextChanged += new System.EventHandler(this.txtStopHotkey_TextChanged);
            this.txtStopHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStopHotkey_KeyDown);
            // 
            // lblStartHotkey
            // 
            this.lblStartHotkey.AutoSize = true;
            this.lblStartHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStartHotkey.ForeColor = System.Drawing.Color.White;
            this.lblStartHotkey.Location = new System.Drawing.Point(10, 304);
            this.lblStartHotkey.Name = "lblStartHotkey";
            this.lblStartHotkey.Size = new System.Drawing.Size(78, 13);
            this.lblStartHotkey.TabIndex = 34;
            this.lblStartHotkey.Text = "Start Hotkey";
            // 
            // lblStopHotkey
            // 
            this.lblStopHotkey.AutoSize = true;
            this.lblStopHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStopHotkey.ForeColor = System.Drawing.Color.White;
            this.lblStopHotkey.Location = new System.Drawing.Point(221, 304);
            this.lblStopHotkey.Name = "lblStopHotkey";
            this.lblStopHotkey.Size = new System.Drawing.Size(77, 13);
            this.lblStopHotkey.TabIndex = 35;
            this.lblStopHotkey.Text = "Stop Hotkey";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(-1, 467);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(394, 15);
            this.lblError.TabIndex = 36;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSlideText
            // 
            this.tmrSlideText.Interval = 10;
            this.tmrSlideText.Tick += new System.EventHandler(this.tmrSlideText_Tick);
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(-1, 501);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(1659, 24);
            this.lblAuthor.TabIndex = 37;
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioWAV);
            this.panel2.Controls.Add(this.radioWMA);
            this.panel2.Controls.Add(this.radioMP3);
            this.panel2.Location = new System.Drawing.Point(12, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 29);
            this.panel2.TabIndex = 23;
            // 
            // radioWAV
            // 
            this.radioWAV.AutoSize = true;
            this.radioWAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioWAV.Enabled = false;
            this.radioWAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioWAV.ForeColor = System.Drawing.Color.White;
            this.radioWAV.Location = new System.Drawing.Point(116, 4);
            this.radioWAV.Name = "radioWAV";
            this.radioWAV.Size = new System.Drawing.Size(52, 17);
            this.radioWAV.TabIndex = 2;
            this.radioWAV.Text = ".wav";
            this.radioWAV.UseVisualStyleBackColor = true;
            // 
            // radioWMA
            // 
            this.radioWMA.AutoSize = true;
            this.radioWMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioWMA.Enabled = false;
            this.radioWMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioWMA.ForeColor = System.Drawing.Color.White;
            this.radioWMA.Location = new System.Drawing.Point(63, 4);
            this.radioWMA.Name = "radioWMA";
            this.radioWMA.Size = new System.Drawing.Size(54, 17);
            this.radioWMA.TabIndex = 1;
            this.radioWMA.Text = ".wma";
            this.radioWMA.UseVisualStyleBackColor = true;
            // 
            // radioMP3
            // 
            this.radioMP3.AutoSize = true;
            this.radioMP3.Checked = true;
            this.radioMP3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioMP3.Enabled = false;
            this.radioMP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioMP3.ForeColor = System.Drawing.Color.White;
            this.radioMP3.Location = new System.Drawing.Point(4, 4);
            this.radioMP3.Name = "radioMP3";
            this.radioMP3.Size = new System.Drawing.Size(52, 17);
            this.radioMP3.TabIndex = 0;
            this.radioMP3.TabStop = true;
            this.radioMP3.Text = ".mp3";
            this.radioMP3.UseVisualStyleBackColor = true;
            // 
            // lblAudioExtension
            // 
            this.lblAudioExtension.AutoSize = true;
            this.lblAudioExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAudioExtension.ForeColor = System.Drawing.Color.White;
            this.lblAudioExtension.Location = new System.Drawing.Point(9, 248);
            this.lblAudioExtension.Name = "lblAudioExtension";
            this.lblAudioExtension.Size = new System.Drawing.Size(138, 13);
            this.lblAudioExtension.TabIndex = 38;
            this.lblAudioExtension.Text = "Select Audio Extension";
            // 
            // chcCam
            // 
            this.chcCam.AutoSize = true;
            this.chcCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chcCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chcCam.ForeColor = System.Drawing.Color.White;
            this.chcCam.Location = new System.Drawing.Point(224, 268);
            this.chcCam.Name = "chcCam";
            this.chcCam.Size = new System.Drawing.Size(50, 17);
            this.chcCam.TabIndex = 39;
            this.chcCam.Text = "Cam";
            this.chcCam.UseVisualStyleBackColor = true;
            // 
            // chcImage
            // 
            this.chcImage.AutoSize = true;
            this.chcImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chcImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chcImage.ForeColor = System.Drawing.Color.White;
            this.chcImage.Location = new System.Drawing.Point(288, 268);
            this.chcImage.Name = "chcImage";
            this.chcImage.Size = new System.Drawing.Size(60, 17);
            this.chcImage.TabIndex = 40;
            this.chcImage.Text = "Image";
            this.chcImage.UseVisualStyleBackColor = true;
            this.chcImage.CheckedChanged += new System.EventHandler(this.chcImage_CheckedChanged);
            // 
            // lblInclude
            // 
            this.lblInclude.AutoSize = true;
            this.lblInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInclude.ForeColor = System.Drawing.Color.White;
            this.lblInclude.Location = new System.Drawing.Point(223, 248);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(55, 13);
            this.lblInclude.TabIndex = 41;
            this.lblInclude.Text = "Includes";
            // 
            // btnStartHotkey
            // 
            this.btnStartHotkey.Location = new System.Drawing.Point(133, 323);
            this.btnStartHotkey.Name = "btnStartHotkey";
            this.btnStartHotkey.Size = new System.Drawing.Size(17, 20);
            this.btnStartHotkey.TabIndex = 42;
            this.btnStartHotkey.UseVisualStyleBackColor = true;
            this.btnStartHotkey.Click += new System.EventHandler(this.btnStartHotkey_Click);
            // 
            // btnStopHotkey
            // 
            this.btnStopHotkey.Location = new System.Drawing.Point(343, 323);
            this.btnStopHotkey.Name = "btnStopHotkey";
            this.btnStopHotkey.Size = new System.Drawing.Size(17, 20);
            this.btnStopHotkey.TabIndex = 43;
            this.btnStopHotkey.UseVisualStyleBackColor = true;
            this.btnStopHotkey.Click += new System.EventHandler(this.btnStopHotkey_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStartStop.Location = new System.Drawing.Point(129, 393);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnStartStop.Size = new System.Drawing.Size(138, 40);
            this.btnStartStop.TabIndex = 10;
            this.btnStartStop.Text = "RECORD";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // Recorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(391, 552);
            this.ControlBox = false;
            this.Controls.Add(this.btnStopHotkey);
            this.Controls.Add(this.btnStartHotkey);
            this.Controls.Add(this.lblInclude);
            this.Controls.Add(this.chcImage);
            this.Controls.Add(this.chcCam);
            this.Controls.Add(this.lblAudioExtension);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblStopHotkey);
            this.Controls.Add(this.lblStartHotkey);
            this.Controls.Add(this.txtStopHotkey);
            this.Controls.Add(this.txtStartHotkey);
            this.Controls.Add(this.chcAOT);
            this.Controls.Add(this.chcAudio);
            this.Controls.Add(this.chcVideo);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblVideoExtension);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panelWindowMover);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Recorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recorder";
            this.Load += new System.EventHandler(this.Recorder_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Recorder_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recorder_KeyDown);
            this.panelWindowMover.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelWindowMover;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Timer tmrRecord;
        private System.Windows.Forms.Label lblTimer;
        private Controls.RoundedButton btnStartStop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioAVI;
        private System.Windows.Forms.RadioButton radioWMV;
        private System.Windows.Forms.RadioButton radioMP4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblVideoExtension;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckBox chcVideo;
        private System.Windows.Forms.CheckBox chcAudio;
        private System.Windows.Forms.CheckBox chcAOT;
        private System.Windows.Forms.TextBox txtStartHotkey;
        private System.Windows.Forms.TextBox txtStopHotkey;
        private System.Windows.Forms.Label lblStartHotkey;
        private System.Windows.Forms.Label lblStopHotkey;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer tmrSlideText;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioWAV;
        private System.Windows.Forms.RadioButton radioWMA;
        private System.Windows.Forms.RadioButton radioMP3;
        private System.Windows.Forms.Label lblAudioExtension;
        private System.Windows.Forms.CheckBox chcCam;
        private System.Windows.Forms.CheckBox chcImage;
        private System.Windows.Forms.Label lblInclude;
        private System.Windows.Forms.Button btnStartHotkey;
        private System.Windows.Forms.Button btnStopHotkey;
    }
}