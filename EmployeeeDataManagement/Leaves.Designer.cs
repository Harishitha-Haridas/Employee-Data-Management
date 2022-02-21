namespace EmployeeeDataManagement
{
    partial class Leaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaves));
            this.label3 = new System.Windows.Forms.Label();
            this.RichReason = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePick = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(297, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apply for Leave";
            // 
            // RichReason
            // 
            this.RichReason.Location = new System.Drawing.Point(337, 97);
            this.RichReason.Name = "RichReason";
            this.RichReason.Size = new System.Drawing.Size(187, 56);
            this.RichReason.TabIndex = 5;
            this.RichReason.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(337, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(266, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(285, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            // 
            // dateTimePick
            // 
            this.dateTimePick.Location = new System.Drawing.Point(337, 56);
            this.dateTimePick.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePick.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePick.Name = "dateTimePick";
            this.dateTimePick.Size = new System.Drawing.Size(179, 23);
            this.dateTimePick.TabIndex = 15;
            // 
            // Leaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeeDataManagement.Properties.Resources.LEAVE2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 252);
            this.Controls.Add(this.dateTimePick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RichReason);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Leaves";
            this.Text = "Leaves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private RichTextBox RichReason;
        private Button button1;
        private Label label1;
        private Label label4;
        private DateTimePicker dateTimePick;
    }
}