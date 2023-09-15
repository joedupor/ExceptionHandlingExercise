using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // done - First create a character array, char[], it must contain 6 numbers and 3 letters - name it arr
            // done - Create a list called numbers that will hold integers
            // done - Create a string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            
            char[] arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            //note: can also be written as ->  char[] arr = { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            List<int> numbers = new List<int>();
            string str ="";
            //string str;   note: can also just declare str without initializing it and it will store null  OR can type string str = string.Empty;

            // done - Make a foreach loop to iterate through your character array

            foreach (char character in arr)
            {
                // done - Now create a try catch

                try
                {
                    str = character.ToString();    //we need to do this line b/c parse is not set up with overloads to convert a char to an int so we need to convert our char to a string first
                    int integer = int.Parse(str);  //we do this to make the string variable into an integer
                    numbers.Add(integer);
                } 
                
                catch (Exception e)  // the parameter & parentheses "(Exception e)" is not needed here but allows for preset messages to be entered and do other functions
                {
                    Console.WriteLine(e.Message);   //this will print out the preset message "Input string was not in a correct format"
                    Console.WriteLine($"Unable to Parse '{character}'");
                }


                
            }


            // Inside your try block
            // done - set your string variable to each array element in your char[] to .ToString()
            // done - Now, using int.Parse, parse your string variable and store in an int variable
            // done - Then add each int to your list

            // Catch your Exception:
            // done - in the scope of your catch you can use the following: 
            // Console.WriteLine($"Unable to Parse '{character}'"); //where character would be the name of each item in your collection


            Console.WriteLine("------------------------------");
            foreach (int num in numbers)     //this was given to do at the end
            {
                Console.WriteLine(num);
            }
        }
    }
}
