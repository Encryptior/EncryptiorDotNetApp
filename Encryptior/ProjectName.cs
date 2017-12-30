using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encryptior
{
    public partial class ProjectName : Form
    {
        public string Project;
        public ProjectName()
        {
            InitializeComponent();
            this.ActiveControl = textBoxProjectName;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            string baseDir = textBoxPath.Text;
            if (!(baseDir.EndsWith("\\") || baseDir.EndsWith("/")))
                baseDir += "/";
            Project =  baseDir + textBoxProjectName.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonOK.PerformClick();
            }
        }

        private void textBoxPath_MouseClick(object sender, MouseEventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath != "")
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath != "")
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
