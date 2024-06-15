using System;

namespace OOPD
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            genericAnimal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            Circle circle = new Circle(5);
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");

            Rectangle rectangle = new Rectangle(4, 7);
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");
        }
    }

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
}
