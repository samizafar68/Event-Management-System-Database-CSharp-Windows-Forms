namespace Event_Management_System
{
    partial class Upcomin_Events
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
            this.title_label = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.Upcoming_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Upcoming_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.title_label.Location = new System.Drawing.Point(15, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(359, 40);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Event Management System";
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Back_button.Location = new System.Drawing.Point(695, 74);
            this.Back_button.Margin = new System.Windows.Forms.Padding(4);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(84, 33);
            this.Back_button.TabIndex = 27;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Upcoming_dataGridView1
            // 
            this.Upcoming_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Upcoming_dataGridView1.Location = new System.Drawing.Point(22, 114);
            this.Upcoming_dataGridView1.Name = "Upcoming_dataGridView1";
            this.Upcoming_dataGridView1.RowHeadersWidth = 51;
            this.Upcoming_dataGridView1.RowTemplate.Height = 24;
            this.Upcoming_dataGridView1.Size = new System.Drawing.Size(757, 316);
            this.Upcoming_dataGridView1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(290, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "UpComing Events";
            // 
            // Upcomin_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Upcoming_dataGridView1);
            this.Controls.Add(this.title_label);
            this.Name = "Upcomin_Events";
            this.Text = "Upcomin_Events";
            this.Load += new System.EventHandler(this.Upcomin_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Upcoming_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView Upcoming_dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}