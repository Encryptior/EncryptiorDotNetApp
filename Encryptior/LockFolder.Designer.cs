namespace Encryptior
{
    partial class LockFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockFolder));
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundCompressor = new System.ComponentModel.BackgroundWorker();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSingleUser = new System.Windows.Forms.CheckBox();
            this.textBoxSingleUser = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpenFiles = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(4, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(176, 32);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Encrypting Data";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCost.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.ForeColor = System.Drawing.Color.Black;
            this.textBoxCost.Location = new System.Drawing.Point(85, 14);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(129, 31);
            this.textBoxCost.TabIndex = 28;
            this.textBoxCost.Text = "10.00";
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCost.TextChanged += new System.EventHandler(this.textBoxCost_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.label10.Location = new System.Drawing.Point(4, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cost ($):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxProjectName.BackColor = System.Drawing.Color.White;
            this.textBoxProjectName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.textBoxProjectName.Location = new System.Drawing.Point(133, 4);
            this.textBoxProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(404, 31);
            this.textBoxProjectName.TabIndex = 0;
            this.textBoxProjectName.Text = "New Encrypted File";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "zip";
            this.saveFileDialog.Filter = "Zip Files|*.zip";
            // 
            // backgroundCompressor
            // 
            this.backgroundCompressor.WorkerReportsProgress = true;
            this.backgroundCompressor.WorkerSupportsCancellation = true;
            this.backgroundCompressor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundCompressor_DoWork);
            this.backgroundCompressor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundCompressor_ProgressChanged);
            this.backgroundCompressor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundCompressor_RunWorkerCompleted);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.dateModified,
            this.size,
            this.status});
            this.listViewFiles.ContextMenuStrip = this.contextMenuStrip;
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.LargeImageList = this.imageList1;
            this.listViewFiles.Location = new System.Drawing.Point(2, 273);
            this.listViewFiles.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(916, 490);
            this.listViewFiles.SmallImageList = this.imageList1;
            this.listViewFiles.TabIndex = 37;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.DoubleClick += new System.EventHandler(this.listViewFiles_DoubleClick);
            this.listViewFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewFiles_MouseClick);
            // 
            // fileName
            // 
            this.fileName.Text = "Name";
            this.fileName.Width = 187;
            // 
            // dateModified
            // 
            this.dateModified.Text = "Date modified";
            this.dateModified.Width = 227;
            // 
            // size
            // 
            this.size.Text = "Size";
            this.size.Width = 66;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 154;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(133, 28);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 24);
            this.delete.Text = "Remove";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(20, 20);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listViewFiles, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 765);
            this.tableLayoutPanel1.TabIndex = 41;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonOpenFiles);
            this.flowLayoutPanel1.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 209);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(916, 60);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.textBoxCost);
            this.flowLayoutPanel2.Controls.Add(this.buttonLock);
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxLoading);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 143);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(916, 62);
            this.flowLayoutPanel2.TabIndex = 39;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.textBoxProjectName);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 53);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(916, 47);
            this.flowLayoutPanel3.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Archive Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.checkBox1);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxSingleUser);
            this.flowLayoutPanel4.Controls.Add(this.textBoxSingleUser);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(2, 104);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(916, 35);
            this.flowLayoutPanel4.TabIndex = 41;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(2, 3);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 27);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "No confirmation";
            this.toolTip1.SetToolTip(this.checkBox1, "If the cost is low enough it is more convinient for the buyer with this");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSingleUser
            // 
            this.checkBoxSingleUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxSingleUser.AutoSize = true;
            this.checkBoxSingleUser.Enabled = false;
            this.checkBoxSingleUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSingleUser.Location = new System.Drawing.Point(163, 3);
            this.checkBoxSingleUser.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSingleUser.Name = "checkBoxSingleUser";
            this.checkBoxSingleUser.Size = new System.Drawing.Size(150, 27);
            this.checkBoxSingleUser.TabIndex = 42;
            this.checkBoxSingleUser.Text = "Single User Buy";
            this.checkBoxSingleUser.UseVisualStyleBackColor = true;
            this.checkBoxSingleUser.CheckedChanged += new System.EventHandler(this.checkBoxSingleUser_CheckedChanged);
            // 
            // textBoxSingleUser
            // 
            this.textBoxSingleUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSingleUser.BackColor = System.Drawing.Color.White;
            this.textBoxSingleUser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSingleUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.textBoxSingleUser.Location = new System.Drawing.Point(319, 4);
            this.textBoxSingleUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSingleUser.Name = "textBoxSingleUser";
            this.textBoxSingleUser.Size = new System.Drawing.Size(404, 25);
            this.textBoxSingleUser.TabIndex = 43;
            this.textBoxSingleUser.Text = "0x...";
            this.textBoxSingleUser.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
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
            this.buttonOpenFiles.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFiles.Image")));
            this.buttonOpenFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFiles.Location = new System.Drawing.Point(4, 2);
            this.buttonOpenFiles.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonOpenFiles.Name = "buttonOpenFiles";
            this.buttonOpenFiles.Size = new System.Drawing.Size(138, 55);
            this.buttonOpenFiles.TabIndex = 30;
            this.buttonOpenFiles.Text = "Add Files";
            this.buttonOpenFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenFiles.UseVisualStyleBackColor = true;
            this.buttonOpenFiles.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.FlatAppearance.BorderSize = 3;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(150, 2);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(129, 55);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Remove";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLock.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLock.FlatAppearance.BorderSize = 3;
            this.buttonLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLock.ForeColor = System.Drawing.Color.Black;
            this.buttonLock.Image = ((System.Drawing.Image)(resources.GetObject("buttonLock.Image")));
            this.buttonLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLock.Location = new System.Drawing.Point(223, 2);
            this.buttonLock.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(156, 55);
            this.buttonLock.TabIndex = 29;
            this.buttonLock.Text = "Lock && Save";
            this.buttonLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.Image")));
            this.pictureBoxLoading.Location = new System.Drawing.Point(388, 14);
            this.pictureBoxLoading.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(28, 30);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 32;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // LockFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 765);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(740, 47);
            this.Name = "LockFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LockFolder_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonOpenFiles;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundCompressor;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader dateModified;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxSingleUser;
        private System.Windows.Forms.TextBox textBoxSingleUser;
    }
}