using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Built_In_Interfaces
{
    internal class EmployeeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee? employeeX = (Employee?)x;
            Employee? employeeY = (Employee?)y;
            return employeeX?.Id.CompareTo(employeeY?.Id) ?? (employeeY is null ? 0 : -1);
        }
    }
}

