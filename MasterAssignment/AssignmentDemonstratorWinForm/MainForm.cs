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


/*
 * Crystal Liles
 */

namespace AssignmentDemonstratorWinForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFilePath.Text = Properties.Settings.Default.PreviousFilePath;
        }

        private void MenuItemHelp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Master Assignment of Crystal Liles. Created 2019.");
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Comma Separated Values|*.CSV",
                Title = "Select the Hundred Names CSV",
                FileName = Properties.Settings.Default.PreviousFilePath
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            lblFilePath.Text = openFileDialog.FileName;
            Properties.Settings.Default.PreviousFilePath = openFileDialog.FileName;
            Properties.Settings.Default.Save();

            ListBoxOutput.Items.Clear();

            TxtFilePath.Text = openFileDialog.SafeFileName;
            using (StreamReader sr = File.OpenText(openFileDialog.FileName))
            {
                var oneLineOfText = "";
                while ((oneLineOfText = sr.ReadLine()) != null)
                {
                    ListBoxOutput.Items.Add(oneLineOfText);
                }
            }
        }
    }
}
