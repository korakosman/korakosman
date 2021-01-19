using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            string year, month, day = string.Empty;
            Console.WriteLine("Enter your Birthdate:");
            Console.WriteLine("Year :");
            year = Console.ReadLine();
            Console.WriteLine("Month :");
            month = Console.ReadLine();
            Console.WriteLine("Day :");
            day = Console.ReadLine();
            try
            {
                DateTime date = Convert.ToDateTime(year + "-" + month + "-" + day);
                var bday = float.Parse(date.ToString("yyyy.MMdd"));
                var now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
                if (now < bday)
                {
                    Console.WriteLine("Invalid Input of date");
                    Console.ReadLine();

                }
                Console.WriteLine("Your Age is " + (String.Format("{0:00}", (now - bday)))); 
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }

        }
    }
}
    

