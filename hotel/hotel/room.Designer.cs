namespace hotel
{
    partial class room
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            txt_search = new TextBox();
            btn_delete = new Button();
            btn_add = new Button();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            panel3 = new Panel();
            textBox3 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            txt_id = new TextBox();
            dgv_Phong = new DataGridView();
            cbx_type = new ComboBox();
            txt_max = new TextBox();
            panel4 = new Panel();
            txt_price = new TextBox();
            btn_detail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Phong).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = Properties.Resources.search_1_5;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(943, 340);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(24, 20);
            button1.TabIndex = 57;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.Black;
            txt_search.Cursor = Cursors.IBeam;
            txt_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.ForeColor = Color.White;
            txt_search.Location = new Point(703, 337);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(274, 32);
            txt_search.TabIndex = 56;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Black;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(262, 292);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(102, 41);
            btn_delete.TabIndex = 55;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Black;
            btn_add.Cursor = Cursors.Hand;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.ImageAlign = ContentAlignment.MiddleRight;
            btn_add.Location = new Point(74, 292);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(102, 43);
            btn_add.TabIndex = 53;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(0, 1, 0);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(385, 108);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(109, 22);
            textBox7.TabIndex = 43;
            textBox7.Text = "Price";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(0, 1, 0);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(384, 182);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(109, 22);
            textBox5.TabIndex = 42;
            textBox5.Text = "Max";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(385, 230);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 2);
            panel3.TabIndex = 41;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(0, 1, 0);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(17, 195);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(109, 22);
            textBox3.TabIndex = 40;
            textBox3.Text = "Type";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(18, 244);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 2);
            panel2.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 1, 0);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(16, 108);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(109, 22);
            textBox2.TabIndex = 37;
            textBox2.Text = "ID ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(17, 157);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 2);
            panel1.TabIndex = 36;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(0, 1, 0);
            txt_id.BorderStyle = BorderStyle.None;
            txt_id.Cursor = Cursors.IBeam;
            txt_id.Enabled = false;
            txt_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.ForeColor = Color.White;
            txt_id.Location = new Point(16, 133);
            txt_id.Margin = new Padding(3, 2, 3, 2);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(219, 22);
            txt_id.TabIndex = 35;
            // 
            // dgv_Phong
            // 
            dgv_Phong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Phong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Phong.BackgroundColor = Color.FromArgb(0, 1, 0);
            dgv_Phong.BorderStyle = BorderStyle.Fixed3D;
            dgv_Phong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Phong.GridColor = Color.White;
            dgv_Phong.Location = new Point(16, 383);
            dgv_Phong.Margin = new Padding(3, 2, 3, 2);
            dgv_Phong.Name = "dgv_Phong";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Phong.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Phong.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 1, 0);
            dataGridViewCellStyle2.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dgv_Phong.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Phong.RowTemplate.Height = 29;
            dgv_Phong.Size = new Size(961, 216);
            dgv_Phong.TabIndex = 34;
            dgv_Phong.CellClick += dgv_Phong_CellClick;
            dgv_Phong.CellContentClick += dataGridView1_CellContentClick;
            dgv_Phong.CellEndEdit += dgv_Phong_CellEndEdit;
            // 
            // cbx_type
            // 
            cbx_type.Cursor = Cursors.Hand;
            cbx_type.FormattingEnabled = true;
            cbx_type.Items.AddRange(new object[] { "Single", "Double", "Triple" });
            cbx_type.Location = new Point(18, 219);
            cbx_type.Margin = new Padding(3, 2, 3, 2);
            cbx_type.Name = "cbx_type";
            cbx_type.Size = new Size(217, 23);
            cbx_type.TabIndex = 58;
            cbx_type.Text = "--All--";
            // 
            // txt_max
            // 
            txt_max.BackColor = Color.FromArgb(0, 1, 0);
            txt_max.BorderStyle = BorderStyle.None;
            txt_max.Cursor = Cursors.IBeam;
            txt_max.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_max.ForeColor = Color.White;
            txt_max.Location = new Point(385, 206);
            txt_max.Margin = new Padding(3, 2, 3, 2);
            txt_max.Name = "txt_max";
            txt_max.Size = new Size(219, 22);
            txt_max.TabIndex = 59;
            txt_max.KeyPress += textBox4_KeyPress;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(386, 157);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 2);
            panel4.TabIndex = 61;
            // 
            // txt_price
            // 
            txt_price.BackColor = Color.FromArgb(0, 1, 0);
            txt_price.BorderStyle = BorderStyle.None;
            txt_price.Cursor = Cursors.IBeam;
            txt_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_price.ForeColor = Color.White;
            txt_price.Location = new Point(385, 133);
            txt_price.Margin = new Padding(3, 2, 3, 2);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(219, 22);
            txt_price.TabIndex = 60;
            txt_price.KeyPress += textBox8_KeyPress;
            // 
            // btn_detail
            // 
            btn_detail.BackColor = Color.Black;
            btn_detail.Cursor = Cursors.Hand;
            btn_detail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_detail.ForeColor = Color.White;
            btn_detail.ImageAlign = ContentAlignment.MiddleRight;
            btn_detail.Location = new Point(444, 292);
            btn_detail.Margin = new Padding(3, 2, 3, 2);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(102, 41);
            btn_detail.TabIndex = 62;
            btn_detail.Text = "Detail";
            btn_detail.UseVisualStyleBackColor = false;
            btn_detail.Click += button3_Click;
            // 
            // room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Midnight_Inn__3_;
            Controls.Add(btn_detail);
            Controls.Add(panel4);
            Controls.Add(txt_price);
            Controls.Add(txt_max);
            Controls.Add(cbx_type);
            Controls.Add(button1);
            Controls.Add(txt_search);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(panel3);
            Controls.Add(textBox3);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(txt_id);
            Controls.Add(dgv_Phong);
            Margin = new Padding(3, 2, 3, 2);
            Name = "room";
            Size = new Size(1396, 679);
            Load += room_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Phong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_search;
        private Button btn_delete;
        private Button btn_add;
        private TextBox textBox7;
        private TextBox textBox5;
        private Panel panel3;
        private TextBox textBox3;
        private Panel panel2;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox txt_id;
        private DataGridView dgv_Phong;
        private ComboBox cbx_type;
        private TextBox txt_max;
        private Panel panel4;
        private TextBox txt_price;
        private Button btn_detail;
    }
}
