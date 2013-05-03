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
    public partial class Geolog : Form
    {
        public Geolog()
        {
            InitializeComponent();
            this.geologGridView1.Rows.Add();
        }
        private bool CheckCells()
        {
            string s = "";
            bool flag=true;
            foreach (DataGridViewRow row in this.geologGridView1.Rows)
            {
                int check = new int();
                for (int i = 1; i < 8; i++)
                {

                    if (i > 2 && (row.Cells[i].Value == null || !Int32.TryParse(row.Cells[i].Value.ToString(), out check)))
                    {
                        s += "Не коректний вміст в рядку " + (row.Index + 1)+" стувпцю " +(i+1)+"\n";
                        flag = false;
                    }
                    else if (i < 2 && row.Cells[i].Value == null || row.Cells[i].Value == "")
                    {
                        s += "Не коректний вміст в рядку " + (row.Index + 1) + " стувпцю " + (i + 1) + "\n";
                        flag = false;
                    }
                }
            }
            if (!flag)
                MessageBox.Show(s);
            return flag;
        }
        private void CheckCellsNumber()
        {
            int iter = 1;
            foreach (DataGridViewRow current in geologGridView1.Rows)
                current.Cells[0].Value = iter++;
        }
        private void Save()
        {
            string row = "";
            List<string> parameters = new List<string>();
            foreach (DataGridViewRow a in geologGridView1.Rows)
            {
                foreach (DataGridViewCell b in a.Cells)
                    row += b.Value.ToString() + " ";
                parameters.Add(row);
                row = "";
            }
            File.SaveGeolog(parameters, "temp.xml");
        }
        
        private void geologGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (geologGridView1.CurrentRow.Index != geologGridView1.Rows.Count-1)
                geologGridView1.Rows.Insert(geologGridView1.CurrentRow.Index+1, 1);
            else
                geologGridView1.Rows.Add();
            CheckCellsNumber();
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (geologGridView1.Rows.Count > 1)
            {
                geologGridView1.Rows.Remove(geologGridView1.Rows[geologGridView1.CurrentRow.Index]);
                CheckCellsNumber();
            }
        }

        private void newRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geologGridView1.Rows.Add();
        }

        private void geologReadyButton_Click(object sender, EventArgs e)
        {
            if (CheckCells())
            {
                Save();



                BasicForm main = this.Owner as BasicForm;
                main.tabControl1.TabPages.Add("Назва вкладки");

                //чудо код )
                Geolog form = new Geolog();
                form.TopLevel = false;
                form.Visible = true;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                main.tabControl1.TabPages[main.tabControl1.TabPages.Count - 1].Controls.Add(form);
            }
            
        }

        private void freezeRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.geologGridView1.CurrentRow.ReadOnly)
            {
                this.geologGridView1.CurrentRow.ReadOnly = false;
                geologGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                this.geologGridView1.CurrentRow.ReadOnly = true;
                geologGridView1.CurrentRow.DefaultCellStyle.BackColor=Color.Gray;
            }
        }

        private void geologGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (geologGridView1.Rows.Count > 1)
                geologGridView1.Rows[geologGridView1.Rows.Count - 1].Cells[0].Value = Convert.ToInt32(geologGridView1.Rows[geologGridView1.Rows.Count-2].Cells[0].Value) + 1;
            else
                geologGridView1.Rows[geologGridView1.Rows.Count-1].Cells[0].Value = 1;
        }
       
    }
}
