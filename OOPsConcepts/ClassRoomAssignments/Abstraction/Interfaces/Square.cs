namespace Interfaces
{
    public class Square :ICalculate
    {
        private int _number; //property
        public int Number{ get{return  _number;} set{_number = value;} }  //fully abstraction
        public int Calculate()
        {
            _number *= _number;
            return _number;
        }
    }
}