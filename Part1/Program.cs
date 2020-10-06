/// Homework No. 6		Exercise Part 1
/// File Name: Count
/// @author: Evan Sinclair
/// Date:  Oct 6, 2020
///
/// Problem Statement: Define a class called Counter whose objects count things.  An object of this class records 
/// a count that is a nonnegative integer.  Include methods to set the counter to 0, to increase the count by 1, and 
/// to decrease the count by 1. Include a getter method that returns the current count value and a method that outputs 
/// the count to the screen.  There should be no input method or other setter methods. Include a ToString methods 
/// and a Equals method. Write a driver program that include a menu to interactively test each method in your program.
/// 
/// Overall Plan:
/// 1)Build Counter class with required methods
/// 2)Write a driver program that tests out the counter by looping through the menu
///
///



using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter();
            int menuControl = 1;

            while (menuControl != 0)
            {
                Console.WriteLine(count.ToString());
                Console.WriteLine("Press 1 to increment, 2 to decrement, 3 to set to 0, 4 to Print the count");
                menuControl = Convert.ToInt32(Console.ReadLine());

                switch (menuControl)
                {
                    case 0:
                        Console.WriteLine("Bye!");
                        break;

                    case 1:
                        count.Increment();
                        break;
                    
                    case 2:
                        count.Decrement();
                        break;
                    
                    case 3:
                        count.SetTo0();
                        break;
                    
                    case 4:
                        count.PrintCount();
                        break;
                    
                    default:
                        break;


                }
            }
        }

        public class Counter
        {
            // Variables
            private int currentCount;

            
            // Constructors
            public Counter()
            {
                currentCount = 0;
            }

            public Counter(int startingCount)
            {
                currentCount = startingCount;
            }

            //Mutators
            
            public void Increment()
            {
                currentCount++;
            }

            public void Decrement()
            {
                if (currentCount > 0)
                {
                    currentCount--;
                }
            }

            public void SetTo0()
            {
                currentCount = 0;
            }

            
            
            //Getter
            public int GetCount()
            {
                return currentCount;
            }

            
            //Other methods
            public void PrintCount()
            {
                Console.WriteLine(currentCount);
            }

            public Boolean Equals(Counter other)
            {
                return this.currentCount == other.currentCount;
            }

            public String ToString()
            {
                return "The current count is: " + currentCount;
            }





        }
    }
}
