using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface_Example_02
{
    internal interface SeriesByFour : ISeries
    {
        public int current { get; set; }
        public void GetNext()
        {
            current += 4;
        }

    }
}
