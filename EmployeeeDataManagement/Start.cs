using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeeDataManagement
{
    public partial class Start : Form
    {
        System.Windows.Forms.Timer t;
        public Start()
        {
            InitializeComponent();
            t = new System.Windows.Forms.Timer();
            t.Interval = 3000;
            t.Start();
            t.Tick += T_Tick;
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            new Form1().Show();
            t.Stop();
        }
    }
}
