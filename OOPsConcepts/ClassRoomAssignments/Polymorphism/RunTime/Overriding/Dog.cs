namespace Overriding
{
   class Dog:Animal //derived class of animal
    {
        public override void Eat()  //overiding method from animal
        {
             System.Console.WriteLine("I eat Dog food");
        }
       
    }
}