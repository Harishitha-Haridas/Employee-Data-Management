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
    public partial class Form1 : Form
    {
        private readonly services _employService = new services();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumbit_Click(object sender, EventArgs e)
        {
            //string pass = password.Text;
            //String name_ = username.Text;
            if (password.Text == "1234" && username.Text == "admin")
            {
                //Hide();
                new Adminlogin(this).Show(); 
            }
            else
            {
                int k = _employService.GetByNamePassword(username.Text, password.Text);
                if (k > 0)
                {
                    new EmployeeLogin(k, password.Text).Show();
                }
                else
                    MessageBox.Show("Please Provide Valid Username And Password");
            }
            
        }
    }
}