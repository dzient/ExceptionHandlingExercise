using System;
using System.Collections.Generic;
using System.IO;
//-----------------------------------------------------------------
// ExceptionHandlingExercise
//
// Name: David Zientara
// Date: 7-25-2022
// Comments: An exercise in using exception handling
// Made changes per the instructions
//-----------------------------------------------------------------
namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var ar = new char[] { '1', '2', '3', '5', '7', '9', 'a', 'e', 'i' };

            List<char> list = new List<char>();
            int a = 0;


            //TODO START HERE:

            // Make a foreach loop to iterate through your character array - DONE
            // I think FormatException is the error we want to catch:
            Console.WriteLine("Here's the original array:");
            try
            {
                //Write line to stdout and parse it:
                foreach (char c in ar)
                {
                    Console.Write(c.ToString()+'\t');
                    a = int.Parse(c.ToString());
                }
               
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError iterating through array");
            }
            catch 
            {
                Console.WriteLine("Unknown error");
            }
            Console.WriteLine();

            // Now create a try catch


            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list
            // We will catch an IndexOutOfRangeException first,
            // then a FormatException (for parsing errors),
            // then a general error


            try
            {
                string str = "";
                for (int i = 0; i < 9; i++)
                {
                    str = ar[i].ToString();
                    a = int.Parse(str);
                    list.Add((char)a);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was out of bounds.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse {a}");
            }
            catch
            {
                Console.WriteLine("Unknown error");
            }
            // No matter what happens, this code should run to 
            // see what was added before we threw an exception
            finally
            {
                Console.WriteLine("Here's what was written to the list:");
                list.ForEach(x => Console.WriteLine(x));

            }


            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
