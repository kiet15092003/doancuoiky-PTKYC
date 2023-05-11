namespace hotel
{
    partial class mana_customer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            textBox6 = new TextBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.BackgroundImage = Properties.Resources.search_1_5;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1588, 205);
            button1.Name = "button1";
            button1.Size = new Size(23, 25);
            button1.TabIndex = 75;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(64, 64, 64);
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(1307, 199);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Search";
            textBox6.Size = new Size(313, 38);
            textBox6.TabIndex = 74;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(1100, 702);
            button4.Name = "button4";
            button4.Size = new Size(117, 55);
            button4.TabIndex = 73;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(98, 98, 98);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(752, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 1, 0);
            dataGridViewCellStyle1.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(868, 433);
            dataGridView1.TabIndex = 63;
            // 
            // mana_customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Midnight_Inn__8_;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "mana_customer";
            Size = new Size(1641, 830);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox6;
        private Button button4;
        private DataGridView dataGridView1;
    }
}
