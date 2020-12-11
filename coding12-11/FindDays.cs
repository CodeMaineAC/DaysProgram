using System;

namespace coding12_11
{
    class FindDays
    {
        //Enemeration setup
        enum DaysOfTheWeek
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }
        static void Main(string[] args)
        {
            DaysOfTheWeek day; //create an instance of our Enumerator 
            int userInput;

            Console.WriteLine("Enter a number to the coresponding day of the week: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            day = (DaysOfTheWeek)userInput; //casting the user input to corresponding Day of the Week

            Console.WriteLine("{0}th day of the week is {1}", userInput, day);
        }
    }
}
