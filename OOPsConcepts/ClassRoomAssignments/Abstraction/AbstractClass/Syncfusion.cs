namespace AbstractClass
{
    public class Syncfusion :Employee
    {
         public override string Name { get{return name;}set{name = value;} }

        //abstract Method definition
        public override void Salary(int dates)
        {
            Display(); //calling abstract class normal method
            Amount  = (double) dates*500;
            System.Console.WriteLine(Amount);
        }
    }
}