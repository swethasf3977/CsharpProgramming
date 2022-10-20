namespace SealedClass
{
     class LivingThings
    {
        
    }
    sealed class Animal:LivingThings
    {

    }
    //try to inherit sealed class
    // produce error in code
    class Dog :Animal
    {
        
    }
}