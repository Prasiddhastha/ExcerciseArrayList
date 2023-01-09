using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseArrayList
{
    //Qno4
    public class Remain
    {
        public static void GetList()
        {
            var k = 0;
            var num = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or type Quit to exit");
                var input = Console.ReadLine();
                var index = num.IndexOf(Convert.ToInt32(input));

                if (input == "Quit")
                {

                    break;
                }
                
                //    if (num.Contains(Convert.ToInt32(input)))
                //    {
                //        var j = num.IndexOf(Convert.ToInt32(input));

                //        num.RemoveAt(j);
                //        num.RemoveAt(index);
                //    }





                //    num.Add(Convert.ToInt32(input));




                //}
                //foreach(var number in num)
                //{
                //    Console.WriteLine(number);
                //}

            }
            
        }
    }
}
