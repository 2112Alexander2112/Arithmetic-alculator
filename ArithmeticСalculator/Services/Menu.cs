using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticСalculator.Services
{
    internal class Menu
    {
        public static void SetEncoding()
        {
            Console.OutputEncoding = Encoding.UTF8;
        }

        public static bool AllowProgram()
        {
            Console.WriteLine("Continue with the program? (y/n)");
            string allow = Console.ReadLine();
            return (allow == "y" || allow == "Y");
        }

        public static int ChoiceProgram()
        {
            Console.WriteLine("Make your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public static  void InformProgram()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("Getting started with the program");
            Console.WriteLine("====================================");

            Console.WriteLine("\n> 1. Arithmetic function");
            Console.WriteLine("> 2. Finish Program");
            Console.WriteLine("====================================");
        }
        public static void FinishProgram()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("====================================");
            Console.WriteLine("The program has completed its work");
            Console.WriteLine("====================================");
        }
    }
}
