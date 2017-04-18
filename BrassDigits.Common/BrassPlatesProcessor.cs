using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BrassDigits.Common
{
    public class BrassPlatesProcessor
    {

        /*
         This function is basically accepts the number of rooms and returns a 
         dictionary object with each digit from 1 to 9 and number of brass plates required
         for each digit.


        How it works ?
        Input number of rooms : 10

        Logic: build a string with all numbers from 1 to 10- 12345678910
        Check 1 in the whole string, which is 2
        Check 2 , which is 1
        ... and so on.
        
           Linq expressions are used for counting, NUNIT is used to cover the testing for various ranges,
          
             */
        public Dictionary<int,long> ProcessDigits(long NoOfRooms)
        {
            
            StringBuilder strRooms = new StringBuilder();

            var DigitAndNumberOfRequiredPlates = new Dictionary<int, long>();
            try
            { //Build a string with all room numbers runnning from 1 to NoOfRooms
                for (int j = 1; j <= NoOfRooms; j++)
                {
                    strRooms.Append(j);
                }
                //Loop through each digit and find the number of repeats of a digit in 
                //whole string of roomnumbers
                for (int i = 0; i <= 9; i++)
                {
                    DigitAndNumberOfRequiredPlates.Add(i, strRooms.ToString().Count(c => c == i.ToString().ToCharArray()[0]));
                }
            }
            catch (Exception ex)
            {
                return null;
            }

           
            return DigitAndNumberOfRequiredPlates;
        }

          

    }
}
