namespace Event_Management_System
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.show_checkBox = new System.Windows.Forms.CheckBox();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 550);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Admin";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.title_label.Location = new System.Drawing.Point(20, 257);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(259, 27);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Event Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.login_label.Location = new System.Drawing.Point(448, 113);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(150, 23);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Login Account";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.username_label.Location = new System.Drawing.Point(370, 199);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(94, 22);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Username:";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password_label.Location = new System.Drawing.Point(370, 280);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(87, 21);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password:";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.login_button.Location = new System.Drawing.Point(370, 400);
            this.login_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(104, 44);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // show_checkBox
            // 
            this.show_checkBox.AutoSize = true;
            this.show_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.show_checkBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.show_checkBox.Location = new System.Drawing.Point(545, 340);
            this.show_checkBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.show_checkBox.Name = "show_checkBox";
            this.show_checkBox.Size = new System.Drawing.Size(148, 25);
            this.show_checkBox.TabIndex = 8;
            this.show_checkBox.Text = "Show Password";
            this.show_checkBox.UseVisualStyleBackColor = false;
            this.show_checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // user_textBox
            // 
            this.user_textBox.Location = new System.Drawing.Point(370, 224);
            this.user_textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(323, 29);
            this.user_textBox.TabIndex = 9;
            this.user_textBox.TextChanged += new System.EventHandler(this.user_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(370, 305);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(323, 29);
            this.password_textBox.TabIndex = 10;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(719, 550);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.show_checkBox);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckBox show_checkBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.TextBox password_textBox;
    }
}