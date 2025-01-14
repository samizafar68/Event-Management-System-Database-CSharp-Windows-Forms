namespace Event_Management_System
{
    partial class Display_ALL_Schedule_Event
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
            this.logout_button = new System.Windows.Forms.Button();
            this.ALL_Detail_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Event_Creation_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ALL_Detail_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logout_button.Location = new System.Drawing.Point(680, 93);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(100, 34);
            this.logout_button.TabIndex = 67;
            this.logout_button.Text = "Back";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // ALL_Detail_dataGridView1
            // 
            this.ALL_Detail_dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ALL_Detail_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ALL_Detail_dataGridView1.GridColor = System.Drawing.Color.White;
            this.ALL_Detail_dataGridView1.Location = new System.Drawing.Point(27, 137);
            this.ALL_Detail_dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.ALL_Detail_dataGridView1.Name = "ALL_Detail_dataGridView1";
            this.ALL_Detail_dataGridView1.RowHeadersWidth = 51;
            this.ALL_Detail_dataGridView1.RowTemplate.Height = 24;
            this.ALL_Detail_dataGridView1.Size = new System.Drawing.Size(753, 296);
            this.ALL_Detail_dataGridView1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 40);
            this.label1.TabIndex = 65;
            this.label1.Text = "Event Management System";
            // 
            // Event_Creation_label
            // 
            this.Event_Creation_label.AutoSize = true;
            this.Event_Creation_label.BackColor = System.Drawing.Color.Transparent;
            this.Event_Creation_label.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Event_Creation_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Event_Creation_label.Location = new System.Drawing.Point(286, 93);
            this.Event_Creation_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Event_Creation_label.Name = "Event_Creation_label";
            this.Event_Creation_label.Size = new System.Drawing.Size(223, 40);
            this.Event_Creation_label.TabIndex = 64;
            this.Event_Creation_label.Text = "Schedule Events";
            // 
            // Display_ALL_Schedule_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.ALL_Detail_dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Event_Creation_label);
            this.Name = "Display_ALL_Schedule_Event";
            this.Text = "Display_ALL_Schedule_Event";
            this.Load += new System.EventHandler(this.Display_ALL_Schedule_Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ALL_Detail_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.DataGridView ALL_Detail_dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Event_Creation_label;
    }
}