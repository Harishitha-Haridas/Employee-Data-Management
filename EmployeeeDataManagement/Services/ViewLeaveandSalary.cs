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

namespace EmployeeeDataManagement.Services
{
   
    public partial class ViewLeaveandSalary : Form
    {
        private readonly services _employService = new services();
        
        public ViewLeaveandSalary(int id, String name, String job,int ch)
        {
            InitializeComponent();
            txtID.Text= id.ToString();
            txtName.Text = name;
            txtJob.Text= job;

            if(ch==1)
            {
                groupview.Text = "View Leave Details";
                dataGridView1.DataSource = _employService.GridLeave(id); 
            }
            if (ch == 2)
            {
                groupview.Text = "View Salary Details";
                dataGridView1.DataSource = _employService.GridSalary(id);
            }
        }

        private void ViewLeaveandSalary_Load(object sender, EventArgs e)
        {

        }
    }
}
