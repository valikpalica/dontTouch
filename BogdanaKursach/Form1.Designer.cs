namespace BogdanaKursach
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.firstPunktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondPunktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serdPunktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourthPunktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Kurs,
            this.Group,
            this.Count});
            this.dataGridView1.Location = new System.Drawing.Point(4, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Kurs
            // 
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.MinimumWidth = 6;
            this.Kurs.Name = "Kurs";
            this.Kurs.Width = 125;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.Width = 125;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstPunktToolStripMenuItem,
            this.secondPunktToolStripMenuItem,
            this.serdPunktToolStripMenuItem,
            this.fourthPunktToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // firstPunktToolStripMenuItem
            // 
            this.firstPunktToolStripMenuItem.Name = "firstPunktToolStripMenuItem";
            this.firstPunktToolStripMenuItem.Size = new System.Drawing.Size(507, 26);
            this.firstPunktToolStripMenuItem.Text = "Список груп та кількість курсантів по порядку номерів груп";
            this.firstPunktToolStripMenuItem.Click += new System.EventHandler(this.firstPunktToolStripMenuItem_Click);
            // 
            // secondPunktToolStripMenuItem
            // 
            this.secondPunktToolStripMenuItem.Name = "secondPunktToolStripMenuItem";
            this.secondPunktToolStripMenuItem.Size = new System.Drawing.Size(507, 26);
            this.secondPunktToolStripMenuItem.Text = "Кількість курсантів по курсам";
            this.secondPunktToolStripMenuItem.Click += new System.EventHandler(this.secondPunktToolStripMenuItem_Click);
            // 
            // serdPunktToolStripMenuItem
            // 
            this.serdPunktToolStripMenuItem.Name = "serdPunktToolStripMenuItem";
            this.serdPunktToolStripMenuItem.Size = new System.Drawing.Size(507, 26);
            this.serdPunktToolStripMenuItem.Text = "Загальна кількість груп та курсантів";
            this.serdPunktToolStripMenuItem.Click += new System.EventHandler(this.serdPunktToolStripMenuItem_Click);
            // 
            // fourthPunktToolStripMenuItem
            // 
            this.fourthPunktToolStripMenuItem.Name = "fourthPunktToolStripMenuItem";
            this.fourthPunktToolStripMenuItem.Size = new System.Drawing.Size(507, 26);
            this.fourthPunktToolStripMenuItem.Text = "Кількість груп по курсах";
            this.fourthPunktToolStripMenuItem.Click += new System.EventHandler(this.fourthPunktToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem firstPunktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondPunktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serdPunktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourthPunktToolStripMenuItem;
        public System.Windows.Forms.Label label1;
    }
}

