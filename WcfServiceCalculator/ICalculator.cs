using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCalculator
{
    
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        Int32 Sum( int num1, int num2);
        [OperationContract]
        Int32 Difference(int num1, int num2);
        [OperationContract]
        Int32 Product(int num1, int num2);
        [OperationContract]
        Int32 Divide(int num1, int num2);
    }
}
