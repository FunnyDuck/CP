namespace CP_v1
{
    partial class newProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialogNewProject = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNewNameProject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxNewProjectPath = new System.Windows.Forms.TextBox();
            this.labelNewProjectPath = new System.Windows.Forms.Label();
            this.buttonNewProjectOk = new System.Windows.Forms.Button();
            this.buttonNewProjectCencel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 2;
            
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Назва об\'єкта:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(169, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Місце знаходження (місто):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата виконання:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Виконавець:";
            // 
            // folderBrowserDialogNewProject
            // 
            this.folderBrowserDialogNewProject.Description = "Виберіть папку розташування нового проекту:";
            this.folderBrowserDialogNewProject.SelectedPath = "C:\\";
            this.folderBrowserDialogNewProject.Tag = "";
            this.folderBrowserDialogNewProject.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Змінити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNewNameProject
            // 
            this.textBoxNewNameProject.Location = new System.Drawing.Point(169, 169);
            this.textBoxNewNameProject.Name = "textBoxNewNameProject";
            this.textBoxNewNameProject.Size = new System.Drawing.Size(186, 20);
            this.textBoxNewNameProject.TabIndex = 11;
            this.textBoxNewNameProject.TextChanged += new System.EventHandler(this.textBoxNewNameProject_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Назва проекту:";
            // 
            // textboxNewProjectPath
            // 
            this.textboxNewProjectPath.Location = new System.Drawing.Point(12, 235);
            this.textboxNewProjectPath.Name = "textboxNewProjectPath";
            this.textboxNewProjectPath.Size = new System.Drawing.Size(343, 20);
            this.textboxNewProjectPath.TabIndex = 13;
            this.textboxNewProjectPath.Text = this.folderBrowserDialogNewProject.SelectedPath;
            // 
            // labelNewProjectPath
            // 
            this.labelNewProjectPath.AutoSize = true;
            this.labelNewProjectPath.Location = new System.Drawing.Point(12, 219);
            this.labelNewProjectPath.Name = "labelNewProjectPath";
            this.labelNewProjectPath.Size = new System.Drawing.Size(114, 13);
            this.labelNewProjectPath.TabIndex = 14;
            this.labelNewProjectPath.Text = "Місце розташування:";
            // 
            // buttonNewProjectOk
            // 
            this.buttonNewProjectOk.Location = new System.Drawing.Point(15, 273);
            this.buttonNewProjectOk.Name = "buttonNewProjectOk";
            this.buttonNewProjectOk.Size = new System.Drawing.Size(75, 23);
            this.buttonNewProjectOk.TabIndex = 16;
            this.buttonNewProjectOk.Text = "Ok";
            this.buttonNewProjectOk.UseVisualStyleBackColor = true;
            this.buttonNewProjectOk.Click += new System.EventHandler(this.buttonNewProjectOk_Click);
            // 
            // buttonNewProjectCencel
            // 
            this.buttonNewProjectCencel.Location = new System.Drawing.Point(121, 272);
            this.buttonNewProjectCencel.Name = "buttonNewProjectCencel";
            this.buttonNewProjectCencel.Size = new System.Drawing.Size(75, 23);
            this.buttonNewProjectCencel.TabIndex = 17;
            this.buttonNewProjectCencel.Text = "Скасувати";
            this.buttonNewProjectCencel.UseVisualStyleBackColor = true;
            this.buttonNewProjectCencel.Click += new System.EventHandler(this.buttonNewProjectCencel_Click);
            // 
            // newProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 310);
            this.Controls.Add(this.buttonNewProjectCencel);
            this.Controls.Add(this.buttonNewProjectOk);
            this.Controls.Add(this.labelNewProjectPath);
            this.Controls.Add(this.textboxNewProjectPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNewNameProject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "newProject";
            this.Text = "Новий проект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogNewProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNewNameProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxNewProjectPath;
        private System.Windows.Forms.Label labelNewProjectPath;
        private System.Windows.Forms.Button buttonNewProjectOk;
        private System.Windows.Forms.Button buttonNewProjectCencel;
    }
}

