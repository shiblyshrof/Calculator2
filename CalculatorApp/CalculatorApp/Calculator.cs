using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {

        //public double fNumber;
        //public double sNumber;

      //  public double result ;

        public double Add(double fNmuber ,double sNumber)
        {
          return  fNmuber + sNumber;

        }

        public double subtract(double fNumber, double sNumber)
        {
            return  fNumber - sNumber;
        }

        public double  multiply(double fNmuber, double sNumber)
        {
            return  fNmuber * sNumber;
        }

        public double  divide(double fNumber, double sNumber)
        {
            return fNumber/sNumber;
        }
    }
}
