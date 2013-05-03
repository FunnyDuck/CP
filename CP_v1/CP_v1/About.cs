using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CP_v1
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = "About";
            this.labelProductName.Text = "Imhotep System";
            this.labelVersion.Text = "Version 1.0.0";
            this.labelCopyright.Text = "Всі права захищено. 2013";
            this.labelCompanyName.Text = "Funny Duck";
            this.textBoxDescription.Text = "Автоматизована система обрахунку фундаменту і деформації ґрунтів.";
        }
    }
}
