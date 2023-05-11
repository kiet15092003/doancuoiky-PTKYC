namespace hotel
{
    partial class booked
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox12 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(37, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 1, 0);
            dataGridViewCellStyle2.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1013, 370);
            dataGridView1.TabIndex = 65;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = Properties.Resources.search_1_5;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1014, 232);
            button1.Name = "button1";
            button1.Size = new Size(28, 27);
            button1.TabIndex = 89;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.Black;
            textBox12.Cursor = Cursors.IBeam;
            textBox12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.ForeColor = Color.White;
            textBox12.Location = new Point(737, 227);
            textBox12.Name = "textBox12";
            textBox12.PlaceholderText = "Search";
            textBox12.Size = new Size(313, 38);
            textBox12.TabIndex = 88;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(451, 701);
            button3.Name = "button3";
            button3.Size = new Size(187, 63);
            button3.TabIndex = 95;
            button3.Text = "Print";
            button3.UseVisualStyleBackColor = false;
            // 
            // booked
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Midnight_Inn__9_;
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox12);
            Controls.Add(dataGridView1);
            Name = "booked";
            Size = new Size(1639, 842);
            Load += booked_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox12;
        private Button button3;
    }
}
