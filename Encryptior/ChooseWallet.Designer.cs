namespace Encryptior
{
    partial class ChooseWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseWallet));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Wallet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListIdenticons = new System.Windows.Forms.ImageList(this.components);
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOpenFiles = new System.Windows.Forms.Button();
            this.buttonCreateWallet = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Wallet});
            this.listView1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.LargeImageList = this.imageListIdenticons;
            this.listView1.Location = new System.Drawing.Point(15, 145);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(578, 262);
            this.listView1.SmallImageList = this.imageListIdenticons;
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Wallet
            // 
            this.Wallet.Text = "Wallet";
            this.Wallet.Width = 546;
            // 
            // imageListIdenticons
            // 
            this.imageListIdenticons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIdenticons.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListIdenticons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.buttonConfirm.Location = new System.Drawing.Point(468, 423);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(125, 40);
            this.buttonConfirm.TabIndex = 34;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(139)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpenFiles
            // 
            this.buttonOpenFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.buttonOpenFiles.Location = new System.Drawing.Point(15, 411);
            this.buttonOpenFiles.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonOpenFiles.Name = "buttonOpenFiles";
            this.buttonOpenFiles.Size = new System.Drawing.Size(165, 50);
            this.buttonOpenFiles.TabIndex = 38;
            this.buttonOpenFiles.Text = "Open Folder";
            this.buttonOpenFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenFiles.UseVisualStyleBackColor = true;
            this.buttonOpenFiles.Click += new System.EventHandler(this.buttonOpenFiles_Click);
            // 
            // buttonCreateWallet
            // 
            this.buttonCreateWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateWallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateWallet.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCreateWallet.FlatAppearance.BorderSize = 3;
            this.buttonCreateWallet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonCreateWallet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCreateWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateWallet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateWallet.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateWallet.Image = global::Encryptior.Properties.Resources.icons8_Wallet_64px;
            this.buttonCreateWallet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCreateWallet.Location = new System.Drawing.Point(15, 14);
            this.buttonCreateWallet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonCreateWallet.Name = "buttonCreateWallet";
            this.buttonCreateWallet.Size = new System.Drawing.Size(188, 125);
            this.buttonCreateWallet.TabIndex = 23;
            this.buttonCreateWallet.Text = "Add New Account";
            this.buttonCreateWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCreateWallet.UseVisualStyleBackColor = true;
            this.buttonCreateWallet.Click += new System.EventHandler(this.buttonCreateWallet_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImport.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonImport.FlatAppearance.BorderSize = 3;
            this.buttonImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.ForeColor = System.Drawing.Color.Black;
            this.buttonImport.Image = global::Encryptior.Properties.Resources.icons8_Import_64px;
            this.buttonImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonImport.Location = new System.Drawing.Point(210, 14);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(188, 125);
            this.buttonImport.TabIndex = 24;
            this.buttonImport.Text = "Import Existing";
            this.buttonImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackgroundImage = global::Encryptior.Properties.Resources.icons8_Help_32px;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHelp.Location = new System.Drawing.Point(558, 14);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(35, 35);
            this.buttonHelp.TabIndex = 49;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // ChooseWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 477);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOpenFiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCreateWallet);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChooseWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Wallet";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageListIdenticons;
        private System.Windows.Forms.ColumnHeader Wallet;
        private System.Windows.Forms.Button buttonCreateWallet;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOpenFiles;
        private System.Windows.Forms.Button buttonHelp;
    }
}