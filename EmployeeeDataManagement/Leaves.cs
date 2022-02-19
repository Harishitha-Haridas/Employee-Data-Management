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
    public partial class Leaves : Form
    {
        private readonly services _employService = new services();
        int ID;
        public Leaves(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            int Date,Month,Year;
            string FullDate, Reason;
            Date = Convert.ToInt32(txtDate.Text);
            Month = Convert.ToInt32(comboMonth.Text);
                Year = Convert.ToInt32(comboYear.Text);

            Reason = RichReason.Text;
                FullDate = $"{ Date}/{Month} /{Year}";

            var lv = new Leave()
            {
                EmpId = ID,
            LDay = Date,
                LMonth = Month,
                LYear = Year,

                Date = FullDate,
                Lreason = Reason


            };
           
            var res = _employService.InserLeave(lv);
            if (res > 0)
                MessageBox.Show("Data added successfully");


        }
    }
}
