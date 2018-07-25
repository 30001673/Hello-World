using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public class Programq5
    {
        public static void Main()
        {
         Console.WriteLine("Please Input a Number between 1 and 12.");
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= 12; i++)
            {
                string text = num + " x " + i;
                Console.WriteLine(text);
                
                Console.WriteLine(num* i);
                Console.ReadLine();
            }
        }
    }   
}
