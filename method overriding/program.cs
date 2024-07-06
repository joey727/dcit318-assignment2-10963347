using System;

// Base class Animal
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // create instances of animal, dog, and cat
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Call the MakeSound() method on each instance
        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Console.ReadLine();
    }
}