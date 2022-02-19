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
    public partial class ChangePassword : Form
    {
        private readonly services _employService = new services();
        int ID;
        String Pass;
        private readonly EmployeeLogin previousWindow;

        public ChangePassword(int i,String s, EmployeeLogin previousWindow)
        {
            InitializeComponent();
            ID= i;
            Pass = s;
            this.previousWindow = previousWindow;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void bChange_Click(object sender, EventArgs e)
        {
           

            string password;
           // int Emd = Convert.ToInt32(txtEmp.Text);
            String current = txtcurrent.Text;
            if ( current == Pass)
            { 
                if(txtNew.Text== txtCon.Text)
                {
                    password = txtNew.Text;
                    var res1 = MessageBox.Show("Do you want to change the password?", "Change Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (res1 != DialogResult.OK)
                    { this.Close();
                        return;
                    }
                
                var res = _employService.UpdatePassword(ID, password);
                    if (res > 0)
                    {
                        MessageBox.Show("Password changed successfully;\nPlease Login once again by new password ", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        previousWindow.Close();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("New passwod and Conform password must be same");
            }
            else
                MessageBox.Show("Invalid ID or Password");
        }
    }
}
