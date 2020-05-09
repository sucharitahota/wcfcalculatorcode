using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the operation../n 1 for Sum, 2 for Difference, 3 for Product , 4 for Division");
            String operation = Console.ReadLine();

            string[] arr = new string[] { "1", "2", "3", "4" };
            if (!arr.Contains(operation))
                Console.WriteLine("Wrong input!!!!!    Please enter the operation../n 1 for Sum, 2 for Difference, 3 for Product , 4 for Division");
            else
            {
                operation = Console.ReadLine();
                Console.WriteLine("Please enter the first no.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second no.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                String result = DoOperationSericeCall(num1, num2, operation);
                Console.WriteLine("Result is:" + result);

            }
            Console.ReadLine();
        }

        public static string DoOperationSericeCall(int num1, int num2, string operation)
        {
            ServiceReference1.CalculatorClient svcoperations = new ServiceReference1.CalculatorClient();
            string result = string.Empty;
            switch (operation)
            {
                case "1":
                    result = svcoperations.Sum(num1, num2).ToString();
                    break;

                case "2":
                    result = svcoperations.Difference(num1, num2).ToString();
                    break;

                case "3":
                    result = svcoperations.Product(num1, num2).ToString();
                    break;

                case "4":
                    if (num2 == 0)
                        result = "divide by zero is not defined!";
                    else
                        result = svcoperations.Divide(num1, num2).ToString();
                    break;
            }
            return result;
        }
    }
}
