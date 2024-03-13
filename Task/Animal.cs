using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public string Voice;
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    
    }
    class Dog : Animal
    {
        private string name;
        //private string voice;
        public override string Name { get => name; set => name = value; }

        public Dog(string name)
            :base(  name)
        {
            
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
    class Cat : Animal
    {
        private string name;
        //private string voice;
        public override string Name { get => name; set => name = value; }
        public Cat(string name)
            : base(name)
        {
            
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
