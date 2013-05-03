using System.Collections.Generic;
using System.Windows.Forms;
namespace CP_v1
{
    partial class CalcFundament
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
            this.addNewSectionLabel = new System.Windows.Forms.Label();
            this.sectionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rightCornerWidthTextBox = new System.Windows.Forms.TextBox();
            this.leftCornerWidthTextBox = new System.Windows.Forms.TextBox();
            this.rightCornerDeepLabelLabel = new System.Windows.Forms.Label();
            this.leftCornerDeepLabel = new System.Windows.Forms.Label();
            this.typeOfFundamentMateriallabel = new System.Windows.Forms.Label();
            this.typeOfFundComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sizeOfFundTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StagesTextBox = new System.Windows.Forms.TextBox();
            this.StagesLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rightCornerDeepTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.leftCornerDeepTextBox = new System.Windows.Forms.TextBox();
            this.cornerWidthLabel = new System.Windows.Forms.Label();
            this.WallHeightLabel = new System.Windows.Forms.Label();
            this.typeOfWallComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WallHeightTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sectionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewSectionLabel
            // 
            this.addNewSectionLabel.AutoSize = true;
            this.addNewSectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewSectionLabel.Location = new System.Drawing.Point(20, 15);
            this.addNewSectionLabel.Name = "addNewSectionLabel";
            this.addNewSectionLabel.Size = new System.Drawing.Size(86, 13);
            this.addNewSectionLabel.TabIndex = 1;
            this.addNewSectionLabel.Text = "Додати переріз";
            this.addNewSectionLabel.Click += new System.EventHandler(this.addNewSectionLabel_Click);
            // 
            // sectionPanel
            // 
            this.sectionPanel.AutoScroll = true;
            this.sectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sectionPanel.Controls.Add(this.addNewSectionLabel);
            this.sectionPanel.Location = new System.Drawing.Point(13, 20);
            this.sectionPanel.Name = "sectionPanel";
            this.sectionPanel.Size = new System.Drawing.Size(123, 297);
            this.sectionPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список перерізів";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.rightCornerWidthTextBox);
            this.panel1.Controls.Add(this.leftCornerWidthTextBox);
            this.panel1.Controls.Add(this.rightCornerDeepLabelLabel);
            this.panel1.Controls.Add(this.leftCornerDeepLabel);
            this.panel1.Controls.Add(this.typeOfFundamentMateriallabel);
            this.panel1.Controls.Add(this.typeOfFundComboBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.sizeOfFundTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.StagesTextBox);
            this.panel1.Controls.Add(this.StagesLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rightCornerDeepTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.leftCornerDeepTextBox);
            this.panel1.Controls.Add(this.cornerWidthLabel);
            this.panel1.Controls.Add(this.WallHeightLabel);
            this.panel1.Controls.Add(this.typeOfWallComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WallHeightTextBox);
            this.panel1.Location = new System.Drawing.Point(143, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 297);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "додати параметри";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(318, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "label14";
            // 
            // rightCornerWidthTextBox
            // 
            this.rightCornerWidthTextBox.Location = new System.Drawing.Point(279, 227);
            this.rightCornerWidthTextBox.Name = "rightCornerWidthTextBox";
            this.rightCornerWidthTextBox.Size = new System.Drawing.Size(121, 20);
            this.rightCornerWidthTextBox.TabIndex = 48;
            // 
            // leftCornerWidthTextBox
            // 
            this.leftCornerWidthTextBox.Location = new System.Drawing.Point(279, 200);
            this.leftCornerWidthTextBox.Name = "leftCornerWidthTextBox";
            this.leftCornerWidthTextBox.Size = new System.Drawing.Size(121, 20);
            this.leftCornerWidthTextBox.TabIndex = 47;
            // 
            // rightCornerDeepLabelLabel
            // 
            this.rightCornerDeepLabelLabel.AutoSize = true;
            this.rightCornerDeepLabelLabel.Location = new System.Drawing.Point(15, 174);
            this.rightCornerDeepLabelLabel.Name = "rightCornerDeepLabelLabel";
            this.rightCornerDeepLabelLabel.Size = new System.Drawing.Size(237, 13);
            this.rightCornerDeepLabelLabel.TabIndex = 46;
            this.rightCornerDeepLabelLabel.Text = "Глибина залягання правого виступу подушки";
            // 
            // leftCornerDeepLabel
            // 
            this.leftCornerDeepLabel.AutoSize = true;
            this.leftCornerDeepLabel.Location = new System.Drawing.Point(15, 146);
            this.leftCornerDeepLabel.Name = "leftCornerDeepLabel";
            this.leftCornerDeepLabel.Size = new System.Drawing.Size(227, 13);
            this.leftCornerDeepLabel.TabIndex = 45;
            this.leftCornerDeepLabel.Text = "Глибина залягання лівого виступу подушки";
            // 
            // typeOfFundamentMateriallabel
            // 
            this.typeOfFundamentMateriallabel.AutoSize = true;
            this.typeOfFundamentMateriallabel.Location = new System.Drawing.Point(15, 69);
            this.typeOfFundamentMateriallabel.Name = "typeOfFundamentMateriallabel";
            this.typeOfFundamentMateriallabel.Size = new System.Drawing.Size(147, 13);
            this.typeOfFundamentMateriallabel.TabIndex = 41;
            this.typeOfFundamentMateriallabel.Text = "Тип матеріалу фундамента:";
            // 
            // typeOfFundComboBox
            // 
            this.typeOfFundComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfFundComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.typeOfFundComboBox.Location = new System.Drawing.Point(191, 66);
            this.typeOfFundComboBox.Name = "typeOfFundComboBox";
            this.typeOfFundComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeOfFundComboBox.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "м³";
            // 
            // sizeOfFundTextBox
            // 
            this.sizeOfFundTextBox.Location = new System.Drawing.Point(191, 40);
            this.sizeOfFundTextBox.Name = "sizeOfFundTextBox";
            this.sizeOfFundTextBox.Size = new System.Drawing.Size(49, 20);
            this.sizeOfFundTextBox.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Об\'єм фундаменту на 1 м.п.";
            // 
            // StagesTextBox
            // 
            this.StagesTextBox.Location = new System.Drawing.Point(191, 8);
            this.StagesTextBox.Name = "StagesTextBox";
            this.StagesTextBox.Size = new System.Drawing.Size(49, 20);
            this.StagesTextBox.TabIndex = 36;
            // 
            // StagesLabel
            // 
            this.StagesLabel.AutoSize = true;
            this.StagesLabel.Location = new System.Drawing.Point(15, 15);
            this.StagesLabel.Name = "StagesLabel";
            this.StagesLabel.Size = new System.Drawing.Size(99, 13);
            this.StagesLabel.TabIndex = 35;
            this.StagesLabel.Text = "Кількість поверхів";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "м";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ширина";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Обрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightCornerDeepTextBox
            // 
            this.rightCornerDeepTextBox.Location = new System.Drawing.Point(279, 174);
            this.rightCornerDeepTextBox.Name = "rightCornerDeepTextBox";
            this.rightCornerDeepTextBox.Size = new System.Drawing.Size(121, 20);
            this.rightCornerDeepTextBox.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 227);
            this.label7.MaximumSize = new System.Drawing.Size(250, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ширина првого виступу";
            // 
            // leftCornerDeepTextBox
            // 
            this.leftCornerDeepTextBox.Location = new System.Drawing.Point(279, 146);
            this.leftCornerDeepTextBox.Name = "leftCornerDeepTextBox";
            this.leftCornerDeepTextBox.Size = new System.Drawing.Size(121, 20);
            this.leftCornerDeepTextBox.TabIndex = 29;
            // 
            // cornerWidthLabel
            // 
            this.cornerWidthLabel.AutoSize = true;
            this.cornerWidthLabel.Location = new System.Drawing.Point(14, 200);
            this.cornerWidthLabel.Name = "cornerWidthLabel";
            this.cornerWidthLabel.Size = new System.Drawing.Size(122, 13);
            this.cornerWidthLabel.TabIndex = 28;
            this.cornerWidthLabel.Text = "Ширина лівого виступу";
            // 
            // WallHeightLabel
            // 
            this.WallHeightLabel.AutoSize = true;
            this.WallHeightLabel.Location = new System.Drawing.Point(15, 93);
            this.WallHeightLabel.Name = "WallHeightLabel";
            this.WallHeightLabel.Size = new System.Drawing.Size(74, 13);
            this.WallHeightLabel.TabIndex = 27;
            this.WallHeightLabel.Text = "Висота стіни:";
            // 
            // typeOfWallComboBox
            // 
            this.typeOfWallComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfWallComboBox.FormattingEnabled = true;
            this.typeOfWallComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.typeOfWallComboBox.Location = new System.Drawing.Point(191, 117);
            this.typeOfWallComboBox.Name = "typeOfWallComboBox";
            this.typeOfWallComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeOfWallComboBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Тип кладки стіни:";
            // 
            // WallHeightTextBox
            // 
            this.WallHeightTextBox.Location = new System.Drawing.Point(191, 93);
            this.WallHeightTextBox.Name = "WallHeightTextBox";
            this.WallHeightTextBox.Size = new System.Drawing.Size(121, 20);
            this.WallHeightTextBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Робоча область";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "площа (a*b)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "розбити стіну на вище і нижче землі";
            // 
            // CalcFundament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 353);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sectionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "CalcFundament";
            this.Text = "CalcFundament";
            this.Activated += new System.EventHandler(this.CalcFundament_Activated);
            this.Load += new System.EventHandler(this.CalcFundament_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcFundament_KeyDown);
            this.sectionPanel.ResumeLayout(false);
            this.sectionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bool firstactivate;//перше активування вікна форми для задання першого розрізу
        private System.Windows.Forms.Label addNewSectionLabel;
        private List<System.Windows.Forms.RadioButton> sectionsRadioButton;
        private List<fundamentWorkspace> listSections;
        private string fileName;
        private Panel sectionPanel;
        private Label label1;
        private Panel panel1;
        private ComboBox typeOfFundComboBox;
        private Label label11;
        private TextBox sizeOfFundTextBox;
        private Label label10;
        private TextBox StagesTextBox;
        private Label StagesLabel;
        private Label label9;
        private Label label8;
        private Button button1;
        private TextBox rightCornerDeepTextBox;
        private Label label7;
        private TextBox leftCornerDeepTextBox;
        private Label cornerWidthLabel;
        private Label WallHeightLabel;
        private ComboBox typeOfWallComboBox;
        private Label label3;
        private TextBox WallHeightTextBox;
        private Label typeOfFundamentMateriallabel;
        private Label label12;
        private Label rightCornerDeepLabelLabel;
        private Label leftCornerDeepLabel;
        private TextBox leftCornerWidthTextBox;
        private TextBox rightCornerWidthTextBox;
        private Label label14;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        
    }
    
}