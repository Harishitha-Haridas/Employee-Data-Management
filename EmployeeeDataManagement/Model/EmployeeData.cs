using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeeDataManagement.Model
{
    internal class EmployeeData
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int? age { get; set; }
        public string sex { get; set; }
        public string ResidentialLocation { get; set; }
        public string JobTitle { get; set; }
        public string JobLocation { get; set; }

        public string Depatment { get; set; }

        public int MaxSalary { get; set; }

        public int? ApplicableSalary { get; set; }

        public string Password { get; set; }

    }
    internal class JobTitle
    {
        public int ID { get; set; }

        public string JobTitiles { get; set; }

    }

    internal class Leave
    {
        public int slno{ get; set; }

        public int EmpId { get; set; }

        public int LDay { get; set; }
        public int LMonth { get; set; }
        public int LYear { get; set; }

        public string Date { get; set; }

        public string? Lreason { get; set; }
    }


    internal class SalaryTable
    {
        public int slno { get; set; }

        public int EmpId { get; set; }

        
        public int SMonth { get; set; }
        public int SYear { get; set; }

        public int ApplicableSalary { get; set; }
       
    }
}
