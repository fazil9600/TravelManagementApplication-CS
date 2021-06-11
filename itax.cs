using System;
using System.Collections.Generic;
using System.Text;

namespace TravelManagementApplication
{
    class itax
    {
        public double McTax_Rate = 9;

        public Double iFindTax(double icAmount)
        {
            double findtax = icAmount = (icAmount * McTax_Rate)/100;
            return findtax;
        }
    }
}
