using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP2
{
    internal class Numbers
    {

        public void getNumber(int num1 , int num2)
        {
            Console.WriteLine("from int int");
            Console.WriteLine(num1+num2);
        }

        public void getNumber(double num1, int num2)
        {
            Console.WriteLine("from double int");

            Console.WriteLine(num1 * num2);
        }

        public void getNumber(int num1, int num2, int num3)
        {
            Console.WriteLine("from int int int");

            Console.WriteLine(num1 + num2 + num3);
        }


    }
}
