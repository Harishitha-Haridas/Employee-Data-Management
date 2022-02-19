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
    public partial class AddJobTitle : Form
    {
        private readonly services _employService = new services();
        public AddJobTitle()
        {
            InitializeComponent();
        }

        private void AddJob_Click(object sender, EventArgs e)
        {
            string s = EnterJob.Text;
            var res = _employService.AddJob(s);
            if (res > 0)
                MessageBox.Show("Job title added successfully");
        }
    }
}
