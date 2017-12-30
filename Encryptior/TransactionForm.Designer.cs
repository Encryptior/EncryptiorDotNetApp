namespace Encryptior
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileCostUsd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFileCostEth = new System.Windows.Forms.TextBox();
            this.textBoxTransFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalEther = new System.Windows.Forms.TextBox();
            this.textBoxTotalUsd = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelExpiredNotification = new System.Windows.Forms.Label();
            this.timerExpiry = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerTransaction = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerPay = new System.ComponentModel.BackgroundWorker();
            this.labelFunds = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.buttonConfirm.Location = new System.Drawing.Point(586, 369);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(125, 50);
            this.buttonConfirm.TabIndex = 33;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(451, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 35;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(142, 11);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(236, 32);
            this.labelAddress.TabIndex = 36;
            this.labelAddress.Text = "Payment confirmation";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(146, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "For:";
            // 
            // labelFilename
            // 
            this.labelFilename.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.labelFilename.Location = new System.Drawing.Point(201, 51);
            this.labelFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(223, 23);
            this.labelFilename.TabIndex = 38;
            this.labelFilename.Text = "Verylongfilenameblablabla...";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(146, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cost ($):";
            // 
            // textBoxFileCostUsd
            // 
            this.textBoxFileCostUsd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxFileCostUsd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFileCostUsd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileCostUsd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.textBoxFileCostUsd.Location = new System.Drawing.Point(380, 101);
            this.textBoxFileCostUsd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFileCostUsd.Name = "textBoxFileCostUsd";
            this.textBoxFileCostUsd.Size = new System.Drawing.Size(331, 22);
            this.textBoxFileCostUsd.TabIndex = 41;
            this.textBoxFileCostUsd.Text = "one moment...";
            this.textBoxFileCostUsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(145, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cost (ether):";
            // 
            // textBoxFileCostEth
            // 
            this.textBoxFileCostEth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxFileCostEth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFileCostEth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileCostEth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.textBoxFileCostEth.Location = new System.Drawing.Point(380, 148);
            this.textBoxFileCostEth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFileCostEth.Name = "textBoxFileCostEth";
            this.textBoxFileCostEth.Size = new System.Drawing.Size(331, 22);
            this.textBoxFileCostEth.TabIndex = 44;
            this.textBoxFileCostEth.Text = "one moment...";
            this.textBoxFileCostEth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTransFee
            // 
            this.textBoxTransFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxTransFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransFee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.textBoxTransFee.Location = new System.Drawing.Point(378, 196);
            this.textBoxTransFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTransFee.Name = "textBoxTransFee";
            this.textBoxTransFee.Size = new System.Drawing.Size(332, 22);
            this.textBoxTransFee.TabIndex = 47;
            this.textBoxTransFee.Text = "one moment...";
            this.textBoxTransFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(146, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Transaction Fee (ether):";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(146, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Total Amount:";
            // 
            // textBoxTotalEther
            // 
            this.textBoxTotalEther.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxTotalEther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalEther.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalEther.ForeColor = System.Drawing.Color.Black;
            this.textBoxTotalEther.Location = new System.Drawing.Point(296, 235);
            this.textBoxTotalEther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotalEther.Name = "textBoxTotalEther";
            this.textBoxTotalEther.Size = new System.Drawing.Size(415, 27);
            this.textBoxTotalEther.TabIndex = 49;
            this.textBoxTotalEther.Text = "one moment...";
            this.textBoxTotalEther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotalUsd
            // 
            this.textBoxTotalUsd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxTotalUsd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalUsd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalUsd.ForeColor = System.Drawing.Color.Black;
            this.textBoxTotalUsd.Location = new System.Drawing.Point(298, 276);
            this.textBoxTotalUsd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotalUsd.Name = "textBoxTotalUsd";
            this.textBoxTotalUsd.Size = new System.Drawing.Size(414, 27);
            this.textBoxTotalUsd.TabIndex = 50;
            this.textBoxTotalUsd.Text = "one moment...";
            this.textBoxTotalUsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.textBoxCourse.Location = new System.Drawing.Point(296, 324);
            this.textBoxCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(415, 22);
            this.textBoxCourse.TabIndex = 51;
            this.textBoxCourse.Text = "one moment...";
            this.textBoxCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelExpiredNotification
            // 
            this.labelExpiredNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelExpiredNotification.AutoSize = true;
            this.labelExpiredNotification.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpiredNotification.ForeColor = System.Drawing.Color.Red;
            this.labelExpiredNotification.Location = new System.Drawing.Point(10, 369);
            this.labelExpiredNotification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpiredNotification.Name = "labelExpiredNotification";
            this.labelExpiredNotification.Size = new System.Drawing.Size(183, 23);
            this.labelExpiredNotification.TabIndex = 52;
            this.labelExpiredNotification.Text = "Transaction expires in";
            // 
            // timerExpiry
            // 
            this.timerExpiry.Interval = 1000;
            this.timerExpiry.Tick += new System.EventHandler(this.timerExpiry_Tick);
            // 
            // backgroundWorkerTransaction
            // 
            this.backgroundWorkerTransaction.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTransaction_DoWork);
            this.backgroundWorkerTransaction.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTransaction_RunWorkerCompleted);
            // 
            // backgroundWorkerPay
            // 
            this.backgroundWorkerPay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPay_DoWork);
            this.backgroundWorkerPay.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPay_RunWorkerCompleted);
            // 
            // labelFunds
            // 
            this.labelFunds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFunds.AutoSize = true;
            this.labelFunds.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunds.ForeColor = System.Drawing.Color.Black;
            this.labelFunds.Location = new System.Drawing.Point(9, 324);
            this.labelFunds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunds.Name = "labelFunds";
            this.labelFunds.Size = new System.Drawing.Size(265, 28);
            this.labelFunds.TabIndex = 54;
            this.labelFunds.Text = "My Account: one moment...";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.Location = new System.Drawing.Point(150, 225);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(569, 2);
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Location = new System.Drawing.Point(148, 176);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(569, 2);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Location = new System.Drawing.Point(151, 131);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(569, 2);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Encryptior.Properties.Resources.icons8_Transaction_96px;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 435);
            this.Controls.Add(this.labelFunds);
            this.Controls.Add(this.labelExpiredNotification);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxTotalUsd);
            this.Controls.Add(this.textBoxTotalEther);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTransFee);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFileCostEth);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFileCostUsd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxFileCostUsd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxFileCostEth;
        private System.Windows.Forms.TextBox textBoxTransFee;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalEther;
        private System.Windows.Forms.TextBox textBoxTotalUsd;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelExpiredNotification;
        private System.Windows.Forms.Timer timerExpiry;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTransaction;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPay;
        private System.Windows.Forms.Label labelFunds;
    }
}