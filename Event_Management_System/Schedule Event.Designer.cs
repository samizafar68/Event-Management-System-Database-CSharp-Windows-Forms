namespace Event_Management_System
{
    partial class Schedule_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_Event));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.create_Activity_button = new System.Windows.Forms.Button();
            this.Display_Session_button = new System.Windows.Forms.Button();
            this.Display_Speaker_button = new System.Windows.Forms.Button();
            this.Display_Registered_Event_button = new System.Windows.Forms.Button();
            this.Event_Create_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.Welcome_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(276, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sechedule Event";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(29, 29, 92, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(191, 165);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // create_Activity_button
            // 
            this.create_Activity_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.create_Activity_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Activity_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Activity_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.create_Activity_button.Location = new System.Drawing.Point(435, 344);
            this.create_Activity_button.Name = "create_Activity_button";
            this.create_Activity_button.Size = new System.Drawing.Size(205, 65);
            this.create_Activity_button.TabIndex = 16;
            this.create_Activity_button.Text = "Display Activity";
            this.create_Activity_button.UseVisualStyleBackColor = false;
            this.create_Activity_button.Click += new System.EventHandler(this.create_Activity_button_Click);
            // 
            // Display_Session_button
            // 
            this.Display_Session_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Display_Session_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Display_Session_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_Session_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Display_Session_button.Location = new System.Drawing.Point(547, 249);
            this.Display_Session_button.Name = "Display_Session_button";
            this.Display_Session_button.Size = new System.Drawing.Size(208, 62);
            this.Display_Session_button.TabIndex = 15;
            this.Display_Session_button.Text = "Display Session";
            this.Display_Session_button.UseVisualStyleBackColor = false;
            this.Display_Session_button.Click += new System.EventHandler(this.Display_Session_button_Click);
            // 
            // Display_Speaker_button
            // 
            this.Display_Speaker_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Display_Speaker_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Display_Speaker_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_Speaker_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Display_Speaker_button.Location = new System.Drawing.Point(179, 344);
            this.Display_Speaker_button.Name = "Display_Speaker_button";
            this.Display_Speaker_button.Size = new System.Drawing.Size(209, 65);
            this.Display_Speaker_button.TabIndex = 14;
            this.Display_Speaker_button.Text = "Display Speaker";
            this.Display_Speaker_button.UseVisualStyleBackColor = false;
            this.Display_Speaker_button.Click += new System.EventHandler(this.Display_Speaker_button_Click);
            // 
            // Display_Registered_Event_button
            // 
            this.Display_Registered_Event_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Display_Registered_Event_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Display_Registered_Event_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_Registered_Event_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Display_Registered_Event_button.Location = new System.Drawing.Point(314, 249);
            this.Display_Registered_Event_button.Name = "Display_Registered_Event_button";
            this.Display_Registered_Event_button.Size = new System.Drawing.Size(205, 62);
            this.Display_Registered_Event_button.TabIndex = 13;
            this.Display_Registered_Event_button.Text = "Display Registered Participant";
            this.Display_Registered_Event_button.UseVisualStyleBackColor = false;
            this.Display_Registered_Event_button.Click += new System.EventHandler(this.Schedule_Event_button_Click);
            // 
            // Event_Create_button
            // 
            this.Event_Create_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Event_Create_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Create_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Event_Create_button.Location = new System.Drawing.Point(73, 249);
            this.Event_Create_button.Name = "Event_Create_button";
            this.Event_Create_button.Size = new System.Drawing.Size(209, 62);
            this.Event_Create_button.TabIndex = 12;
            this.Event_Create_button.Text = "Display Schedule Events";
            this.Event_Create_button.UseVisualStyleBackColor = false;
            this.Event_Create_button.Click += new System.EventHandler(this.Event_Create_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logout_button.Location = new System.Drawing.Point(688, 47);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(100, 34);
            this.logout_button.TabIndex = 11;
            this.logout_button.Text = "Back";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Welcome_label.Location = new System.Drawing.Point(12, 52);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(193, 25);
            this.Welcome_label.TabIndex = 10;
            this.Welcome_label.Text = "Welcome to Admin";
            // 
            // Schedule_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.create_Activity_button);
            this.Controls.Add(this.Display_Session_button);
            this.Controls.Add(this.Display_Speaker_button);
            this.Controls.Add(this.Display_Registered_Event_button);
            this.Controls.Add(this.Event_Create_button);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.label1);
            this.Name = "Schedule_Event";
            this.Text = "Schedule_Event";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button create_Activity_button;
        private System.Windows.Forms.Button Display_Session_button;
        private System.Windows.Forms.Button Display_Speaker_button;
        private System.Windows.Forms.Button Display_Registered_Event_button;
        private System.Windows.Forms.Button Event_Create_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label Welcome_label;
    }
}