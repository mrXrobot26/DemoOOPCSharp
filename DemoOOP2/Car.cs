using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP2
{
    public class Car
    {
        public string Color;
        public string name;
        public string Brand;

        public Car(string _Color , string _name , string _Brand)
        {
            Color = _Color;
            name = _name;
            Brand = _Brand;

        }





        public void Move()
        {
            Console.WriteLine("car is moving right now");
        }

        public void Stop()
        {
            Console.WriteLine("car Stopped");
        }

        public void speedUp()
        {
            Console.WriteLine("car Speeding up Now");
        }
        public void speedDown()
        {
            Console.WriteLine("car Speeding Down Now");
        }





    }
}
