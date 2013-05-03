using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CP_v1
{
    public partial class newProject : Form
    {
        public newProject()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialogNewProject.ShowDialog();
            string ass = string.Empty;
            ass = folderBrowserDialogNewProject.SelectedPath;
            if (textBoxNewNameProject.TextLength != 0)
            {
                ass += "\\";
                ass += textBoxNewNameProject.Text;
            }
            textboxNewProjectPath.Text = ass;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBoxNewNameProject_TextChanged(object sender, EventArgs e)
        {
            //textboxNewProjectPath.Text += textBoxNewNameProject;
            textboxNewProjectPath.Text=folderBrowserDialogNewProject.SelectedPath;
            string temp = String.Empty;
            temp = textboxNewProjectPath.Text;
            if (temp[temp.Length-1]!='\\')
                textboxNewProjectPath.Text += "\\";

            textboxNewProjectPath.Text += textBoxNewNameProject.Text;
        }

        private void buttonNewProjectOk_Click(object sender, EventArgs e)
        {
            string SavedPath = String.Empty;
            SavedPath = textboxNewProjectPath.Text;
            this.Close();


            BasicForm main = this.Owner as BasicForm;
            main.tabControl1.TabPages.Add("Геологія");

            //чудо код )
            Geolog form = new Geolog(); 
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            main.tabControl1.TabPages[main.tabControl1.TabPages.Count-1].Controls.Add(form);
        }

        private void buttonNewProjectCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
