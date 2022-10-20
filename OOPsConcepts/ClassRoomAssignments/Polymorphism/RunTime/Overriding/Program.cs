using System;
namespace Overriding;
class Program 
{
    
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Eat();

        Dog dog = new Dog();
        dog.Eat();
        
        Pomerian pomerian = new Pomerian();
        pomerian.Eat();
        
    }
}