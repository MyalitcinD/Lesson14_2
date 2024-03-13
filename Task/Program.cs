using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Джус");
            Dog dog = new Dog("Брайн");
            dog.Say();
            dog.ShowInfo();
            Console.WriteLine();
            cat.Say();
            cat.ShowInfo();
            Console.ReadKey();

        }
    }
}
