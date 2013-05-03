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
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            newProject form = new newProject();
            form.Owner = this.Owner as BasicForm;
            form.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            newProject form = new newProject();
            form.ShowDialog();
        }
    }
}
