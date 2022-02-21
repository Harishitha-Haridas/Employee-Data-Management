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
        { string FullDate = dateTimePick.Text;
            int Year = dateTimePick.Value.Year;
            int Month = dateTimePick.Value.Month;
            int Day = dateTimePick.Value.Day;

            string  Reason;
         
            Reason = RichReason.Text;
             if(Reason=="")
                MessageBox.Show("Please Enter a Reason",
                                         "Reason Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var lv = new Leave()
                {
                    EmpId = ID,
                    LDay = Day,
                    LMonth = Month,
                    LYear = Year,

                    Date = FullDate,
                    Lreason = Reason


                };

                var res = _employService.InserLeave(lv);
                if (res > 0)
                   
                    MessageBox.Show("Leave Aprooved",
                                              "Leave Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           


        }
    }
}
