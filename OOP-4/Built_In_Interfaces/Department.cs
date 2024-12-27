using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Built_In_Interfaces
{
    internal class Department : ICloneable
    {
        public int Code { get; set; }
        public string? Title { get; set; }
        public object Clone()
        {
            return new Department()
            {
                Code = this.Code,
                Title = this.Title
            };
        }
    }
}