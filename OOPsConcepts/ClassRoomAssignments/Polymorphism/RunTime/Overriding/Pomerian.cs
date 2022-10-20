namespace Overriding
{
     class Pomerian:Dog
    {
        public new  void Eat()  //sealed  overring method
        {
            System.Console.WriteLine("I eat pomerian dog food");
        }
    }
}