using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ArithmeticСalculator.Moduls;

namespace ArithmeticСalculator.Services
{
    internal class CalcManager
    {
        public static CalcModul calcProgram(CalcModul tm)
        {
            double result = 0;
            switch (tm.op)
            {
                case "+":
                    {
                        result = tm.A + tm.B;
                        tm.result = result;
                    }
                    break;
                case "-":
                    {
                        result = tm.A - tm.B;
                        tm.result = result;
                    }
                    break;
                case "*":
                    {
                        result = tm.A * tm.B;
                        tm.result = result;
                    }
                    break;
                case "/":
                    {
                        result = tm.A / tm.B;
                        tm.result = result;
                    }
                    break;
                case "%":
                    {
                        result = tm.A % tm.B;
                        tm.result = result;
                    }
                    break;
            }
            return tm;
        }
    }
}
