namespace EmployeeeDataManagement
{
    partial class SalaryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryDetails));
            this.groupcalculate = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupview = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sortMonth = new System.Windows.Forms.ComboBox();
            this.sortYear = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calaculateSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupcalculate.SuspendLayout();
            this.groupview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupcalculate
            // 
            this.groupcalculate.Controls.Add(this.label5);
            this.groupcalculate.Controls.Add(this.label2);
            this.groupcalculate.Controls.Add(this.Calculate);
            this.groupcalculate.Controls.Add(this.comboMonth);
            this.groupcalculate.Controls.Add(this.comboYear);
            this.groupcalculate.Controls.Add(this.label3);
            this.groupcalculate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupcalculate.ForeColor = System.Drawing.Color.Navy;
            this.groupcalculate.Location = new System.Drawing.Point(12, 32);
            this.groupcalculate.Name = "groupcalculate";
            this.groupcalculate.Size = new System.Drawing.Size(331, 139);
            this.groupcalculate.TabIndex = 0;
            this.groupcalculate.TabStop = false;
            this.groupcalculate.Text = "Calculate Salary";
            this.groupcalculate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(146, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Month";
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calculate.ForeColor = System.Drawing.Color.Navy;
            this.Calculate.Location = new System.Drawing.Point(160, 73);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(144, 50);
            this.Calculate.TabIndex = 15;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboMonth.Location = new System.Drawing.Point(73, 34);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(67, 33);
            this.comboMonth.TabIndex = 19;
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.comboYear.Location = new System.Drawing.Point(195, 34);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(64, 33);
            this.comboYear.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 13;
            // 
            // groupview
            // 
            this.groupview.BackColor = System.Drawing.Color.Transparent;
            this.groupview.Controls.Add(this.label1);
            this.groupview.Controls.Add(this.label4);
            this.groupview.Controls.Add(this.sortMonth);
            this.groupview.Controls.Add(this.sortYear);
            this.groupview.Controls.Add(this.dataGridView1);
            this.groupview.Controls.Add(this.btnSort);
            this.groupview.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupview.ForeColor = System.Drawing.Color.Navy;
            this.groupview.Location = new System.Drawing.Point(12, 63);
            this.groupview.Name = "groupview";
            this.groupview.Size = new System.Drawing.Size(776, 387);
            this.groupview.TabIndex = 8;
            this.groupview.TabStop = false;
            this.groupview.Text = "View Salary Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(283, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(143, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Month";
            // 
            // sortMonth
            // 
            this.sortMonth.FormattingEnabled = true;
            this.sortMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.sortMonth.Location = new System.Drawing.Point(210, 28);
            this.sortMonth.Name = "sortMonth";
            this.sortMonth.Size = new System.Drawing.Size(67, 33);
            this.sortMonth.TabIndex = 23;
            // 
            // sortYear
            // 
            this.sortYear.FormattingEnabled = true;
            this.sortYear.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.sortYear.Location = new System.Drawing.Point(332, 28);
            this.sortYear.Name = "sortYear";
            this.sortYear.Size = new System.Drawing.Size(64, 33);
            this.sortYear.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(736, 301);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(417, 28);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 31);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.calaculateSalaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // calaculateSalaryToolStripMenuItem
            // 
            this.calaculateSalaryToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.calaculateSalaryToolStripMenuItem.Name = "calaculateSalaryToolStripMenuItem";
            this.calaculateSalaryToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.calaculateSalaryToolStripMenuItem.Text = "&Calculate Salary";
            this.calaculateSalaryToolStripMenuItem.Click += new System.EventHandler(this.calaculateSalaryToolStripMenuItem_Click);
            // 
            // SalaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.groupcalculate);
            this.Controls.Add(this.groupview);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SalaryDetails";
            this.Text = "Salary Details";
            this.groupcalculate.ResumeLayout(false);
            this.groupcalculate.PerformLayout();
            this.groupview.ResumeLayout(false);
            this.groupview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupcalculate;
        private Button Calculate;
        private Label label5;
        private Label label2;
        private ComboBox comboMonth;
        private ComboBox comboYear;
        private Label label3;
        private GroupBox groupview;
        private DataGridView dataGridView1;
        private Button btnSort;
        private Label label1;
        private Label label4;
        private ComboBox sortMonth;
        private ComboBox sortYear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem calaculateSalaryToolStripMenuItem;
    }
}