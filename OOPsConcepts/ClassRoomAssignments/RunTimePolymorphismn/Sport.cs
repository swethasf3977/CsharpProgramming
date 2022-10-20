namespace RunTimePolymorphismn
{
     class Sport:Student
    {
        public int SportMark = 50;
        public override void Display()
        {
            System.Console.WriteLine("Name "+Name+" Mark "+SportMark);
        }
        
    }
}