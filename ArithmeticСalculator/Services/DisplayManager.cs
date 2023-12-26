using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArithmeticСalculator.Moduls;

namespace ArithmeticСalculator.Services
{
    internal class DisplayManager
    {

        public static void DisplayProgram(CalcModul tm)
        {
            Console.WriteLine( $"\n> First number {tm.A}\n" +
                $"Second number {tm.B} \n" +
                $"Result {tm.result}");
        }
    }
}
