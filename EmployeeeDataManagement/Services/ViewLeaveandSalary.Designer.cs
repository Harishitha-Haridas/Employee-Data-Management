namespace EmployeeeDataManagement.Services
{
    partial class ViewLeaveandSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLeaveandSalary));
            this.groupview = new System.Windows.Forms.GroupBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupview
            // 
            this.groupview.BackColor = System.Drawing.Color.Transparent;
            this.groupview.Controls.Add(this.txtJob);
            this.groupview.Controls.Add(this.label2);
            this.groupview.Controls.Add(this.txtID);
            this.groupview.Controls.Add(this.txtName);
            this.groupview.Controls.Add(this.label1);
            this.groupview.Controls.Add(this.label4);
            this.groupview.Controls.Add(this.dataGridView1);
            this.groupview.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupview.ForeColor = System.Drawing.Color.Navy;
            this.groupview.Location = new System.Drawing.Point(12, 12);
            this.groupview.Name = "groupview";
            this.groupview.Size = new System.Drawing.Size(776, 416);
            this.groupview.TabIndex = 9;
            this.groupview.TabStop = false;
            this.groupview.Text = "View Salary Details";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(605, 33);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(142, 32);
            this.txtJob.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(523, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Job Title";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(234, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(71, 32);
            this.txtID.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(375, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 32);
            this.txtName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(312, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(120, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Employee ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(736, 301);
            this.dataGridView1.TabIndex = 10;
            // 
            // ViewLeaveandSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewLeaveandSalary";
            this.Text = "View Leave and Salary";
            this.groupview.ResumeLayout(false);
            this.groupview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupview;
        private TextBox txtJob;
        private Label label2;
        private TextBox txtID;
        private TextBox txtName;
        private Label label1;
        private Label label4;
        private DataGridView dataGridView1;
    }
}