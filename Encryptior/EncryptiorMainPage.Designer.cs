using System.Drawing;
using System.Windows.Forms;

namespace Encryptior
{
    partial class EncryptiorMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptiorMainPage));
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.labelUsd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.logAndReadBalance = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openZipDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageListPublicFiles = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabelEthAddr = new System.Windows.Forms.LinkLabel();
            this.pictureBoxIdenticon = new System.Windows.Forms.PictureBox();
            this.buttonQR = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkNewVersionInstall = new System.Windows.Forms.LinkLabel();
            this.buttonLockData = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.buttonFaucet = new System.Windows.Forms.Button();
            this.buttonChangeWallet = new System.Windows.Forms.Button();
            this.buttonOpenEncrypted = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.readBalance = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdenticon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "archive-folder-40.png");
            this.imageListTabs.Images.SetKeyName(1, "wallet-40.png");
            this.imageListTabs.Images.SetKeyName(2, "ajax-loader.gif");
            // 
            // labelUsd
            // 
            this.labelUsd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsd.AutoSize = true;
            this.labelUsd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsd.ForeColor = System.Drawing.Color.Black;
            this.labelUsd.Location = new System.Drawing.Point(4, 199);
            this.labelUsd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsd.Name = "labelUsd";
            this.labelUsd.Size = new System.Drawing.Size(720, 51);
            this.labelUsd.TabIndex = 10;
            this.labelUsd.Text = "Hello";
            this.labelUsd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(720, 75);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account Overview";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // logAndReadBalance
            // 
            this.logAndReadBalance.WorkerReportsProgress = true;
            this.logAndReadBalance.DoWork += new System.ComponentModel.DoWorkEventHandler(this.logAndReadBalance_DoWork);
            this.logAndReadBalance.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.logAndReadBalance_ProgressChanged);
            this.logAndReadBalance.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.logAndReadBalance_RunWorkerCompleted);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "zip";
            this.saveFileDialog.Filter = "Zip Files|*.zip";
            // 
            // openZipDialog
            // 
            this.openZipDialog.Filter = "Encrypted Zip Files|*.zip";
            // 
            // imageListPublicFiles
            // 
            this.imageListPublicFiles.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListPublicFiles.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListPublicFiles.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelUsd, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(728, 701);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 664F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 129);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(720, 66);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.linkLabelEthAddr);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxIdenticon);
            this.flowLayoutPanel1.Controls.Add(this.buttonQR);
            this.flowLayoutPanel1.Controls.Add(this.buttonCopy);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 58);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // linkLabelEthAddr
            // 
            this.linkLabelEthAddr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelEthAddr.AutoSize = true;
            this.linkLabelEthAddr.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEthAddr.ForeColor = System.Drawing.Color.Blue;
            this.linkLabelEthAddr.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.linkLabelEthAddr.Location = new System.Drawing.Point(4, 15);
            this.linkLabelEthAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelEthAddr.Name = "linkLabelEthAddr";
            this.linkLabelEthAddr.Size = new System.Drawing.Size(472, 23);
            this.linkLabelEthAddr.TabIndex = 17;
            this.linkLabelEthAddr.TabStop = true;
            this.linkLabelEthAddr.Text = "0x942766be6F3171A4D5c0257a3869233b501175e1";
            this.linkLabelEthAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelEthAddr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEthAddr_LinkClicked);
            // 
            // pictureBoxIdenticon
            // 
            this.pictureBoxIdenticon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxIdenticon.Location = new System.Drawing.Point(485, 7);
            this.pictureBoxIdenticon.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxIdenticon.Name = "pictureBoxIdenticon";
            this.pictureBoxIdenticon.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxIdenticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIdenticon.TabIndex = 16;
            this.pictureBoxIdenticon.TabStop = false;
            // 
            // buttonQR
            // 
            this.buttonQR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQR.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonQR.FlatAppearance.BorderSize = 3;
            this.buttonQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQR.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQR.ForeColor = System.Drawing.Color.Black;
            this.buttonQR.Image = global::Encryptior.Properties.Resources.icons8_QR_Code_32px;
            this.buttonQR.Location = new System.Drawing.Point(534, 2);
            this.buttonQR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonQR.Name = "buttonQR";
            this.buttonQR.Size = new System.Drawing.Size(50, 50);
            this.buttonQR.TabIndex = 30;
            this.buttonQR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonQR.UseVisualStyleBackColor = true;
            this.buttonQR.Click += new System.EventHandler(this.buttonQR_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopy.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCopy.FlatAppearance.BorderSize = 3;
            this.buttonCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.ForeColor = System.Drawing.Color.Black;
            this.buttonCopy.Image = global::Encryptior.Properties.Resources.icons8_Copy_32px;
            this.buttonCopy.Location = new System.Drawing.Point(592, 2);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(50, 50);
            this.buttonCopy.TabIndex = 31;
            this.buttonCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 254);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 443);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.linkNewVersionInstall);
            this.panel1.Controls.Add(this.buttonLockData);
            this.panel1.Controls.Add(this.buttonTransfer);
            this.panel1.Controls.Add(this.buttonTransactions);
            this.panel1.Controls.Add(this.buttonFaucet);
            this.panel1.Controls.Add(this.buttonChangeWallet);
            this.panel1.Controls.Add(this.buttonOpenEncrypted);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(-77, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 435);
            this.panel1.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.DimGray;
            this.labelVersion.Location = new System.Drawing.Point(141, 310);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(99, 19);
            this.labelVersion.TabIndex = 33;
            this.labelVersion.Text = "Version 1.0.1.0";
            // 
            // linkNewVersionInstall
            // 
            this.linkNewVersionInstall.AutoSize = true;
            this.linkNewVersionInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNewVersionInstall.LinkColor = System.Drawing.Color.Red;
            this.linkNewVersionInstall.Location = new System.Drawing.Point(141, 326);
            this.linkNewVersionInstall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkNewVersionInstall.Name = "linkNewVersionInstall";
            this.linkNewVersionInstall.Size = new System.Drawing.Size(154, 20);
            this.linkNewVersionInstall.TabIndex = 32;
            this.linkNewVersionInstall.TabStop = true;
            this.linkNewVersionInstall.Text = "New version available";
            this.linkNewVersionInstall.Visible = false;
            this.linkNewVersionInstall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewVersionInstall_LinkClicked);
            // 
            // buttonLockData
            // 
            this.buttonLockData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLockData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLockData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLockData.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLockData.FlatAppearance.BorderSize = 3;
            this.buttonLockData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonLockData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLockData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLockData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLockData.ForeColor = System.Drawing.Color.Black;
            this.buttonLockData.Image = global::Encryptior.Properties.Resources.icons8_Lock_64px;
            this.buttonLockData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLockData.Location = new System.Drawing.Point(340, 2);
            this.buttonLockData.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonLockData.Name = "buttonLockData";
            this.buttonLockData.Size = new System.Drawing.Size(188, 150);
            this.buttonLockData.TabIndex = 30;
            this.buttonLockData.Text = "Lock Data";
            this.buttonLockData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLockData.UseVisualStyleBackColor = true;
            this.buttonLockData.Click += new System.EventHandler(this.buttonLockData_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransfer.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTransfer.FlatAppearance.BorderSize = 3;
            this.buttonTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfer.ForeColor = System.Drawing.Color.Black;
            this.buttonTransfer.Image = global::Encryptior.Properties.Resources.icons8_Request_Money_64px;
            this.buttonTransfer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTransfer.Location = new System.Drawing.Point(145, 158);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(188, 150);
            this.buttonTransfer.TabIndex = 29;
            this.buttonTransfer.Text = "Withdraw\r\nTransfer Money";
            this.buttonTransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonTransactions
            // 
            this.buttonTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransactions.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTransactions.FlatAppearance.BorderSize = 3;
            this.buttonTransactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactions.ForeColor = System.Drawing.Color.Black;
            this.buttonTransactions.Image = global::Encryptior.Properties.Resources.icons8_Transaction_64px;
            this.buttonTransactions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTransactions.Location = new System.Drawing.Point(340, 158);
            this.buttonTransactions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonTransactions.Name = "buttonTransactions";
            this.buttonTransactions.Size = new System.Drawing.Size(188, 150);
            this.buttonTransactions.TabIndex = 28;
            this.buttonTransactions.Text = "My Transactions";
            this.buttonTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTransactions.UseVisualStyleBackColor = true;
            this.buttonTransactions.Click += new System.EventHandler(this.buttonTransactions_Click);
            // 
            // buttonFaucet
            // 
            this.buttonFaucet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFaucet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFaucet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFaucet.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFaucet.FlatAppearance.BorderSize = 3;
            this.buttonFaucet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonFaucet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFaucet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaucet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaucet.ForeColor = System.Drawing.Color.Black;
            this.buttonFaucet.Image = global::Encryptior.Properties.Resources.icons8_Cash_in_Hand_64px;
            this.buttonFaucet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFaucet.Location = new System.Drawing.Point(535, 158);
            this.buttonFaucet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonFaucet.Name = "buttonFaucet";
            this.buttonFaucet.Size = new System.Drawing.Size(188, 150);
            this.buttonFaucet.TabIndex = 27;
            this.buttonFaucet.Text = "Gimme Monopoly\r\nMoney (Alpha)";
            this.buttonFaucet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFaucet.UseVisualStyleBackColor = true;
            this.buttonFaucet.Click += new System.EventHandler(this.buttonFaucet_Click);
            // 
            // buttonChangeWallet
            // 
            this.buttonChangeWallet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonChangeWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChangeWallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeWallet.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonChangeWallet.FlatAppearance.BorderSize = 3;
            this.buttonChangeWallet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonChangeWallet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonChangeWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeWallet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeWallet.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeWallet.Image = global::Encryptior.Properties.Resources.icons8_Wallet_64px;
            this.buttonChangeWallet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChangeWallet.Location = new System.Drawing.Point(145, 2);
            this.buttonChangeWallet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonChangeWallet.Name = "buttonChangeWallet";
            this.buttonChangeWallet.Size = new System.Drawing.Size(188, 150);
            this.buttonChangeWallet.TabIndex = 26;
            this.buttonChangeWallet.Text = "Change Main Wallet";
            this.buttonChangeWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonChangeWallet.UseVisualStyleBackColor = true;
            this.buttonChangeWallet.Click += new System.EventHandler(this.buttonChangeWallet_Click);
            // 
            // buttonOpenEncrypted
            // 
            this.buttonOpenEncrypted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpenEncrypted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenEncrypted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenEncrypted.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpenEncrypted.FlatAppearance.BorderSize = 3;
            this.buttonOpenEncrypted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonOpenEncrypted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpenEncrypted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenEncrypted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenEncrypted.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenEncrypted.Image = global::Encryptior.Properties.Resources.icons8_Unlock_2_64px;
            this.buttonOpenEncrypted.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpenEncrypted.Location = new System.Drawing.Point(535, 2);
            this.buttonOpenEncrypted.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonOpenEncrypted.Name = "buttonOpenEncrypted";
            this.buttonOpenEncrypted.Size = new System.Drawing.Size(188, 150);
            this.buttonOpenEncrypted.TabIndex = 25;
            this.buttonOpenEncrypted.Text = "Unlock Data";
            this.buttonOpenEncrypted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOpenEncrypted.UseVisualStyleBackColor = true;
            this.buttonOpenEncrypted.Click += new System.EventHandler(this.buttonOpenEncrypted_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(553, 2);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 20);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Alpha - TestNet (About)!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 10000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // readBalance
            // 
            this.readBalance.DoWork += new System.ComponentModel.DoWorkEventHandler(this.readBalance_DoWork);
            this.readBalance.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.logAndReadBalance_RunWorkerCompleted);
            // 
            // EncryptiorMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 701);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(746, 47);
            this.Name = "EncryptiorMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryptior Wallet";
            this.Load += new System.EventHandler(this.EncryptiorMainPage_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdenticon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelUsd;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker logAndReadBalance;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.PictureBox pictureBoxIdenticon;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openZipDialog;
        private System.Windows.Forms.ImageList imageListPublicFiles;
        private TableLayoutPanel tableLayoutPanel2;
        private LinkLabel linkLabelEthAddr;
        private Button buttonOpenEncrypted;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button buttonChangeWallet;
        private LinkLabel linkLabel1;
        private Timer timerRefresh;
        private System.ComponentModel.BackgroundWorker readBalance;
        private Button buttonFaucet;
        private Button buttonTransactions;
        private Button buttonTransfer;
        private Button buttonQR;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCopy;
        private Button buttonLockData;
        private LinkLabel linkNewVersionInstall;
        private Label labelVersion;
    }
}

