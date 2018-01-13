namespace Encryptior
{
    partial class DecrypterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecrypterPage));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTxDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabelTransHash = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelTransStatus = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFileDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelFilename = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelOwner = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCost = new System.Windows.Forms.Label();
            this.groupBoxTransaction = new System.Windows.Forms.GroupBox();
            this.timerTransactionChecker = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerHash = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.backgroundWorkerTransaction = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanelTStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorkerStatus = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxPassword = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelUnzip = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUnzipStatus = new System.Windows.Forms.Label();
            this.groupBoxUnzipped = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundDecompressor = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.pictureBoxIdenticonOwner = new System.Windows.Forms.PictureBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoadingTransaction = new System.Windows.Forms.PictureBox();
            this.buttonUnlockFile = new System.Windows.Forms.Button();
            this.pictureBoxUnzipStatus = new System.Windows.Forms.PictureBox();
            this.buttonOpenFiles = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxFileDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBoxTransaction.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelTStatus.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxPassword.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.flowLayoutPanelUnzip.SuspendLayout();
            this.groupBoxUnzipped.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdenticonOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnzipStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelTxDate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.linkLabelTransHash, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 26);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(906, 160);
            this.tableLayoutPanel4.TabIndex = 44;
            // 
            // labelTxDate
            // 
            this.labelTxDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTxDate.AutoSize = true;
            this.labelTxDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxDate.Location = new System.Drawing.Point(126, 68);
            this.labelTxDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTxDate.Name = "labelTxDate";
            this.labelTxDate.Size = new System.Drawing.Size(60, 23);
            this.labelTxDate.TabIndex = 43;
            this.labelTxDate.Text = "Dated:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Dated:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tx Hash:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Status:";
            // 
            // linkLabelTransHash
            // 
            this.linkLabelTransHash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelTransHash.AutoSize = true;
            this.linkLabelTransHash.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTransHash.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.linkLabelTransHash.Location = new System.Drawing.Point(125, 17);
            this.linkLabelTransHash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelTransHash.Name = "linkLabelTransHash";
            this.linkLabelTransHash.Size = new System.Drawing.Size(117, 20);
            this.linkLabelTransHash.TabIndex = 36;
            this.linkLabelTransHash.TabStop = true;
            this.linkLabelTransHash.Text = "0xabc123....";
            this.linkLabelTransHash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTransHash_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelTransStatus);
            this.panel1.Controls.Add(this.pictureBoxLoadingTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(125, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 44);
            this.panel1.TabIndex = 44;
            // 
            // linkLabelTransStatus
            // 
            this.linkLabelTransStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelTransStatus.AutoSize = true;
            this.linkLabelTransStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTransStatus.LinkColor = System.Drawing.Color.Black;
            this.linkLabelTransStatus.Location = new System.Drawing.Point(1, 11);
            this.linkLabelTransStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelTransStatus.Name = "linkLabelTransStatus";
            this.linkLabelTransStatus.Size = new System.Drawing.Size(104, 23);
            this.linkLabelTransStatus.TabIndex = 43;
            this.linkLabelTransStatus.TabStop = true;
            this.linkLabelTransStatus.Text = "No Payment";
            this.linkLabelTransStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTransStatus_LinkClicked);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Password:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPass.BackColor = System.Drawing.Color.White;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.textBoxPass.Location = new System.Drawing.Point(131, 22);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.ReadOnly = true;
            this.textBoxPass.Size = new System.Drawing.Size(490, 29);
            this.textBoxPass.TabIndex = 28;
            this.textBoxPass.Text = "pass";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "File:";
            // 
            // groupBoxFileDetails
            // 
            this.groupBoxFileDetails.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxFileDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFileDetails.Location = new System.Drawing.Point(4, 95);
            this.groupBoxFileDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFileDetails.Name = "groupBoxFileDetails";
            this.groupBoxFileDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFileDetails.Size = new System.Drawing.Size(914, 202);
            this.groupBoxFileDetails.TabIndex = 0;
            this.groupBoxFileDetails.TabStop = false;
            this.groupBoxFileDetails.Text = "File Details";
            this.groupBoxFileDetails.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelFilename, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 172);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Owner:";
            // 
            // linkLabelFilename
            // 
            this.linkLabelFilename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelFilename.AutoSize = true;
            this.linkLabelFilename.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFilename.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.linkLabelFilename.Location = new System.Drawing.Point(131, 8);
            this.linkLabelFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelFilename.Name = "linkLabelFilename";
            this.linkLabelFilename.Size = new System.Drawing.Size(94, 23);
            this.linkLabelFilename.TabIndex = 36;
            this.linkLabelFilename.TabStop = true;
            this.linkLabelFilename.Text = "Filename....";
            this.linkLabelFilename.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFilename_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cost:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxIdenticonOwner, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkLabelOwner, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 40);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 50);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // linkLabelOwner
            // 
            this.linkLabelOwner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelOwner.AutoSize = true;
            this.linkLabelOwner.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelOwner.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.linkLabelOwner.Location = new System.Drawing.Point(60, 15);
            this.linkLabelOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelOwner.Name = "linkLabelOwner";
            this.linkLabelOwner.Size = new System.Drawing.Size(108, 20);
            this.linkLabelOwner.TabIndex = 37;
            this.linkLabelOwner.TabStop = true;
            this.linkLabelOwner.Text = "0x123abc...";
            this.linkLabelOwner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOwner_LinkClicked);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel3.Controls.Add(this.labelCost);
            this.flowLayoutPanel3.Controls.Add(this.buttonBuy);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(131, 103);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(770, 56);
            this.flowLayoutPanel3.TabIndex = 38;
            // 
            // labelCost
            // 
            this.labelCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.Color.Black;
            this.labelCost.Location = new System.Drawing.Point(5, 15);
            this.labelCost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(46, 23);
            this.labelCost.TabIndex = 26;
            this.labelCost.Text = "100$";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxTransaction
            // 
            this.groupBoxTransaction.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTransaction.Location = new System.Drawing.Point(4, 355);
            this.groupBoxTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTransaction.Name = "groupBoxTransaction";
            this.groupBoxTransaction.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTransaction.Size = new System.Drawing.Size(914, 190);
            this.groupBoxTransaction.TabIndex = 1;
            this.groupBoxTransaction.TabStop = false;
            this.groupBoxTransaction.Text = "Transaction Details";
            this.groupBoxTransaction.Visible = false;
            // 
            // timerTransactionChecker
            // 
            this.timerTransactionChecker.Interval = 1000;
            this.timerTransactionChecker.Tick += new System.EventHandler(this.timerTransactionChecker_Tick);
            // 
            // backgroundWorkerHash
            // 
            this.backgroundWorkerHash.WorkerReportsProgress = true;
            this.backgroundWorkerHash.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerHash_DoWork);
            this.backgroundWorkerHash.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerHash_ProgressChanged);
            this.backgroundWorkerHash.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerHash_RunWorkerCompleted);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxLoading);
            this.flowLayoutPanel1.Controls.Add(this.labelStatus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 45);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(905, 42);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(46, 9);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(220, 23);
            this.labelStatus.TabIndex = 44;
            this.labelStatus.Text = "Generating File Checksum...";
            // 
            // backgroundWorkerTransaction
            // 
            this.backgroundWorkerTransaction.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTransaction_DoWork);
            this.backgroundWorkerTransaction.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTransaction_RunWorkerCompleted);
            // 
            // flowLayoutPanelTStatus
            // 
            this.flowLayoutPanelTStatus.Controls.Add(this.pictureBox1);
            this.flowLayoutPanelTStatus.Controls.Add(this.label3);
            this.flowLayoutPanelTStatus.Location = new System.Drawing.Point(4, 305);
            this.flowLayoutPanelTStatus.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelTStatus.Name = "flowLayoutPanelTStatus";
            this.flowLayoutPanelTStatus.Size = new System.Drawing.Size(905, 42);
            this.flowLayoutPanelTStatus.TabIndex = 45;
            this.flowLayoutPanelTStatus.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Looking if you already own the file...";
            // 
            // backgroundWorkerStatus
            // 
            this.backgroundWorkerStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerStatus_DoWork);
            this.backgroundWorkerStatus.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerStatus_RunWorkerCompleted);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelTitle);
            this.flowLayoutPanel2.Controls.Add(this.buttonHelp);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxFileDetails);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanelTStatus);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxTransaction);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxPassword);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanelUnzip);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxUnzipped);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(921, 970);
            this.flowLayoutPanel2.TabIndex = 46;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(5, 4);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(179, 32);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Decrypting Data";
            // 
            // groupBoxPassword
            // 
            this.groupBoxPassword.Controls.Add(this.tableLayoutPanel8);
            this.groupBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPassword.Location = new System.Drawing.Point(4, 553);
            this.groupBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPassword.Name = "groupBoxPassword";
            this.groupBoxPassword.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPassword.Size = new System.Drawing.Size(910, 104);
            this.groupBoxPassword.TabIndex = 46;
            this.groupBoxPassword.TabStop = false;
            this.groupBoxPassword.Text = "Password";
            this.groupBoxPassword.Visible = false;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel8.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBoxPass, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonUnlockFile, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 26);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(902, 74);
            this.tableLayoutPanel8.TabIndex = 42;
            // 
            // flowLayoutPanelUnzip
            // 
            this.flowLayoutPanelUnzip.Controls.Add(this.pictureBoxUnzipStatus);
            this.flowLayoutPanelUnzip.Controls.Add(this.labelUnzipStatus);
            this.flowLayoutPanelUnzip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelUnzip.Location = new System.Drawing.Point(4, 665);
            this.flowLayoutPanelUnzip.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelUnzip.Name = "flowLayoutPanelUnzip";
            this.flowLayoutPanelUnzip.Size = new System.Drawing.Size(905, 42);
            this.flowLayoutPanelUnzip.TabIndex = 47;
            this.flowLayoutPanelUnzip.Visible = false;
            // 
            // labelUnzipStatus
            // 
            this.labelUnzipStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUnzipStatus.AutoSize = true;
            this.labelUnzipStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnzipStatus.Location = new System.Drawing.Point(46, 9);
            this.labelUnzipStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnzipStatus.Name = "labelUnzipStatus";
            this.labelUnzipStatus.Size = new System.Drawing.Size(118, 23);
            this.labelUnzipStatus.TabIndex = 44;
            this.labelUnzipStatus.Text = "Unzipping File";
            // 
            // groupBoxUnzipped
            // 
            this.groupBoxUnzipped.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxUnzipped.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUnzipped.Location = new System.Drawing.Point(4, 715);
            this.groupBoxUnzipped.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUnzipped.Name = "groupBoxUnzipped";
            this.groupBoxUnzipped.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUnzipped.Size = new System.Drawing.Size(910, 112);
            this.groupBoxUnzipped.TabIndex = 48;
            this.groupBoxUnzipped.TabStop = false;
            this.groupBoxUnzipped.Text = "Files";
            this.groupBoxUnzipped.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonOpenFiles, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 26);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(902, 82);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // backgroundDecompressor
            // 
            this.backgroundDecompressor.WorkerReportsProgress = true;
            this.backgroundDecompressor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundDecompressor_DoWork);
            this.backgroundDecompressor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundDecompressor_ProgressChanged);
            this.backgroundDecompressor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundDecompressor_RunWorkerCompleted);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::Encryptior.Properties.Resources._25;
            this.pictureBoxLoading.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxLoading.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 43;
            this.pictureBoxLoading.TabStop = false;
            // 
            // pictureBoxIdenticonOwner
            // 
            this.pictureBoxIdenticonOwner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxIdenticonOwner.Location = new System.Drawing.Point(11, 5);
            this.pictureBoxIdenticonOwner.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxIdenticonOwner.Name = "pictureBoxIdenticonOwner";
            this.pictureBoxIdenticonOwner.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxIdenticonOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIdenticonOwner.TabIndex = 34;
            this.pictureBoxIdenticonOwner.TabStop = false;
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuy.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBuy.FlatAppearance.BorderSize = 3;
            this.buttonBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.ForeColor = System.Drawing.Color.Black;
            this.buttonBuy.Image = global::Encryptior.Properties.Resources.icons8_Buy_32px;
            this.buttonBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuy.Location = new System.Drawing.Point(60, 2);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(104, 50);
            this.buttonBuy.TabIndex = 27;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Encryptior.Properties.Resources._25;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLoadingTransaction
            // 
            this.pictureBoxLoadingTransaction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxLoadingTransaction.Image = global::Encryptior.Properties.Resources._25;
            this.pictureBoxLoadingTransaction.Location = new System.Drawing.Point(109, 5);
            this.pictureBoxLoadingTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxLoadingTransaction.Name = "pictureBoxLoadingTransaction";
            this.pictureBoxLoadingTransaction.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxLoadingTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingTransaction.TabIndex = 42;
            this.pictureBoxLoadingTransaction.TabStop = false;
            this.pictureBoxLoadingTransaction.Visible = false;
            // 
            // buttonUnlockFile
            // 
            this.buttonUnlockFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUnlockFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUnlockFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnlockFile.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUnlockFile.FlatAppearance.BorderSize = 3;
            this.buttonUnlockFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonUnlockFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUnlockFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnlockFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnlockFile.ForeColor = System.Drawing.Color.Black;
            this.buttonUnlockFile.Image = global::Encryptior.Properties.Resources.icons8_Unlock_2_32px_1;
            this.buttonUnlockFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnlockFile.Location = new System.Drawing.Point(630, 12);
            this.buttonUnlockFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonUnlockFile.Name = "buttonUnlockFile";
            this.buttonUnlockFile.Size = new System.Drawing.Size(120, 50);
            this.buttonUnlockFile.TabIndex = 27;
            this.buttonUnlockFile.Text = "Unlock";
            this.buttonUnlockFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUnlockFile.UseVisualStyleBackColor = true;
            this.buttonUnlockFile.Click += new System.EventHandler(this.buttonUnlockFile_Click);
            // 
            // pictureBoxUnzipStatus
            // 
            this.pictureBoxUnzipStatus.Image = global::Encryptior.Properties.Resources._25;
            this.pictureBoxUnzipStatus.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxUnzipStatus.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxUnzipStatus.Name = "pictureBoxUnzipStatus";
            this.pictureBoxUnzipStatus.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxUnzipStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUnzipStatus.TabIndex = 43;
            this.pictureBoxUnzipStatus.TabStop = false;
            // 
            // buttonOpenFiles
            // 
            this.buttonOpenFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonOpenFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFiles.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpenFiles.FlatAppearance.BorderSize = 3;
            this.buttonOpenFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonOpenFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpenFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFiles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFiles.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenFiles.Image = global::Encryptior.Properties.Resources.icons8_Open_32px;
            this.buttonOpenFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFiles.Location = new System.Drawing.Point(5, 24);
            this.buttonOpenFiles.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonOpenFiles.Name = "buttonOpenFiles";
            this.buttonOpenFiles.Size = new System.Drawing.Size(171, 50);
            this.buttonOpenFiles.TabIndex = 24;
            this.buttonOpenFiles.Text = "Open Folder";
            this.buttonOpenFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenFiles.UseVisualStyleBackColor = true;
            this.buttonOpenFiles.Click += new System.EventHandler(this.buttonOpenFiles_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHelp.BackgroundImage = global::Encryptior.Properties.Resources.icons8_Help_32px;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHelp.Location = new System.Drawing.Point(192, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(35, 35);
            this.buttonHelp.TabIndex = 48;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // DecrypterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 855);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(963, 47);
            this.Name = "DecrypterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decypher";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFileDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBoxTransaction.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanelTStatus.ResumeLayout(false);
            this.flowLayoutPanelTStatus.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBoxPassword.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.flowLayoutPanelUnzip.ResumeLayout(false);
            this.flowLayoutPanelUnzip.PerformLayout();
            this.groupBoxUnzipped.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdenticonOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnzipStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelTxDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabelTransHash;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabelTransStatus;
        private System.Windows.Forms.PictureBox pictureBoxLoadingTransaction;
        private System.Windows.Forms.Button buttonUnlockFile;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxFileDetails;
        private System.Windows.Forms.GroupBox groupBoxTransaction;
        private System.Windows.Forms.Timer timerTransactionChecker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Label labelStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHash;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTransaction;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorkerStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.ComponentModel.BackgroundWorker backgroundDecompressor;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUnzip;
        private System.Windows.Forms.PictureBox pictureBoxUnzipStatus;
        private System.Windows.Forms.Label labelUnzipStatus;
        private System.Windows.Forms.GroupBox groupBoxUnzipped;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonOpenFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelFilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxIdenticonOwner;
        private System.Windows.Forms.LinkLabel linkLabelOwner;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp;
    }
}