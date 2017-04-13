using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Calc_Area
    {   public static double Calculator(string operation, double a, double b)
        {
            double result=0;
            switch (operation)
            {   
                case "+":
                    {
                       return result = a + b;
                        
                    }
                case "-":
                    {
                        return result = a - b;
                        
                    }
                case "*":
                    {
                       return result = a * b;
                       
                    }
                case "/":
                    {
                       return result = a / b;
                        
                    }
                /*default: return System.Console.WriteLine("The operation is unavailable");
                    break; */
                }
            return result;
            
        }

    
        static void Main()
        {
            string operation;
            double result = 0;
            System.Console.WriteLine("Enter the operation, please:");
            operation = Console.ReadLine();
            System.Console.WriteLine("Enter the first number, please:");
            double a = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Enter the second number, please:");
            double b = Convert.ToDouble(System.Console.ReadLine());
            Calc_Area calculations = new Calc_Area();
            result = Calc_Area.Calculator(operation, a, b);
            System.Console.WriteLine("Result : {0}", result);
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
        
}
