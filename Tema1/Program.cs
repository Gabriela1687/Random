using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            const int max_nr = 100;
            Random random = new Random();
            int numbertoguess = random.Next(max_nr);
            int nr = 0;


            while (nr != numbertoguess)
            {
                
                Console.WriteLine("Enter the number:");
                int.TryParse(Console.ReadLine(), out nr);
                if (nr > numbertoguess)
                {
                    Console.WriteLine("The number is high", nr);

                }
                else if (nr < numbertoguess)
                {
                    Console.WriteLine("The number is low", nr);

                }
                else
                {
                    Console.WriteLine("Congrats!", nr);
                }
            }
        }
    }

    
}

