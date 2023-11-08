using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP2
{
    public class Vechceil // parent base
    {
        public string Brand = "Ford";
        private string color = "red";
        protected string model = "a123";
        public Vechceil(int x)
        {
            if (x > 5)
            {
                Console.WriteLine(" i > 5");
            }
            else
            {
                Console.WriteLine("i<=5");
            }
        }
        public Vechceil()
        {
            Console.WriteLine("empty ctor");
        }
        public void Moving()
        {
            Console.WriteLine("vechil moving");
        }
    }
}
