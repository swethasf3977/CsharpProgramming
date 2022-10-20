namespace AbstractClass
{
    public abstract class Employee
    {
        protected string name; //normal field
        public abstract string  Name { get; set; } //abstract property
        public double Amount { get; set; } //Normal property
        
        public void Display() //normal method
        {
            System.Console.WriteLine(name);
        }
        public abstract void Salary(int dates); //Abstract Method
        
    }
}