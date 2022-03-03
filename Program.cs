using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentyear = 2022;

            Console.Write("What’s your name?");
            string input = Console.ReadLine();

            Console.WriteLine($"your name is : {input}");
            Console.Write("What’s your age?");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine($"your born at : {currentyear - age}");
            double days = ((age) * 365);
            Console.WriteLine($"your days old : {days}");
            double hour = (((age * 365) * 60));
            Console.WriteLine($"your hours old : {hour}");
          { 
                if (age > 40)
                Console.WriteLine("you are Old");
                else
                Console.WriteLine("you are chaild");
                Console.ReadLine();
            }

            /*calculator */
            Console.Write("Enter First number");
            double firstnumber = double.Parse(Console.ReadLine());

            Console.Write("Enter Second number");
            double secondnumber = double.Parse(Console.ReadLine());

            Console.Write("Enter oporator");
            string oporator = Console.ReadLine();
            double results = double.NaN;
            bool ok = true;
            switch (oporator) {
                case "-":
                    results = firstnumber - secondnumber;
                    ok = true;
                    break;
                case "+":
                    results = firstnumber + secondnumber;
                    ok = true;
                    break;
                case "*":
                    results = firstnumber * secondnumber;
                    ok = true;
                    break;
                case "/":
                    if (secondnumber == 0)
                    {
                        Console.Write("cannot be 0");
                        ok = false;
                    }
                    else
                         results = firstnumber / secondnumber;
                break;
                default:
                    Console.WriteLine("unknown operator");
                    ok = false;
                    break; 
                        }
            if (ok)
            Console.WriteLine($"{firstnumber} {oporator} {secondnumber} = {results}");

            Console.ReadLine();
        }
    }
}
