using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CP_v1
{
    public partial class CalcFundament : Form
    {
        public CalcFundament()
        {
            InitializeComponent();
            sectionsRadioButton = new List<RadioButton>();
            listSections = new List<fundamentWorkspace>();
            firstactivate = true;
            fileName = "temp.xml";
        }
        /// <summary>
        /// check data for correct
        /// </summary>
        /// <param name="index">index in list</param>
        /// <returns> is all correct</returns>
        private bool checkWorkSpace(int index)
        {
            int temp=new int();
            bool flag=true;
            string error = "";
            for (int i = 0; i < fundamentWorkspace.count; i++)
            {
                if (!Int32.TryParse(listSections[index].Iterator(i), out temp))
                {
                    flag = false;
                    error += listSections[index].Iterator(i) + " - некоректний ввід" + "\n";
                }
            }
            if (flag)
                MessageBox.Show(error);
            return flag;
        }
        /// <summary>
        /// Save entered parameters
        /// </summary>
        /// <param name="count">number in array</param>
        private void SaveSection(int count)
        {
            listSections[count].Save(StagesTextBox.Text, sizeOfFundTextBox.Text, 
                typeOfFundComboBox.SelectedIndex, WallHeightTextBox.Text,
                typeOfWallComboBox.SelectedIndex, leftCornerDeepTextBox.Text, rightCornerDeepTextBox.Text,
                leftCornerWidthTextBox.Text, rightCornerWidthTextBox.Text);
        }
        /// <summary>
        /// Finds checked radii button index
        /// </summary>
        /// <returns>index</returns>
        private int findCheckedRadioButton()
        {
            int i = 0;
            for (; i < sectionsRadioButton.Count - 1; i++)
                if (sectionsRadioButton[i].Checked)
                    break;
            return i;
        }
        /// <summary>
        /// generate form for input name of new section
        /// </summary>
        private void inputName()
        {
            Form f = new Form();
            Label TextLabel = new Label();
            TextBox sectionNameTextBox = new TextBox();
            Button ok = new Button();
            Button cencel = new Button();
            //f.Controls.Add(cencel);
            f.Controls.Add(ok);
            f.Controls.Add(sectionNameTextBox);
            f.Controls.Add(TextLabel);
            f.Width = 200;
            f.Height = 150;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            //
            //TextLabel
            //
            TextLabel.Location = new Point(10, 10);
            TextLabel.Size = new Size(200, 20);
            TextLabel.Text = "Введіть назву перерізу";
            //
            //sectionNameTextBox
            //
            sectionNameTextBox.Location = new Point(10,30);
            sectionNameTextBox.Name = "sectionNameTextBox";
            //
            //ok
            //
            ok.Location = new Point(10, 50);
            ok.Text = "Добре";
            ok.Click += new System.EventHandler(this.ok_Click);
            
            f.ShowDialog();
        }
        /// <summary>
        /// read data of fundament sections
        /// </summary>
        private void readWorkData()
        {
            List<string> parameters = new List<string>();
            parameters = File.readCalcFund(fileName);
            foreach (RadioButton button in sectionsRadioButton)
                this.sectionPanel.Controls.Remove(button);
            sectionsRadioButton.Clear();
            listSections.Clear();
            foreach (string section in parameters)
            {
                string[] attr = section.Split(' ');
                RadioButton button = new RadioButton();
                button.Text = attr[0];
                sectionsRadioButton.Add(button);
                initRadioButton();
                for (int i = 1; i < fundamentWorkspace.count; i++)
                {
                    listSections.Last().Seterator(i - 1, attr[i]);
                }
            }
        }
        /// <summary>
        /// initialisate last of radiobutton in list
        /// </summary>
        private void initRadioButton()
        {
            sectionsRadioButton.Last().AutoSize = true;
            sectionsRadioButton.Last().Location = new System.Drawing.Point(10, sectionsRadioButton.Count * 20);
            sectionsRadioButton.Last().Name = "radioButton" + sectionsRadioButton.Count.ToString();
            sectionsRadioButton.Last().Size = new System.Drawing.Size(85, 17);
            sectionsRadioButton.Last().TabIndex = 2;
            sectionsRadioButton.Last().TabStop = true;
            sectionsRadioButton.Last().UseVisualStyleBackColor = true;
            sectionsRadioButton.Last().CheckedChanged += new System.EventHandler(this.sectionsRadioButton_Checked);
            this.sectionPanel.Controls.Add(sectionsRadioButton.Last());
            this.addNewSectionLabel.Location = new System.Drawing.Point(20, sectionsRadioButton.Count * 20 + 20);
            listSections.Add(new fundamentWorkspace());
            
        }
        /// <summary>
        /// upload new data to workspace
        /// </summary>
        /// <param name="index">index in list</param>
        private void uploadPageToWorkplace(int index)
        {
            StagesTextBox.Text = Convert.ToString(listSections[index].NumberOfStairs);
            sizeOfFundTextBox.Text = Convert.ToString(listSections[index].SizePerMeter);
            typeOfFundComboBox.SelectedIndex = listSections[index].FundamentType;
            typeOfWallComboBox.SelectedIndex = listSections[index].TypeOfWall;
            WallHeightTextBox.Text = Convert.ToString(listSections[index].WallHeight);
            leftCornerDeepTextBox.Text = Convert.ToString(listSections[index].DeepLeftCorner);
            rightCornerDeepTextBox.Text = Convert.ToString(listSections[index].DeepRightCorner);
            leftCornerWidthTextBox.Text = Convert.ToString(listSections[index].WidthLeftCorner);
            rightCornerWidthTextBox.Text = Convert.ToString(listSections[index].WidthRightCorner);
        }
        private void WriteToFile(string name)
        {
            List<string> param = new List<string>();
            foreach (RadioButton section in sectionsRadioButton)
                param.Add(section.Text);
            File.SaveCalcFund(fileName, param, listSections);
        }
        private void ok_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            var t=a.FindForm().Controls.Find("sectionNameTextBox",true);
            TextBox b = t[0] as TextBox;
            if (b.Text != "")
            {
                sectionsRadioButton.Last().Text = b.Text;
                a.FindForm().Close();
            }
            else
            {
                MessageBox.Show("Порожня назва");
            }
        }
        private void addNewSectionLabel_Click(object sender, EventArgs e)
        {
            sectionsRadioButton.Add(new System.Windows.Forms.RadioButton());
            inputName();
            if (sectionsRadioButton.Last().Text == "")
                sectionsRadioButton.RemoveAt(sectionsRadioButton.Count - 1);
            else
            {
                initRadioButton();
                sectionsRadioButton.Last().Checked = true;
                uploadPageToWorkplace(sectionsRadioButton.Count - 1);
            }
        }        
        private void sectionsRadioButton_Checked(object sender, EventArgs e)
        {
            RadioButton current = sender as RadioButton;
            if (current.Checked == true)
                uploadPageToWorkplace(findCheckedRadioButton());

            else
                this.SaveSection(sectionsRadioButton.FindIndex(t => t.Name == current.Name));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            readWorkData();
            //this.SaveSection(findCheckedRadioButton());
            //WriteToFile("temp.xml");
        }
        /// <summary>
        /// при першій загрузці форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcFundament_Activated(object sender, EventArgs e)
        {
            if (firstactivate)
            {
                firstactivate = false;
                addNewSectionLabel_Click(null, null);
            }
        }
        /// <summary>
        /// new section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcFundament_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.Equals(Keys.N))
                addNewSectionLabel_Click(null,null);
        }

        private void CalcFundament_Load(object sender, EventArgs e)
        {

        }
    }

    
}
