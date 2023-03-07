using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog palkan = new Dog("куриные лапки", "будка");
            Cat criska = new Cat("сухой корм", "дом");
            Horse igogosha = new Horse("яблоки", "конюшня");
            Veterinar veterinar = new Veterinar();

            palkan.makeNoise();
            palkan.eat();
            palkan.sleep();
            veterinar.treatAnimal(palkan);

            criska.makeNoise();
            criska.eat();
            criska.sleep();
            veterinar.treatAnimal(criska);

            igogosha.makeNoise();
            igogosha.eat();
            igogosha.sleep();
            veterinar.treatAnimal(igogosha);
        }
    }
    class Animal
    {
        public string food;
        public string location;
        public Animal(string food, string location)
        {
            this.food = food;
            this.location = location;
        }
        public virtual void makeNoise()
        {
            Console.WriteLine("ууу-ууу-ууу") ;
        }
        public virtual void eat()
        {
            Console.WriteLine("хрум-хрум");
        }
        public virtual void sleep()
        {
            Console.WriteLine("Хрр-хрр");
        }
    }
    class Dog : Animal
    {
        public string unique_factor = "Любимая игрушка - резиновая косточка";
        public Dog(string food, string location) : base(food, location)
        {
        }
        public override void makeNoise()
        {
            Console.WriteLine("Собака гавкает");
        }
        public override void eat()
        {
            Console.WriteLine("Собака ест");
        }
        public override void sleep()
        {
            Console.WriteLine("Собака спит");
        }
    }
    class Horse : Animal
    {
        public string unique_factor = "лошадь быстро скачет";
        public Horse(string food, string location) : base(food, location)
        {
        }
        public override void makeNoise()
        {
            Console.WriteLine("Лошадь фырчит");
        }
        public override void eat()
        {
            Console.WriteLine("Лошадь ест");
        }
        public override void sleep()
        {
            Console.WriteLine("Лошадь спит");
        }
    }
    class Cat : Animal
    {
        public string unique_factor = "Любимое место сна - диван";
        public Cat(string food, string location) : base(food, location)
        {
        }
        public override void makeNoise()
        {
            Console.WriteLine("Кошка мяукает");
        }
        public override void eat()
        {
            Console.WriteLine("Кошка ест");
        }
        public override void sleep()
        {
            Console.WriteLine("Кошка спит");
        }
    }
    class Veterinar
    {
        public void treatAnimal(Animal animal)
        {
            Console.WriteLine($"Любимая еда - {animal.food}; Место проживания - {animal.location}");
        }
    }
}
