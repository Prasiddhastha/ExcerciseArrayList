using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseArrayList
{
    
    public class Remain
    {
        //Qno4
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        public static void GetList()
        {
            var k = 0;
            var num = new List<int>();
            var unique = new List<int>();
            Console.WriteLine("Enter a number or type Quit to exit");
            while (true)
            {
                var input = Console.ReadLine();
                if (Convert.ToString(input) == "Quit")
                {
                    break;
                }
                num.Add(Convert.ToInt32(input));
            }
            foreach (var number in num)
            {
               if(!unique.Contains(number))
               {
                  unique.Add(number);
               }
            }
            Console.WriteLine("Unique numbers Are:");
            foreach(var number in unique)
            {
                Console.WriteLine(number);
            }
        }
        //Qno5
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        public static void Last()
        {
            string[] array;
            Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).");
            while (true)
            {
                var input = Console.ReadLine();
                array = input.Split(",");
                if (String.IsNullOrWhiteSpace(input) || array.Length < 5)
                {
                    Console.WriteLine("invalid list");
                }
                else
                {
                    break;
                }
               
            }
            var number =  new List<int>();
            foreach(var numbers in array)
            {
                number.Add(Convert.ToInt32(numbers));
            }

            var smallests = new List<int>();
            while (smallests.Count<3)
            {
                var min = number[0];
                foreach(var numbers in number)
                {
                    if(numbers<min)
                    {
                        min= numbers;
                    }
                    smallests.Add(min);
                    number.Remove(min);
                }
            }
            foreach(var numbers in smallests)
            {
                Console.WriteLine(smallests);
            }
        }
    }
}
