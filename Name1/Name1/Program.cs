using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question2;
using Question3;
using Question5;

namespace Name1
{
        class Program
        {
            static void Main(string[] args)
            {
               //int i;

               string input = "Hello World";
               string name;

               //float num2;
               //decimal num3;
               //double num4;
               //Boolean check = false;

               Console.WriteLine(input);
               name = Console.ReadLine();

               Console.WriteLine("Hello " + name);
               Console.ReadLine();
            //Steps to do : Under Solution Explorer - Name1(Main Program Name) - Add - Reference - Check all linked programs to be used - under using, 
            // type "using (program name space)"


            Programq2.Main(); //Remember to call the program "program name.method()";
            Programq3.Main();
            Programq5.Main();

            }
        }
       

  
}
