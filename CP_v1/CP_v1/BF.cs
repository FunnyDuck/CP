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
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
            if (SystemInformation.PrimaryMonitorMaximizedWindowSize.Width > 800) 
            {
                this.Width = 800;
            }
            else
            {
                this.Width = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width;
            }
            if (SystemInformation.PrimaryMonitorMaximizedWindowSize.Height > 600)
            {
                this.Height = 600;
            }
            else 
            {
                this.Height = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height;
            }


            Task start = new Task();
            this.Show();
            start.ShowDialog(this);


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About FunnyDuck = new About();
            FunnyDuck.ShowDialog();
        }
    }
}
