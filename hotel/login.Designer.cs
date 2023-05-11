namespace hotel
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(31, 33, 37);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(44, 434);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(433, 36);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(40, 477);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 4);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(36, 571);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 4);
            panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(31, 33, 37);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(40, 526);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(433, 36);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(147, 646);
            button1.Name = "button1";
            button1.Size = new Size(187, 70);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.Midnight_Inn;
            ClientSize = new Size(1640, 918);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Button button1;
    }
}