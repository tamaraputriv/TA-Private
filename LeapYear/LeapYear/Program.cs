using System;

namespace LeapYear
{
    public class LifetimeOfEarth
    {
        public static void Main() { }
        public bool IsLeapYear(int year)
        {
            if (year < 1582) {
                throw new YearTooEarlyException("The given year is too early..");
            }
            
            if((year % 4) == 0 && (year % 100) == 0 && (year % 400 == 0)){
                Console.WriteLine("yay");
                return true;
            }

            else if ((year % 4) == 0 && (year % 100) != 0){
                Console.WriteLine("yay");
                return true;
            }

            else{
                Console.WriteLine("nay");
                return false;
            }
        }
    }
}
