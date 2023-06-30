using BAsics;

namespace AConstructor
{
     class Program
     {
        static void Main(string[] args)
        {
            Constructor Add = new Constructor("i10","Red",2023);
            Console.WriteLine("Car Name is : "+ Add.Model +" Color is "+Add.Color+" Year of Manufacture "+Add.Year);               
        }
     }
}