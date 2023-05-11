namespace hotel
{
    partial class addservice
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            textBox13 = new TextBox();
            panel4 = new Panel();
            textBox14 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 28);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(38, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 1, 0);
            dataGridViewCellStyle3.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGray;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(478, 346);
            dataGridView1.TabIndex = 65;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.Black;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.ForeColor = Color.White;
            textBox13.Location = new Point(547, 142);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(189, 27);
            textBox13.TabIndex = 68;
            textBox13.Text = "Quantity";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(548, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 3);
            panel4.TabIndex = 67;
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.Black;
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Cursor = Cursors.IBeam;
            textBox14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.ForeColor = Color.White;
            textBox14.Location = new Point(547, 175);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(250, 27);
            textBox14.TabIndex = 66;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(547, 271);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 71;
            textBox1.Text = "Time";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(548, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 3);
            panel1.TabIndex = 70;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(547, 304);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 69;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(568, 442);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 95;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(690, 442);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 96;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addservice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(848, 692);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox13);
            Controls.Add(panel4);
            Controls.Add(textBox14);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Name = "addservice";
            Text = "addservice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private TextBox textBox13;
        private Panel panel4;
        private TextBox textBox14;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private Button button3;
        private Button button1;
    }
}