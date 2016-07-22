using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnPar_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string again;
            do

            {

                Console.WriteLine("Enter first number: ");
                string number1AsString = Console.ReadLine();
                int number1 = Convert.ToInt32(number1AsString);

                Console.WriteLine("Enter operation: ");
                string calcAsString = Console.ReadLine();
                char calc = Convert.ToChar(calcAsString);

                Console.WriteLine("Enter second number:");
                string number2AsString = Console.ReadLine();
                int number2 = Convert.ToInt32(number2AsString);




                if (calc == '+')

                    Console.WriteLine(number1 + number2);


                else if (calc == '-')

                    Console.WriteLine(+number1 - number2);

                else if (calc == '*')

                    Console.WriteLine(number1 * number2);

                else if (calc == '/')

                    Console.WriteLine(number1 / number2);

                Console.WriteLine("Would you like to perform another calculation, yes or no?");
                again = Console.ReadLine();

            }


            while (again == "YES");

            Console.WriteLine("Goodbye");

            Console.ReadKey();



        }
    }
}
