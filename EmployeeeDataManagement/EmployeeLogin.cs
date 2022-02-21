using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeeDataManagement.Data;
using EmployeeeDataManagement.Model;
using System.Data.SqlClient;
using EmployeeeDataManagement.Services;
using System.Data;


namespace EmployeeeDataManagement
{
    public partial class EmployeeLogin : Form
    {
        int ID;
        string Pass;
        private readonly Form1 previousWindow;
        private readonly services _employService = new services();
        //  private EmployeeData Emp=new EmployeeData();

        #region View In Emp
        private void ViewInEmp()
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;


            txtEmpId.ReadOnly = true;
            // textName
            textName.ReadOnly = true;
            textEmail.ReadOnly = true;
            textPhone.ReadOnly = true;
            textRloc.ReadOnly = true;
            comboGender.Enabled= false;
            textAge.ReadOnly = true;

            txtJob.ReadOnly = true;
            txtDepartment.ReadOnly = true;
            txtJobLoc.ReadOnly = true;
            textmax.ReadOnly = true;

           // btnsave.Visible = false;
           bUpdate.Visible = false;
            btnLeveDetails.Visible = true;
            btnSalaryDetails.Visible = true;
            // int IDno = Convert.ToInt32(ID.Text);
            var employ = _employService.GetByIdOnly(ID);
            if (employ != null)
            {
                txtEmpId.Text = employ.ID.ToString();
                textName.Text = employ.Name;
                textPhone.Text = employ.Phone;
                textAge.Text = employ.age.ToString();
                textEmail.Text = employ.Email;

                comboGender.Text = employ.sex;
                textRloc.Text = employ.ResidentialLocation;
                txtJob.Text = employ.JobTitle;
                txtJobLoc.Text = employ.JobLocation;

                txtDepartment.Text = employ.Depatment;
                textmax.Text = employ.MaxSalary.ToString();
              //  textapp.Text = employ.ApplicableSalary.ToString();

            }

        }
        #endregion

        public EmployeeLogin(int i,string s, Form1 pre)
        {
            InitializeComponent();
            ID=i;
            Pass = s;
            ViewInEmp();
            this.previousWindow = pre;
        }

        #region Update
        private void bUpdate_Click(object sender, EventArgs e)
        {
            string Email, Phone, Rloc, Gender;

            Email = textEmail.Text;
            Phone = textPhone.Text;
            Rloc = textRloc.Text;
            Gender = comboGender.Text;
           

            //public int UpdatePersonDetails(int IDno, string Email, string Phone, string Rloc, string Gender)
            // string Name = txtName.Text;
              
            var res = _employService.UpdatePersonDetails(ID, Email , Phone, Rloc, Gender);

            if (res > 0)
               
            MessageBox.Show("Data updated successfully",
                        "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region ViewTool
        private void viewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewInEmp();
        }
        #endregion

        #region Edit
        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


            //textEmail
            //    textPhone
            //    textRloc
            //    textGender

            groupBox2.Visible = true;
            groupBox3.Visible = true;


            txtEmpId.ReadOnly = true;
            textName.ReadOnly = true;

            textEmail.ReadOnly = false;
            textPhone.ReadOnly = false;
            textRloc.ReadOnly = false;
            comboGender.Enabled = true;

            textAge.ReadOnly = true;
            txtJob.ReadOnly = true;
            txtDepartment.ReadOnly = true;
            txtJobLoc.ReadOnly = true;
            textmax.ReadOnly = true;

            bUpdate.Visible = true;
            btnLeveDetails.Visible = false;
            btnSalaryDetails.Visible = false;
            // btnsave.Visible = false;

            //   int IDno = Convert.ToInt32(ID.Text);

            var employ = _employService.GetByIdOnly(ID);
            if (employ != null)
            {
                txtEmpId.Text = employ.ID.ToString();
                textName.Text = employ.Name;
                textPhone.Text = employ.Phone;
                textAge.Text = employ.age.ToString();
                textEmail.Text = employ.Email;

                comboGender.Text = employ.sex;
                textRloc.Text = employ.ResidentialLocation;
                txtJob.Text = employ.JobTitle;
                txtJobLoc.Text = employ.JobLocation;

                txtDepartment.Text = employ.Depatment;
                textmax.Text = employ.MaxSalary.ToString();
              //  textapp.Text = employ.ApplicableSalary.ToString();



            }
        }
        #endregion

        #region Leave Application
        private void leaveApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Leaves(ID).ShowDialog();
        }
        #endregion

        #region Change Password
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 new ChangePassword(ID, Pass, this).ShowDialog();
        }
        #endregion

        #region Logout

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("sign out successfully",
                         "sign out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            previousWindow.Show();

            Close();
           // this.Close();
        }
        #endregion


        #region salarydetails 
        private void btnSalaryDetails_Click(object sender, EventArgs e)
        {
            int ch = 2;
            String job = txtJob.Text;
            String name = textName.Text;
            int id = Convert.ToInt32(txtEmpId.Text);
            new ViewLeaveandSalary(id, name, job, ch).ShowDialog();

        }
        #endregion

        #region leave details 
        private void btnLeveDetails_Click(object sender, EventArgs e)
        {
            int ch = 1;
            String job = txtJob.Text;
            String name = textName.Text;
            int id = Convert.ToInt32(txtEmpId.Text);
            new ViewLeaveandSalary(id, name, job, ch).ShowDialog();
        }
        #endregion

        private void EmployeeLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previousWindow.Show();
        }
    }
}
