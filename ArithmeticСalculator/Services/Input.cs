using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ArithmeticСalculator.Moduls;

namespace ArithmeticСalculator.Services
{
    internal class Input
    {
        public static CalcModul InputData()
        {
            var tm = new CalcModul();
            try
            {
                Console.WriteLine("Enter first number");
                tm.A = Convert.ToDouble(Console.ReadLine());
                if (tm.A < 0)
                    throw new Exception("The first side is negative");

                Console.WriteLine("Enter second number");
                tm.B = Convert.ToDouble(Console.ReadLine());
                if (tm.B < 0)
                    throw new Exception("The second side is negative");
                else if (tm.B < tm.A)
                    throw new Exception("The second number cannot be greater than the first");

                Console.WriteLine("Select operator: (+, -, *, /, %)");
                tm.op = Console.ReadLine();

                tm.IsDefault = false;
            }
            catch (Exception ex)
            {
                tm.IsDefault = true;
                Console.WriteLine($"\n> Exception: \n {ex.Message}");
            }
            return tm;
        }
    }
}
