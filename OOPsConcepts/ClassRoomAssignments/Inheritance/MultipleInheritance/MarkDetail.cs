namespace MultipleInheritance
{
    public interface IMarkDetail
    {
        int Physics {get;set;} // property declaration
        int Chemisty{get;set;}
        int Maths {get; set;}
        int Total{get;set;}
        double Average{get;set;}

        void GetMark(int physics , int chemisty,int maths); //method only no declarations
        void Calculate();
        void ShowMark();

         
    }
}