/*
    Author: Leticia W de Sousa
    Date: 1/30/2020
    Comments: This C# Console application code demonstrates the use of
              interation statements after getting input from users. 
*/

using System;

namespace Deliverable2_Interation_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use try catach statement to make sure the user enters a valid input
            try
            {
                //Ask the usser for an output
                Console.Write("Please enter a number between 1 and 100: ");

                //Parse the input
                int number = int.Parse(Console.ReadLine());
                // If statement for input is between 1 and 100
                if ((number > 0) && (number <= 100))
                {
                    //Use a loop to maintaining the start at 1
                    int loopnum = 1;
                    //While loop that will use the input number as a maximum and counting each loop as 1 
                    //until the loop reach the input number 

                    while (loopnum <= number)
                    {
                        //display output
                        Console.WriteLine("You have entered: " + number + " This is the current integer value of the loop: " + loopnum);
                        // decrease
                        loopnum++;

                    }
                }
                else
                {
                    // If user uses a number greater than 100 or less than 1 this message will be shown:
                    Console.WriteLine("**Enter a number between 1 and 100**");
                }

            }
            // catch statement if any errors occurs
            catch (Exception ex)
            {
                // Error message
                Console.WriteLine(ex.Message);



            }
        }
    }
}
