using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArithmeticСalculator.Moduls;
using ArithmeticСalculator.Services;

namespace ArithmeticСalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // #
            Menu.SetEncoding();

            //1
            bool stop = false;
            do
            {
                
                Menu.InformProgram();

                switch(Menu.ChoiceProgram())
                {
                    case 1:
                        {
                            CalcModul tm = new CalcModul();
                            tm = Input.InputData();
                            tm = CalcManager.calcProgram(tm);
                            DisplayManager.DisplayProgram(tm);


                        }
                        break;
                    case 2:
                        {
                            stop = true;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("There is no such choice");
                        }
                        break;
                }
                if(stop == true)
                {
                    break;
                }
            } while (Menu.AllowProgram());
        }
    }
}
