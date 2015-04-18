using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Marks:");
            int num = Convert.ToInt16(Console.ReadLine());
            if (num <= 100 && num >= 80)
            {
                Console.WriteLine("Your Grade is A+.");
            }
            else if (num < 80 && num >= 70)
            {
                Console.WriteLine("Your Grade is A.");
            }
            else if (num < 70 && num >= 60)
            {
                Console.WriteLine("Your Grade is B.");
            }
            else if (num < 60 && num >= 50)
            {
                Console.WriteLine("Your Grade is C.");
            }
            else if (num < 50 && num >= 40)
            {
                Console.WriteLine("Your Grade is D.");
            }
            else if (num < 40 && num >= 0)
            {
                Console.WriteLine("Sorry You are Failed!!!!");

            }
            else
            {
                Console.WriteLine("Your marks is invalid");
            }
            Console.ReadKey();
        }
            
        }
    }

