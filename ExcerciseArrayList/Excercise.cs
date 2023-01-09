using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcerciseArrayList
{
    public class Excercise
    {
        //Qno1
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
        //Qno2
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
        //Qno3
        public void Sort()
        {
            var num = new List<int>();
            var c = 5;
             Console.WriteLine($"Enter 5 numbers:");
            A: if(c<5)
            {
             Console.WriteLine($"Enter {c} numbers More:");
            }
            while (num.Count < 5)
            {
                
                c--;
                var input =Convert.ToInt32(Console.ReadLine());
               if(num.Contains(input))
                {
                    Console.WriteLine("You've previously entered:\n " + input);
                    Console.WriteLine("You have Entered these numbers:");
                    foreach (var j in num)
                    {
                        Console.WriteLine(j);
                    }
                    c++;
                    goto A;
                }
                num.Add(input);
            }
            num.Sort();
            var i = String.Join(",", num);
            Console.WriteLine("Sorted:");
            foreach (var number in num)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
