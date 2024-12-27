using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_4.Built_In_Interfaces
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }
        public Employee()
        {

        }
        public Employee(Employee employeeCopy)
        {
            this.Id = employeeCopy.Id;
            this.Name = employeeCopy.Name;
            this.Salary = employeeCopy.Salary;
            this.Department = (Department?)employeeCopy?.Department?.Clone();
        }
        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary,
                Department = (Department?)this.Department?.Clone(),
            };
        }
        public override string ToString()
        {
            return $"ID: {Id} , Name: {Name} , Salary: {Salary:c}";
        }

    }
}
