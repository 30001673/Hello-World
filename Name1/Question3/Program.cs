using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
   public class Programq3 
    {
       public static void Main()
        {
            Console.WriteLine("Input a Number Please.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Thankyou. Please Input a Second Number.");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 * num2);
            Console.ReadLine();
        }
    }
}
