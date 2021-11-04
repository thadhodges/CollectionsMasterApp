using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var intergerArray = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            var rnd = new Random();
            
            for (int i = 0; i < intergerArray.Length; i++)
            {
                intergerArray[i] = rnd.Next(1,50);
            }

            //Print the first number of the array

            Console.WriteLine(intergerArray[0]);

            //Print the last number of the array
            //
            Console.WriteLine(intergerArray[49]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(intergerArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            Array.Reverse(intergerArray);
            NumberPrinter(intergerArray);

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            //for (int i = 49; i >= 0 && i < intergerArray.Length; i--)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            Console.WriteLine(ThreeKiller(intergerArray));

            foreach (int num in intergerArray)

            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(0);                    
                    
                }
                else
                {
                    Console.WriteLine(num);
                }
               
            }
            

            

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(intergerArray);
            NumberPrinter(intergerArray);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var intList = new List<int>();


            //Print the capacity of the list to the console

            Console.WriteLine(intList.Count);


            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            var newRandom = new Random();

            for (int i = 0; i < 50; i++)
            {
                intList.Add(newRandom.Next(0, 50));
            }

            //Print the new capacity
            Console.WriteLine(intList.Count);
            

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            Console.WriteLine("Select a whole positive integer between 0 and 50");
            int input = int.Parse(Console.ReadLine());

            
             
            if (intList.Contains(input))
                {
                    Console.WriteLine($"Your number is in the list!!!!");
                }
                    if (intList.Contains(input) == false)
                        {
                            Console.WriteLine($"Your number is not on the list!!!");
                        }
                            //else
                            //{
                            //    Console.WriteLine($"Sorry, your input is not valid");
                            //}
            

            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(intList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            for (int i = 0; i < intList.Count; i++)
            {
                int num = intList[i];
                if (num % 2 != 0)
                {
                    intList.Remove(num);
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            intList.Sort();
            NumberPrinter(intList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] newArray = intList.ToArray();
            NumberPrinter(newArray);

            //Clear the list
            intList.Clear();
            Console.WriteLine(intList.Count);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(0);
                }
                Console.WriteLine(num);
            }
        }

        private static void ThreeKiller(List<int> numbersList)
        {
            foreach (int num in numbersList)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(0);
                }
                Console.WriteLine(num);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach (int num in numberList)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine(0);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
