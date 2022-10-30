using System.Collections;
namespace DictionaryDS
{
    public partial class Dictionary<Tkey,Tvalue>:IEnumerable,IEnumerator
    {
        private int Position;
        public IEnumerator GetEnumerator()
        {
            Position = -1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(Position < _count -1)
            {
                ++Position;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            Position = -1;
        }
        public object Current{get{return _array[Position];}}
             
    }
}