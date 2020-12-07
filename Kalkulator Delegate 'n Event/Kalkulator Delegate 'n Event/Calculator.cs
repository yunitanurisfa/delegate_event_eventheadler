using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Delegate__n_Event
{
    class Calculator
    {
       
        public double Penambahan(double a, double b)
        {
            return a + b;
        }

        public double Pengurangan(double a, double b)
        {
            return a - b;
        }

        public double Perkalian(double a, double b)
        {
            return a * b;
        }

        public double Pembagian(double a, double b)
        {
            return a / b;
        }
    }
}
