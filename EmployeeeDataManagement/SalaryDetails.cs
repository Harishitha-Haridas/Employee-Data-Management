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
    public partial class SalaryDetails : Form
    {
       
        private readonly services _employService = new services();
        List<int> IDAll = new List<int>();
        public SalaryDetails()
        {
            InitializeComponent();
           
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupcalculate.Visible = false;
            groupview.Visible = true;
        }

        private void calaculateSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupview.Visible = false;
            groupcalculate.Visible = true;
        }

        #region  calculate
        private void Calculate_Click(object sender, EventArgs e)
        {
            int t = 0;
           int month = Convert.ToInt32(comboMonth.Text);
            int year = Convert.ToInt32(comboYear.Text);
            IDAll = _employService.GetAllIDs();
            foreach(var item in IDAll)
            {
                t += _employService.Calsalary(item,month, year);
            }

        }
        #endregion

        private void btnSort_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(sortMonth.Text);
            int year = Convert.ToInt32(sortYear.Text);
            dataGridView1.DataSource = _employService.GridViewSalary(month,year);
        }
    }
}
