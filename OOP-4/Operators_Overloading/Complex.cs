using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Operators_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        #region Opeartor Overloading
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = Left.Real + Right.Real,
                Imag = Left.Imag + Right.Imag
            };
        }
        #endregion
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}