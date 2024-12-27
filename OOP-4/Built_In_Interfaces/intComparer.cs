using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Built_In_Interfaces
{
    internal class intComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            int? NumberX = (int?)x;
            int? NumberY = (int?)y;
            return -NumberX.Value.CompareTo(NumberY.Value);
        }
    }
}