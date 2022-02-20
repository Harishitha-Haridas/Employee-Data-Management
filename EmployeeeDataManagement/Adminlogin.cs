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

    public partial class Adminlogin : Form
    {
        List<String> jobs=new List<String>();
        int i;
        private readonly services _employService = new services();
        public Adminlogin()
        {
            InitializeComponent();
            jobs = _employService.GetAllJobtitles();
        }


        #region Navigate tool
        private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxSearch.Visible = false;
            groupBoxView.Visible = false;
            groupADD.Visible = false;
            groupBoxEdit.Visible = false;

            groupNavigate.Visible = true;


            dataGridView1.DataSource = _employService.GridViewAll();
        }
        #endregion

        
        #region Add Tool
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            jobs = _employService.GetAllJobtitles();
            this.addjob.Items.Clear();
            foreach (string s2 in jobs)
            {
                this.addjob.Items.AddRange(new object[] {s2
                          });
            }

            groupBoxView.Visible = false;
            groupBoxSearch.Visible = false;
            groupNavigate.Visible = false;
            groupBoxEdit.Visible = false;

            groupADD.Visible = true;
        }
        #endregion

        #region View Tool
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            i = 1;
           
            groupBoxView.Visible = false;
            groupADD.Visible = false;
            groupNavigate.Visible = false;
            groupBoxEdit.Visible = false;

            groupBoxSearch.Visible = true;
        }
        #endregion

        #region Edit  tool
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 2;
            jobs = _employService.GetAllJobtitles();

            groupADD.Visible = false;
            groupBoxView.Visible = false;
            groupNavigate.Visible = false;
            groupBoxEdit.Visible = false;

            groupBoxSearch.Visible = true;
        }
        #endregion


        #region button save in group box
        private void btnsaveData_Click(object sender, EventArgs e)
        {
            try
            {
                var AddEmp = new EmployeeData()
                {
                    Name = txtAddName.Text,
                    Phone = ttxtAddPhone.Text,
                    age = Convert.ToInt32(txtAddAge.Text),
                    Email = txtAddEmail.Text,

                    sex = AddGender.Text,
                    ResidentialLocation = txtAddRLoc.Text,

                    JobTitle = addjob.Text,
                    JobLocation = AddJobLoc.Text,

                    Depatment = Adddepatment.Text,
                    MaxSalary = Convert.ToInt32(TxtAddMax.Text),
                    ApplicableSalary = 0


                };
                if(AddEmp.Name!=""&& AddEmp.Phone != "" && AddEmp.Email != "" &&
                    AddEmp.sex != "" && AddEmp.ResidentialLocation != "" && AddEmp.JobTitle != ""
                    && AddEmp.JobLocation != "" && AddEmp.Depatment != "")
                {
                    var res = _employService.AddOne(AddEmp);
                    if (res > 0)
                        MessageBox.Show("Data added successfully",
                            "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("All data are mandotary please check it and retry",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some errors are inserted data please check it and retry",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        #endregion


        #region button Update in group box
        private void bUpdateEdit_Click(object sender, EventArgs e)
        {

            string title, loc, department;
            int max;
            title = Editjob.Text;
            loc = EditJobLoc.Text;
            department = Editdepatment.Text;
            max = Convert.ToInt32(TxtEditMax.Text);
            int IDno = Convert.ToInt32(ID.Text);
            // string Name = txtName.Text;
            var res = _employService.UpdateJobDetails(IDno, title, loc, department, max);

            if (res > 0)
                MessageBox.Show("Data updated successfully");

        
    }
        #endregion


        #region search in groupbox

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (i == 1)
            {
               
                string Ids = ID.Text;
                int n;
                bool isNumeric = int.TryParse(Ids, out n);
                if (isNumeric)
                {
                    groupBoxEdit.Visible = false;
                    groupBoxView.Visible = true;

                    int IDno = Convert.ToInt32(ID.Text);
                    var employ = _employService.GetByIdOnly(IDno);
                    if (employ != null)
                    {
                        txtViewEmpId.Text = employ.ID.ToString();
                        textViewName.Text = employ.Name;
                        textViewPhone.Text = employ.Phone;
                        textViewAge.Text = employ.age.ToString();
                        textViewEmail.Text = employ.Email;

                        textViewGender.Text = employ.sex;
                        textViewRloc.Text = employ.ResidentialLocation;

                        txtJobView.Text = employ.JobTitle;
                        txtJobLocView.Text = employ.JobLocation;

                        txtDepartmentView.Text = employ.Depatment;
                        textmaxView.Text = employ.MaxSalary.ToString();
                        // textappView.Text = employ.ApplicableSalary.ToString();

                    }
                }
                MessageBox.Show("Please enter a valid id",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               // MessageBox.Show("Please enter a valid id");
               
            }
            if (i == 2)
            {
                string Ids = ID.Text;
                int n;
                bool isNumeric = int.TryParse(Ids, out n);
                if (isNumeric)
             { 
                    groupBoxView.Visible = false;
                groupBoxEdit.Visible = true;

                int IDno = Convert.ToInt32(ID.Text); 

                var employ = _employService.GetByIdOnly(IDno);
                if (employ != null)
                {
                    txtEditEmpId.Text = employ.ID.ToString();
                    textEditName.Text = employ.Name;
                    textEditPhone.Text = employ.Phone;
                    textEditAge.Text = employ.age.ToString();
                    textEditEmail.Text = employ.Email;

                    textEditGender.Text = employ.sex;
                    textEditRloc.Text = employ.ResidentialLocation;

                    this.Editjob.Items.Clear();
                    foreach (string s2 in jobs)
                    {
                        this.Editjob.Items.AddRange(new object[] {s2
                          });
                    }

                    Editjob.Text = employ.JobTitle;
                   
                    
                    EditJobLoc.Text = employ.JobLocation;

                    Editdepatment.Text = employ.Depatment;
                    TxtEditMax.Text = employ.MaxSalary.ToString();
                    //  textapp.Text = employ.ApplicableSalary.ToString();



                }

               }
                else
                MessageBox.Show("Please enter a valid id",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        #endregion

       
        #region delete row
        private void button3_Click(object sender, EventArgs e)
        {
            int IDno = Convert.ToInt32(ID.Text);
            string Name = textEditName.Text;
            var res = _employService.DeleteEmployee(IDno, Name);

            if (res > 0)
               
            MessageBox.Show("Data Deleted successfully",
                           "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

      
        #region combo and Sort
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Text = "-select-";
            string s = comboBox1.Text;
            switch (s)
            {
                case "Job Title":
                    this.comboBox2.Items.Clear();
                    foreach (string s2 in jobs)
                    {
                        this.comboBox2.Items.AddRange(new object[] {s2
                          });
                    }
                    break;

                case "Department":
                    this.comboBox2.Items.Clear();
                    this.comboBox2.Items.AddRange(new object[] {
                "Technical",
                "Support"});
                    break;

                case "Job Location":
                    this.comboBox2.Items.Clear();
                    this.comboBox2.Items.AddRange(new object[] {
                     "kochi",
                  "banglore"});
                    break;
            }

        }
        private void btnSort_Click_1(object sender, EventArgs e)
        {
            string s11, s2;
            s11 = comboBox1.Text;
            s2 = comboBox2.Text;
            if (s11 != "-select-" && s2 != "-select-")
            {
                dataGridView1.DataSource = _employService.SoatByView(s11, s2);
            }
        }

        #endregion

        #region AddJobTool
        private void AddJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddJobTitle().Show();
            jobs = _employService.GetAllJobtitles();
        }
        #endregion

        #region Salary Details
        private void SalaryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SalaryDetails().Show();


        }
        #endregion

        #region Log Out

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sign out successfully",
                          "sign out", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            this.Close();
        }
        #endregion

        #region view salary per employeee
        private void BtnviewSal_Click(object sender, EventArgs e)
        {
            int ch = 2;
            String job = txtJobView.Text;
            String name = textViewName.Text;
            int id = Convert.ToInt32(txtViewEmpId.Text);
            new ViewLeaveandSalary(id, name, job, ch).Show();
        }
        #endregion

        #region view leaveas per employeee
        private void btnViewLeaves_Click(object sender, EventArgs e)
        {
            int ch = 1;
            String job =  txtJobView.Text;
            String name = textViewName.Text;
            int id =Convert.ToInt32(txtViewEmpId.Text);
          new  ViewLeaveandSalary(id, name, job, ch).Show();
        }
        #endregion
    }
}
