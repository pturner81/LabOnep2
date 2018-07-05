using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne2
{
    class Program
    {
        static void Main(string[] args)
        {
            int year1, month1, day1, year2, month2, day2, yearsOld, monthsOld, daysOld;
         

            Console.WriteLine("What year were you born? (enter year as 4 digit number)");
            year1 = Convert.ToInt32(Console.ReadLine());
            while(year1 < 1900 || year1 > 2019)
            { Console.WriteLine("System could not read- Please enter the correct year you were born.");
                year1 = Convert.ToInt32(Console.ReadLine());
            }    // checks to ensure year is accurate and sets year1 variable

            Console.WriteLine("What month were you born? (enter month as number 1-12)");
            month1 = Convert.ToInt32(Console.ReadLine());
            while (month1 < 1 || month1 > 12)
            {
                Console.WriteLine("System could not read- Please enter a number 1-12");
                 month1 = Convert.ToInt32(Console.ReadLine());
            }    // checks to ensure month is legitimate and sets month1 variable

            Console.WriteLine("what day of the month were you born? (enter day as number 1-31)");
            day1 = Convert.ToInt32(Console.ReadLine());
            while (day1 <1 || day1 >31)
            {
                Console.WriteLine("System could not read- Please enter a number 1-31");
                day1 = Convert.ToInt32(Console.ReadLine());
            }    // checks to ensure day is legitimate and sets day1 variable

            Console.WriteLine("What year is it currently? (enter year as 4 digit number)");
            year2 = Convert.ToInt32(Console.ReadLine());
            while (year2 < 2018 || year2 > 2100)
            {
                Console.WriteLine("System could not read- Please enter the correct year");
                year2 = Convert.ToInt32(Console.ReadLine());
            }       // same as above for year2

            Console.WriteLine("What month is it currently? (enter month as number 1-12)");
            month2 = Convert.ToInt32(Console.ReadLine());
            while (month2 <1 || month2 >12)
            {
                Console.WriteLine("System could not read- Please enter a number 1-12");
                month2 = Convert.ToInt32(Console.ReadLine());
            }     // same as above for month2 

            Console.WriteLine("what day of the month is it currently? (enter day as number 1-31)");
            day2 = Convert.ToInt32(Console.ReadLine());
            while (day2 < 1 || day2 > 31)
            {
                Console.WriteLine("System could not read- Please enter a number 1-31");
                day2 = Convert.ToInt32(Console.ReadLine());
            }     // same as above for day2


            if(day2 - day1 >= 0)
            {
                daysOld = day2 - day1;
            }
            else
            {
                daysOld = 31 - (day1 - day2);
            }               // calculates remaining days old
            if (day2 - day1 >= 0)
            {
                if (month2 - month1 >= 0)
                {
                    monthsOld = month2 - month1;
                }
                else
                {
                    monthsOld = 12 - (month1 - month2);
                }
            }
            else
            {
                if (month2 - month1 >= 0)
                {
                    monthsOld = month2 - month1 - 1;
                }
                else
                {
                    monthsOld = 12 - (month1 - month2) - 1;
                }

            }           // calculates remaining months old
            if (month2 - month1 >= 0)
            {
                if (year2 - year1 > 0)
                {
                    yearsOld = year2 - year1;
                }
                else
                {
                    yearsOld = year1 - year2;
                }
            }
            else
            {
                if(year2 - year1 >= 0)
                {
                    yearsOld = year2 - year1 - 1;
                }
                else
                {
                    yearsOld = year1 - year2 -1;
                }
            }           // calculates years old

            /* Console.WriteLine(year1);
              Console.WriteLine(month1);
              Console.WriteLine(day1);
              Console.WriteLine(year2);
              Console.WriteLine(month2);
              Console.WriteLine(day2);
                  // used to check if inputs were recorded correctly
             */
            
                
            Console.WriteLine("Your have " + yearsOld + " years, " + monthsOld + " months and " + daysOld + " days of experience and wisdom.");
                    // writes out the difference between the day born and current day
            Console.ReadKey();
        }
    }
}
