namespace Event_Management_System
{
    partial class Display_Registered
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
            this.Event_Creation_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Registerd_Detail_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Registerd_Detail_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Event_Creation_label
            // 
            this.Event_Creation_label.AutoSize = true;
            this.Event_Creation_label.BackColor = System.Drawing.Color.Transparent;
            this.Event_Creation_label.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Event_Creation_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Event_Creation_label.Location = new System.Drawing.Point(279, 84);
            this.Event_Creation_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Event_Creation_label.Name = "Event_Creation_label";
            this.Event_Creation_label.Size = new System.Drawing.Size(249, 40);
            this.Event_Creation_label.TabIndex = 22;
            this.Event_Creation_label.Text = "Registered Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "Event Management System";
            // 
            // Registerd_Detail_dataGridView1
            // 
            this.Registerd_Detail_dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Registerd_Detail_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Registerd_Detail_dataGridView1.GridColor = System.Drawing.Color.White;
            this.Registerd_Detail_dataGridView1.Location = new System.Drawing.Point(20, 128);
            this.Registerd_Detail_dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.Registerd_Detail_dataGridView1.Name = "Registerd_Detail_dataGridView1";
            this.Registerd_Detail_dataGridView1.RowHeadersWidth = 51;
            this.Registerd_Detail_dataGridView1.RowTemplate.Height = 24;
            this.Registerd_Detail_dataGridView1.Size = new System.Drawing.Size(753, 296);
            this.Registerd_Detail_dataGridView1.TabIndex = 62;
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logout_button.Location = new System.Drawing.Point(673, 84);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(100, 34);
            this.logout_button.TabIndex = 63;
            this.logout_button.Text = "Back";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Display_Registered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.Registerd_Detail_dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Event_Creation_label);
            this.Name = "Display_Registered";
            this.Load += new System.EventHandler(this.Display_Registered_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Registerd_Detail_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Event_Creation_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Registerd_Detail_dataGridView1;
        private System.Windows.Forms.Button logout_button;
    }
}