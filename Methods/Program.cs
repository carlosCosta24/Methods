using System;

namespace Methods
{
    internal class Program
    {
        //basic method
        static void MyNamePrinter(){
            Console.WriteLine("My Name Is Carlos Costa, Iam a SWE");
        }
        //method with parameters
        //address as a default prameter
        static void BioPrinter(string Name, byte Age, string Ocupation, string Address = "") {
            Console.WriteLine($"\nName: {Name}, Age: {Age}, Job: {Ocupation}");
        }
        static int MyAge() {
            return 27;
        }
        //named arguments
        static string MyAddress(string add1, string add2, string add3) {
            return $"The main address is: {add3}";
        }
        //method overloading
        static int sum(int x, int y) { 
            return x + y;
        }
        static int sum(int x , int y, int z) {
            return x + y + z;
        }
        static int sum(int x, int y, int z, int k) { 
            return x + y + z + k;
        }

        static void Main(string[] args)
        {
         
              MyNamePrinter();

              string Name, Ocupation;
              byte Age;
              Console.WriteLine("\n\nEnter your name: ");
              Name = Console.ReadLine();
              Console.WriteLine("\n\nEnter your Job: ");
              Ocupation = Console.ReadLine();
              Console.WriteLine("\n\nEnter you age: ");
              Age = Convert.ToByte(Console.ReadLine());
              Console.WriteLine("Enter your adress: Its optional");
              string Address = Console.ReadLine();
              BioPrinter(Name,Age,Ocupation);
              Console.WriteLine($"Carlos Age is:{MyAge()}");
              Console.WriteLine( MyAddress(add1: "alex", add2: "aracaju", add3: "amsterdam"));
              Console.WriteLine(sum(10,20,30,50));
              Console.WriteLine(sum(50,60,70));
              Console.WriteLine(sum(100,50));
            
            try
            {
                int[] ids = { 01, 25, 35 };
                Console.WriteLine(ids[3]);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            Random random = new Random();
            Console.WriteLine($"The random number is: {random.Next(0,15)}");
            


            Console.ReadKey();  

        }
    }
}
