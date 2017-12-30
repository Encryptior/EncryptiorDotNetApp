namespace Encryptior
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxFileCostEth = new System.Windows.Forms.TextBox();
            this.textBoxTransFee = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalEther = new System.Windows.Forms.TextBox();
            this.backgroundWorkerTransaction = new System.ComponentModel.BackgroundWorker();
            this.labelFunds = new System.Windows.Forms.Label();
            this.labelNotEnough = new System.Windows.Forms.Label();
            this.pictureBoxIdenticon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdenticon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Encryptior.Properties.Resources.icons8_Request_Money_96px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.buttonConfirm.Location = new System.Drawing.Point(552, 201);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 40);
            this.buttonConfirm.TabIndex = 33;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(444, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 35;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(149, 7);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(227, 32);
            this.labelAddress.TabIndex = 36;
            this.labelAddress.Text = "Transfer confirmation";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.labelTo.Location = new System.Drawing.Point(151, 43);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(387, 20);
            this.labelTo.TabIndex = 38;
            this.labelTo.Text = "0x1097DBE425cFD2f827Dc1D5E0adfb78259AD28B5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(152, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cost (ether):";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Location = new System.Drawing.Point(155, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(500, 2);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxFileCostEth
            // 
            this.textBoxFileCostEth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFileCostEth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileCostEth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.textBoxFileCostEth.Location = new System.Drawing.Point(387, 74);
            this.textBoxFileCostEth.Name = "textBoxFileCostEth";
            this.textBoxFileCostEth.Size = new System.Drawing.Size(265, 22);
            this.textBoxFileCostEth.TabIndex = 44;
            this.textBoxFileCostEth.Text = "one moment...";
            this.textBoxFileCostEth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTransFee
            // 
            this.textBoxTransFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransFee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.textBoxTransFee.Location = new System.Drawing.Point(386, 112);
            this.textBoxTransFee.Name = "textBoxTransFee";
            this.textBoxTransFee.Size = new System.Drawing.Size(266, 22);
            this.textBoxTransFee.TabIndex = 47;
            this.textBoxTransFee.Text = "one moment...";
            this.textBoxTransFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.Location = new System.Drawing.Point(156, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(500, 2);
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(153, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Transaction Fee (ether):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(153, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Total Amount:";
            // 
            // textBoxTotalEther
            // 
            this.textBoxTotalEther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalEther.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalEther.ForeColor = System.Drawing.Color.Black;
            this.textBoxTotalEther.Location = new System.Drawing.Point(283, 145);
            this.textBoxTotalEther.Name = "textBoxTotalEther";
            this.textBoxTotalEther.Size = new System.Drawing.Size(369, 32);
            this.textBoxTotalEther.TabIndex = 49;
            this.textBoxTotalEther.Text = "one moment...";
            this.textBoxTotalEther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backgroundWorkerTransaction
            // 
            this.backgroundWorkerTransaction.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTransaction_DoWork);
            this.backgroundWorkerTransaction.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTransaction_RunWorkerCompleted);
            // 
            // labelFunds
            // 
            this.labelFunds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFunds.AutoSize = true;
            this.labelFunds.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunds.ForeColor = System.Drawing.Color.Black;
            this.labelFunds.Location = new System.Drawing.Point(12, 190);
            this.labelFunds.Name = "labelFunds";
            this.labelFunds.Size = new System.Drawing.Size(265, 28);
            this.labelFunds.TabIndex = 54;
            this.labelFunds.Text = "My Account: one moment...";
            // 
            // labelNotEnough
            // 
            this.labelNotEnough.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNotEnough.AutoSize = true;
            this.labelNotEnough.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotEnough.ForeColor = System.Drawing.Color.Red;
            this.labelNotEnough.Location = new System.Drawing.Point(12, 218);
            this.labelNotEnough.Name = "labelNotEnough";
            this.labelNotEnough.Size = new System.Drawing.Size(334, 23);
            this.labelNotEnough.TabIndex = 55;
            this.labelNotEnough.Text = "Not enough funds to make a transaction";
            this.labelNotEnough.Visible = false;
            // 
            // pictureBoxIdenticon
            // 
            this.pictureBoxIdenticon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIdenticon.Location = new System.Drawing.Point(618, 29);
            this.pictureBoxIdenticon.Name = "pictureBoxIdenticon";
            this.pictureBoxIdenticon.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxIdenticon.TabIndex = 56;
            this.pictureBoxIdenticon.TabStop = false;
            // 
            // TransferForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 254);
            this.Controls.Add(this.pictureBoxIdenticon);
            this.Controls.Add(this.labelNotEnough);
            this.Controls.Add(this.labelFunds);
            this.Controls.Add(this.textBoxTotalEther);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTransFee);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFileCostEth);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ether Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdenticon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxFileCostEth;
        private System.Windows.Forms.TextBox textBoxTransFee;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalEther;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTransaction;
        private System.Windows.Forms.Label labelFunds;
        private System.Windows.Forms.Label labelNotEnough;
        private System.Windows.Forms.PictureBox pictureBoxIdenticon;
    }
}