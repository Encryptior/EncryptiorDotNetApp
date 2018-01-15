namespace Encryptior
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.label3 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.timerStall = new System.Windows.Forms.Timer(this.components);
            this.backgroundInitialiser = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxIdenticon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdenticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encryptior";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseUp);
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(80, 226);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(160, 16);
            this.labelVersion.TabIndex = 34;
            this.labelVersion.Text = "Version 1.0.1.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseDown);
            this.labelVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseMove);
            this.labelVersion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseUp);
            // 
            // labelLoading
            // 
            this.labelLoading.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.White;
            this.labelLoading.Location = new System.Drawing.Point(0, 284);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(320, 16);
            this.labelLoading.TabIndex = 36;
            this.labelLoading.Text = "Checking Connection...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLoading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseDown);
            this.labelLoading.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseMove);
            this.labelLoading.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseUp);
            // 
            // timerStall
            // 
            this.timerStall.Enabled = true;
            this.timerStall.Tick += new System.EventHandler(this.timerStall_Tick);
            // 
            // backgroundInitialiser
            // 
            this.backgroundInitialiser.WorkerReportsProgress = true;
            this.backgroundInitialiser.WorkerSupportsCancellation = true;
            this.backgroundInitialiser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundInitialiser_DoWork);
            this.backgroundInitialiser.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundInitialiser_ProgressChanged);
            this.backgroundInitialiser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundInitialiser_RunWorkerCompleted);
            // 
            // pictureBoxIdenticon
            // 
            this.pictureBoxIdenticon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIdenticon.Location = new System.Drawing.Point(144, 246);
            this.pictureBoxIdenticon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxIdenticon.Name = "pictureBoxIdenticon";
            this.pictureBoxIdenticon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIdenticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIdenticon.TabIndex = 35;
            this.pictureBoxIdenticon.TabStop = false;
            this.pictureBoxIdenticon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseDown);
            this.pictureBoxIdenticon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseMove);
            this.pictureBoxIdenticon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Encryptior.Properties.Resources.EncryptiorTheProtector200;
            this.pictureBox1.Location = new System.Drawing.Point(80, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseUp);
            // 
            // closeBox
            // 
            this.closeBox.Image = global::Encryptior.Properties.Resources.icons8_Close_Window_32px;
            this.closeBox.Location = new System.Drawing.Point(294, 1);
            this.closeBox.Margin = new System.Windows.Forms.Padding(2);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(26, 26);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBox.TabIndex = 51;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeBox.MouseEnter += new System.EventHandler(this.closeBox_MouseEnter);
            this.closeBox.MouseLeave += new System.EventHandler(this.closeBox_MouseLeave);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.pictureBoxIdenticon);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdenticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureBoxIdenticon;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Timer timerStall;
        private System.ComponentModel.BackgroundWorker backgroundInitialiser;
        private System.Windows.Forms.PictureBox closeBox;
    }
}