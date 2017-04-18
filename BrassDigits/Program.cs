using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrassDigits.Common;
 
namespace BrassDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Method2 - Enter number of rooms: ");

            try
            {
                var NoOfRooms = Convert.ToInt64(Console.ReadLine());
                var BrassDigitsObject = new BrassPlatesProcessor();

                var NumberPlatesCount = BrassDigitsObject.ProcessDigits(NoOfRooms);

                foreach (var digit in NumberPlatesCount)
                {
                    Console.WriteLine("{0}:{1}", digit.Key, digit.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception( "Invalid input, please try again.");
            } 
        }
    }
}
