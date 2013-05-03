namespace CP_v1
{
    partial class Geolog
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
            this.components = new System.ComponentModel.Container();
            this.geologGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freezeRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geologReadyButton = new System.Windows.Forms.Button();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.geologGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // geologGridView1
            // 
            this.geologGridView1.AllowUserToAddRows = false;
            this.geologGridView1.AllowUserToResizeColumns = false;
            this.geologGridView1.AllowUserToResizeRows = false;
            this.geologGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.geologGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.geologGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.geologGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.geologGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.geologGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.geologGridView1.Location = new System.Drawing.Point(0, -2);
            this.geologGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.geologGridView1.MinimumSize = new System.Drawing.Size(20, 20);
            this.geologGridView1.Name = "geologGridView1";
            this.geologGridView1.RowHeadersVisible = false;
            this.geologGridView1.Size = new System.Drawing.Size(684, 422);
            this.geologGridView1.TabIndex = 0;
            this.geologGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.geologGridView1_CellMouseClick);
            this.geologGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.geologGridView1_RowsAdded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem,
            this.newRowToolStripMenuItem,
            this.freezeRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 92);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addRowToolStripMenuItem.Text = "Додати рядок";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteRowToolStripMenuItem.Text = "Видалити рядок";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // newRowToolStripMenuItem
            // 
            this.newRowToolStripMenuItem.Name = "newRowToolStripMenuItem";
            this.newRowToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newRowToolStripMenuItem.Text = "Новий рядок";
            this.newRowToolStripMenuItem.Click += new System.EventHandler(this.newRowToolStripMenuItem_Click);
            // 
            // freezeRowToolStripMenuItem
            // 
            this.freezeRowToolStripMenuItem.Name = "freezeRowToolStripMenuItem";
            this.freezeRowToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.freezeRowToolStripMenuItem.Text = "Не несучий шар";
            this.freezeRowToolStripMenuItem.Click += new System.EventHandler(this.freezeRowToolStripMenuItem_Click);
            // 
            // geologReadyButton
            // 
            this.geologReadyButton.Location = new System.Drawing.Point(597, 427);
            this.geologReadyButton.Name = "geologReadyButton";
            this.geologReadyButton.Size = new System.Drawing.Size(75, 23);
            this.geologReadyButton.TabIndex = 1;
            this.geologReadyButton.Text = "Готово";
            this.geologReadyButton.UseVisualStyleBackColor = true;
            this.geologReadyButton.Click += new System.EventHandler(this.geologReadyButton_Click);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "№";
            this.Column0.MinimumWidth = 23;
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column0.Width = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наіменування грунту";
            this.Column1.MinimumWidth = 23;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Показник плинності";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Коефіціент пористості";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 83;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Модуль деформації";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Питома вага";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 68;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Питоме зчеплення";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 85;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Кут внутрішнього тертя";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 110;
            // 
            // Geolog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.geologReadyButton);
            this.Controls.Add(this.geologGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Geolog";
            this.Text = "Інженерно-геологічні вишукування";
            ((System.ComponentModel.ISupportInitialize)(this.geologGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView geologGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRowToolStripMenuItem;
        private System.Windows.Forms.Button geologReadyButton;
        private System.Windows.Forms.ToolStripMenuItem freezeRowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}