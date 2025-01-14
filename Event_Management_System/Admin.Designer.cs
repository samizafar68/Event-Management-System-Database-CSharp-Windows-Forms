namespace Event_Management_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.title_label = new System.Windows.Forms.Label();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.Event_Create_button = new System.Windows.Forms.Button();
            this.Schedule_Event_button = new System.Windows.Forms.Button();
            this.Manage_Speaker_button = new System.Windows.Forms.Button();
            this.Create_Session_button = new System.Windows.Forms.Button();
            this.create_Activity_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.title_label.Location = new System.Drawing.Point(212, 19);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(359, 40);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Event Management System";
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Welcome_label.Location = new System.Drawing.Point(12, 70);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(193, 25);
            this.Welcome_label.TabIndex = 1;
            this.Welcome_label.Text = "Welcome to Admin";
            this.Welcome_label.Click += new System.EventHandler(this.Welcome_label_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logout_button.Location = new System.Drawing.Point(688, 65);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(100, 34);
            this.logout_button.TabIndex = 2;
            this.logout_button.Text = "logout";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Event_Create_button
            // 
            this.Event_Create_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Event_Create_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Create_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Event_Create_button.Location = new System.Drawing.Point(97, 267);
            this.Event_Create_button.Name = "Event_Create_button";
            this.Event_Create_button.Size = new System.Drawing.Size(151, 62);
            this.Event_Create_button.TabIndex = 3;
            this.Event_Create_button.Text = "Create Event";
            this.Event_Create_button.UseVisualStyleBackColor = false;
            this.Event_Create_button.Click += new System.EventHandler(this.Event_Create_button_Click);
            // 
            // Schedule_Event_button
            // 
            this.Schedule_Event_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Schedule_Event_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Schedule_Event_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_Event_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Schedule_Event_button.Location = new System.Drawing.Point(314, 267);
            this.Schedule_Event_button.Name = "Schedule_Event_button";
            this.Schedule_Event_button.Size = new System.Drawing.Size(155, 62);
            this.Schedule_Event_button.TabIndex = 4;
            this.Schedule_Event_button.Text = "Schedule Event";
            this.Schedule_Event_button.UseVisualStyleBackColor = false;
            this.Schedule_Event_button.Click += new System.EventHandler(this.Schedule_Event_button_Click);
            // 
            // Manage_Speaker_button
            // 
            this.Manage_Speaker_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Manage_Speaker_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manage_Speaker_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Speaker_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Manage_Speaker_button.Location = new System.Drawing.Point(219, 357);
            this.Manage_Speaker_button.Name = "Manage_Speaker_button";
            this.Manage_Speaker_button.Size = new System.Drawing.Size(148, 65);
            this.Manage_Speaker_button.TabIndex = 6;
            this.Manage_Speaker_button.Text = "Manage Speaker";
            this.Manage_Speaker_button.UseVisualStyleBackColor = false;
            this.Manage_Speaker_button.Click += new System.EventHandler(this.Manage_Speaker_button_Click);
            // 
            // Create_Session_button
            // 
            this.Create_Session_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Create_Session_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_Session_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Session_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Create_Session_button.Location = new System.Drawing.Point(537, 267);
            this.Create_Session_button.Name = "Create_Session_button";
            this.Create_Session_button.Size = new System.Drawing.Size(158, 62);
            this.Create_Session_button.TabIndex = 7;
            this.Create_Session_button.Text = "Create Session";
            this.Create_Session_button.UseVisualStyleBackColor = false;
            this.Create_Session_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // create_Activity_button
            // 
            this.create_Activity_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.create_Activity_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Activity_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Activity_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.create_Activity_button.Location = new System.Drawing.Point(429, 357);
            this.create_Activity_button.Name = "create_Activity_button";
            this.create_Activity_button.Size = new System.Drawing.Size(143, 65);
            this.create_Activity_button.TabIndex = 8;
            this.create_Activity_button.Text = "Create Activity";
            this.create_Activity_button.UseVisualStyleBackColor = false;
            this.create_Activity_button.Click += new System.EventHandler(this.create_Activity_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(29, 29, 92, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(180, 149);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.create_Activity_button);
            this.Controls.Add(this.Create_Session_button);
            this.Controls.Add(this.Manage_Speaker_button);
            this.Controls.Add(this.Schedule_Event_button);
            this.Controls.Add(this.Event_Create_button);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.title_label);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button Event_Create_button;
        private System.Windows.Forms.Button Schedule_Event_button;
        private System.Windows.Forms.Button Manage_Speaker_button;
        private System.Windows.Forms.Button Create_Session_button;
        private System.Windows.Forms.Button create_Activity_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}