namespace Event_Management_System
{
    partial class Display_Schedule_Events
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
            this.label1 = new System.Windows.Forms.Label();
            this.File_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.savbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.File_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(221, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Participant Registered";
            // 
            // File_dataGridView1
            // 
            this.File_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.File_dataGridView1.Location = new System.Drawing.Point(21, 122);
            this.File_dataGridView1.Name = "File_dataGridView1";
            this.File_dataGridView1.RowHeadersWidth = 51;
            this.File_dataGridView1.RowTemplate.Height = 24;
            this.File_dataGridView1.Size = new System.Drawing.Size(757, 263);
            this.File_dataGridView1.TabIndex = 2;
            this.File_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Back_button.Location = new System.Drawing.Point(694, 70);
            this.Back_button.Margin = new System.Windows.Forms.Padding(4);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(84, 33);
            this.Back_button.TabIndex = 24;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = "Event Management System";
            // 
            // savbutton
            // 
            this.savbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.savbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.savbutton.Location = new System.Drawing.Point(591, 404);
            this.savbutton.Margin = new System.Windows.Forms.Padding(4);
            this.savbutton.Name = "savbutton";
            this.savbutton.Size = new System.Drawing.Size(187, 39);
            this.savbutton.TabIndex = 26;
            this.savbutton.Text = "Generate Report";
            this.savbutton.UseVisualStyleBackColor = false;
            this.savbutton.Click += new System.EventHandler(this.savbutton_Click);
            // 
            // Display_Schedule_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.File_dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Display_Schedule_Events";
            this.Text = "Display_Schedule_Events";
            this.Load += new System.EventHandler(this.Display_Schedule_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.File_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView File_dataGridView1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savbutton;
    }
}