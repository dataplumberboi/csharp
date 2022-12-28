using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number you entered is "+number1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            finally
            {
                Console.WriteLine("This sentence is always written.");
            }

            try
            {
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("2334543050434379");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You did not entered any value.");
                Console.WriteLine(ex);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("You entered the value in wrong format.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("You either exceeded max value or entered very small value.");
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}