using System;

namespace LeapYear
{
    public class LifetimeOfEarth
    {
        public static void Main() 
        { 
            string stringYear;
            Console.WriteLine("Enter year: ");
            stringYear = Console.ReadLine();
            int year = Convert.ToInt32(stringYear);
            IsLeapYear(year);

            bool IsLeapYear(int year)
            {
                if (year < 1582) {
                    throw new YearTooEarlyException("The given year is too early..");
                }
                
                if((year % 4) == 0 && (year % 100) == 0 && (year % 400 == 0)){
                    Console.WriteLine("yay, this is a leap year!");
                    return true;
                }

                else if ((year % 4) == 0 && (year % 100) != 0){
                    Console.WriteLine("yay, this is a leap year!");
                    return true;
                }

                else{
                    Console.WriteLine("nay, this is not a leap year..");
                    return false;
                }
            }
        }
        
    }
}
