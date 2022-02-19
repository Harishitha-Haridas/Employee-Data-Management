namespace EmployeeeDataManagement
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bChange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcurrent);
            this.groupBox1.Controls.Add(this.txtCon);
            this.groupBox1.Controls.Add(this.txtNew);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // bChange
            // 
            this.bChange.ForeColor = System.Drawing.Color.Black;
            this.bChange.Location = new System.Drawing.Point(273, 199);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(116, 30);
            this.bChange.TabIndex = 8;
            this.bChange.Text = "Change";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Password";
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(212, 38);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.PasswordChar = '*';
            this.txtcurrent.Size = new System.Drawing.Size(177, 29);
            this.txtcurrent.TabIndex = 3;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(212, 148);
            this.txtCon.Name = "txtCon";
            this.txtCon.PasswordChar = '*';
            this.txtCon.Size = new System.Drawing.Size(177, 29);
            this.txtCon.TabIndex = 2;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(212, 93);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(177, 29);
            this.txtNew.TabIndex = 1;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeeDataManagement.Properties.Resources.changepassword1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(568, 316);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtcurrent;
        private TextBox txtCon;
        private TextBox txtNew;
        private Button bChange;
    }
}