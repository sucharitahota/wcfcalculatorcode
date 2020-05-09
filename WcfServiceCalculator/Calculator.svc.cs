using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCalculator
{

    public class Calculator : ICalculator
    {
        public Int32 Sum(int num1, int num2)
        {
            return (num1 + num2);
        }
        public Int32 Difference(int num1, int num2)
        {
            return (num1 - num2);
        }

        public Int32 Product(int num1, int num2)
        {
            return (num1 * num2);
        }

        public Int32 Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
