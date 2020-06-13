namespace FellowX
{
    partial class AppStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppStartForm));
            this.btnLogo = new System.Windows.Forms.Button();
            this.pBarStart = new System.Windows.Forms.ProgressBar();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLogo
            // 
            this.btnLogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(6, 26);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(456, 70);
            this.btnLogo.TabIndex = 12;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // pBarStart
            // 
            this.pBarStart.ForeColor = System.Drawing.Color.Olive;
            this.pBarStart.Location = new System.Drawing.Point(6, 122);
            this.pBarStart.Maximum = 8;
            this.pBarStart.Name = "pBarStart";
            this.pBarStart.Size = new System.Drawing.Size(456, 13);
            this.pBarStart.TabIndex = 13;
            // 
            // tmrProgress
            // 
            this.tmrProgress.Interval = 500;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // AppStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(466, 175);
            this.Controls.Add(this.pBarStart);
            this.Controls.Add(this.btnLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppStartForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppStartForm";
            this.Load += new System.EventHandler(this.AppStartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.ProgressBar pBarStart;
        private System.Windows.Forms.Timer tmrProgress;
    }
}