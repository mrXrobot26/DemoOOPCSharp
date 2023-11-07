using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP2
{
    internal class Employee
    {

        public int salary;
        //private string name;

        //public void SetName(string _name)
        //{
        //    name = _name;
        //}

        //public string GetName()
        //{
        //    return name;
        //}

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public string Name { get;set; }


        public void setSalary(int _salary)
        {
            if (_salary<5000)
            {
                salary = 5000;
            }
            else if(_salary >= 20000)
            {
                salary = 20000;
            }
            else
            {
                salary =_salary;
            }

        }


        //public Employee(string _name , int _salary)
        //{
            
        //    name = _name;
        //    if(_salary <= 5000)
        //    {
        //        salary = 5000;
        //    }
        //    else
        //    {
        //        salary = _salary;
        //    }

        //}


        public Employee()
        {
            
        }






    }
}
