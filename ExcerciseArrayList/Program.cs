using System;
using System.Collections.Generic;
namespace ExcerciseArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var excercise = new Excercise();
            Console.WriteLine("1.Qno1\t2.Qno2\n3.Qno3\t4.Qno4\t5.Qno5");
            Console.Write("Enter Your Choice:");
            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    excercise.LikePost();
                    break;
                case 2:
                    excercise.ReverseName();
                    break;
                case 3:
                    excercise.Sort();
                    break;
                case 4:
                    Remain.GetList();
                    break;
                    //case 5:
                    //    ExcerciseExtended.GetMax();
                    //    break;
                    //default:
                    //    Console.WriteLine("Wrong input");
                    //    break;
            }
        }
    }
 }
