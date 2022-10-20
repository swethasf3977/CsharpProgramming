namespace RunTimePolymorphismn
{
   class Total:Sport
    {  
        public int AcademicMark = 90;
        public override void Display()
        {
            TotalMark = SportMark + AcademicMark;
            System.Console.WriteLine("Name "+Name+"Total Mark "+TotalMark);
        }
    }
}