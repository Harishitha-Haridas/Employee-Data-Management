using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeeDataManagement.Model
{




    public partial class Employee : Component
    {
        public Employee()
        {
            InitializeComponent();
        }

        public Employee(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
