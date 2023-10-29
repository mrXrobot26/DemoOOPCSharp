namespace DemoOOP2
{
    internal class Program
    {
        //static int number(int num1 , int num2)
        //{
        //    int res = num1 + num2;
        //    return res;
        //}
        static void Main(string[] args)
        {
            //int num = number(3, 4);
            //Console.WriteLine(num);
            //++num;
            //Console.WriteLine(num);
            //int[] arr = new int[10];



            Car car1 = new Car();

            car1.Color = "red";
            car1.Brand = "BMW";
            car1.name = "x7";

            Console.WriteLine($" {car1.Brand} {car1.name} {car1.Color}");

            Car car2 = new Car();

            car2.Color = "AAAAAAAA";
            car2.Brand = "AAAAAAAA";
            car2.name =  "AAAAAAAA";

            Console.WriteLine($" {car2.Brand} {car2.name} {car2.Color}");





        }




    }
}