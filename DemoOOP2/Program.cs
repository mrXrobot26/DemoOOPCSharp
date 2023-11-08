namespace DemoOOP2
{
    internal class Program
    {
        #region lec1
        //static int number(int num1 , int num2)
        //{
        //    int res = num1 + num2;
        //    return res;
        //}
        #endregion

        static void Main(string[] args)
        {


            #region lec1
            //int num = number(3, 4);
            //Console.WriteLine(num);
            //++num;
            //Console.WriteLine(num);
            //int[] arr = new int[10];



            //Car car1 = new Car("red","X7","BMW");



            //Console.WriteLine($" {car1.Brand} {car1.name} {car1.Color}");

            ////Car car2 = new Car();

            ////car2.Color = "AAAAAAAA";
            ////car2.Brand = "AAAAAAAA";
            ////car2.name =  "AAAAAAAA";

            ////Console.WriteLine($" {car2.Brand} {car2.name} {car2.Color}");

            #endregion

            #region lec2
            //Employee emp1 = new Employee("Khaled", 6000);

            //Console.WriteLine($"{emp1.name} , {emp1.salary}");

            //Employee emp2 = new Employee();

            //emp2.name = "ddd";

            //emp2.SetName("A7med");

            //string name = emp2.GetName();

            //emp2.salary= 10000000;


            //Console.WriteLine(emp2.Name);


            //Console.WriteLine(name);


            //Console.WriteLine("kkkkkkkk");


            //Console.WriteLine($"{emp2.name} , {emp2.salary}");

            #endregion

            #region lec3
            //Numbers n1 = new Numbers();
            //n1.getNumber(1.3, 2);
            //n1.getNumber(2, 3, 4);
            #endregion

            #region lec4
            
            //Car car = new Car();
            //Console.WriteLine(car.Brand);

            //car.honk();


            #endregion


            #region Lec5
            Car car = new Car();
            car.name = "Test";
            Console.WriteLine(car.Brand+" "+ car.name);
            car.Moving();
            

            // poilymorphysim
            Animal A1 = new Animal();
            Animal C1 = new Cat();
            Animal P1 = new Pig();

            A1.AnimalSound(); //Animal make sound
            C1.AnimalSound(); // meow
            P1.AnimalSound(); //israe.

            #endregion






        }




    }
}