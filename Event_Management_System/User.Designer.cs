namespace Event_Management_System
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.create_Activity_button = new System.Windows.Forms.Button();
            this.Create_Session_button = new System.Windows.Forms.Button();
            this.User_Notification_button = new System.Windows.Forms.Button();
            this.Schedule_Event_button = new System.Windows.Forms.Button();
            this.Event_Create_button = new System.Windows.Forms.Button();
            this.user_logout_button = new System.Windows.Forms.Button();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(59, 29, 92, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(171, 156);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // create_Activity_button
            // 
            this.create_Activity_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.create_Activity_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Activity_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Activity_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.create_Activity_button.Location = new System.Drawing.Point(429, 362);
            this.create_Activity_button.Name = "create_Activity_button";
            this.create_Activity_button.Size = new System.Drawing.Size(166, 65);
            this.create_Activity_button.TabIndex = 17;
            this.create_Activity_button.Text = "Event Attendence";
            this.create_Activity_button.UseVisualStyleBackColor = false;
            this.create_Activity_button.Click += new System.EventHandler(this.create_Activity_button_Click);
            // 
            // Create_Session_button
            // 
            this.Create_Session_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Create_Session_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_Session_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Session_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Create_Session_button.Location = new System.Drawing.Point(537, 272);
            this.Create_Session_button.Name = "Create_Session_button";
            this.Create_Session_button.Size = new System.Drawing.Size(171, 62);
            this.Create_Session_button.TabIndex = 16;
            this.Create_Session_button.Text = "Registered Events";
            this.Create_Session_button.UseVisualStyleBackColor = false;
            this.Create_Session_button.Click += new System.EventHandler(this.Create_Session_button_Click);
            // 
            // User_Notification_button
            // 
            this.User_Notification_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.User_Notification_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_Notification_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Notification_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.User_Notification_button.Location = new System.Drawing.Point(193, 362);
            this.User_Notification_button.Name = "User_Notification_button";
            this.User_Notification_button.Size = new System.Drawing.Size(174, 65);
            this.User_Notification_button.TabIndex = 15;
            this.User_Notification_button.Text = "Notification";
            this.User_Notification_button.UseVisualStyleBackColor = false;
            this.User_Notification_button.Click += new System.EventHandler(this.User_Notification_button_Click);
            // 
            // Schedule_Event_button
            // 
            this.Schedule_Event_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Schedule_Event_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Schedule_Event_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_Event_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Schedule_Event_button.Location = new System.Drawing.Point(314, 272);
            this.Schedule_Event_button.Name = "Schedule_Event_button";
            this.Schedule_Event_button.Size = new System.Drawing.Size(171, 62);
            this.Schedule_Event_button.TabIndex = 14;
            this.Schedule_Event_button.Text = "Upcoming Event";
            this.Schedule_Event_button.UseVisualStyleBackColor = false;
            this.Schedule_Event_button.Click += new System.EventHandler(this.Schedule_Event_button_Click);
            // 
            // Event_Create_button
            // 
            this.Event_Create_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Event_Create_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Create_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Event_Create_button.Location = new System.Drawing.Point(97, 272);
            this.Event_Create_button.Name = "Event_Create_button";
            this.Event_Create_button.Size = new System.Drawing.Size(164, 62);
            this.Event_Create_button.TabIndex = 13;
            this.Event_Create_button.Text = "Registration";
            this.Event_Create_button.UseVisualStyleBackColor = false;
            this.Event_Create_button.Click += new System.EventHandler(this.Event_Create_button_Click);
            // 
            // user_logout_button
            // 
            this.user_logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.user_logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.user_logout_button.Location = new System.Drawing.Point(688, 70);
            this.user_logout_button.Name = "user_logout_button";
            this.user_logout_button.Size = new System.Drawing.Size(100, 34);
            this.user_logout_button.TabIndex = 12;
            this.user_logout_button.Text = "logout";
            this.user_logout_button.UseVisualStyleBackColor = false;
            this.user_logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Welcome_label.Location = new System.Drawing.Point(12, 75);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(234, 25);
            this.Welcome_label.TabIndex = 11;
            this.Welcome_label.Text = "Welcome to Participant";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.title_label.Location = new System.Drawing.Point(212, 24);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(359, 40);
            this.title_label.TabIndex = 10;
            this.title_label.Text = "Event Management System";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.create_Activity_button);
            this.Controls.Add(this.Create_Session_button);
            this.Controls.Add(this.User_Notification_button);
            this.Controls.Add(this.Schedule_Event_button);
            this.Controls.Add(this.Event_Create_button);
            this.Controls.Add(this.user_logout_button);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.title_label);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button create_Activity_button;
        private System.Windows.Forms.Button Create_Session_button;
        private System.Windows.Forms.Button User_Notification_button;
        private System.Windows.Forms.Button Schedule_Event_button;
        private System.Windows.Forms.Button Event_Create_button;
        private System.Windows.Forms.Button user_logout_button;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Label title_label;
    }
}