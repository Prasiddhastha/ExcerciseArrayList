﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcerciseArrayList
{
    public class Excercise
    {
        public void LikePost()
        { 
            var names = new List<string>();
                while (true)
                {
                    Console.Write("Type a name (or hit ENTER to quit): ");
                    var input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }
                    names.Add(input);
                }
            if (names.Count == 1)
            {
                Console.WriteLine($"[{names[0]}] like your post");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"[{names[0]}] and [{names[1]}] like your post");
            }
            else if (names.Count > 2 && names.Count - 2 == 1)
            {
                Console.WriteLine($"[{names[0]}], [{names[1]}] and [{names.Count - 2}] other like your post.");
            }
            else if (names.Count > 2)
            {
                Console.WriteLine($"[{names[0]}], [{names[1]}] and [{names.Count - 2}] others like your post.");

            }
        }
        public void ReverseName()
        {
            
            Console.Write("Enter Your name: ");
            var name = Console.ReadLine();
            var array = new char[name.Length];
            //

            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }
        public void Sort()
        {
            A: Console.WriteLine("Enter 5 numbers:");
            var num = new int[5];

           for(var i =0;i<5;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (i >= 1)
                {
                    if (num[i] == num[0] && num[i] == num[1]|| num[i] == num[2] || num[i] == num[3])
                    {
                        Console.WriteLine("Erorr");
                        Console.WriteLine("Please Retry");
                        goto A;
                    }
                }
            }
            Array.Sort(num);
           foreach (var number in num)
            {
                Console.WriteLine(number);
            }
          
        }
    }
}
