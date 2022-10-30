namespace DictionaryDS
{
    public partial class Dictionary<Tkey,Tvalue>
    {
        private int _count;
        private int _capacity;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }
        private KeyValuePair<Tkey,Tvalue>[] _array;

        public Tvalue this [Tkey key]  //indexer
        {
            get
            {
                Tvalue value = default(Tvalue);
                if(IsKeyPresent(key,out value))
                {
                    return value;
                }
                return value;
            }
            set
            {
                int position = KeyPosition(key);
                if(position !=-1)
                {
                    _array[position].Value = value;
                }
            }
        }

        public Dictionary()
        {
            _count =0;
            _capacity=4;
            _array =new KeyValuePair<Tkey, Tvalue>[_capacity];
        }
        public Dictionary(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new KeyValuePair<Tkey , Tvalue>[_capacity];

        }
        public void Add(Tkey key,Tvalue value)
        {
            if(_count ==_capacity)
            {
                Growsize();
            }
            if(!IsKeyPresent(key,out Tvalue value1))
            {
            KeyValuePair<Tkey,Tvalue> data = new KeyValuePair<Tkey, Tvalue>();
            data.Key = key ;
            data.Value = value;
            _array[_count] =data;
            _count++;
            }
            else
            {
                System.Console.WriteLine("Key is already present");
            }
        }
        public void Growsize()
        {
            _capacity = _capacity*2;
            KeyValuePair<Tkey,Tvalue>[] temp = new KeyValuePair<Tkey,Tvalue>[_capacity];
            for (int i = 0 ; i<_count;i++)
            {
                temp[i] = _array[i];
  
            }
            temp = _array;

        }
        private bool IsKeyPresent(Tkey key,out Tvalue value)
        {
            for (int i = 0;i<_count;i++)
            {
                if(_array[i].Key.Equals(key))
                {   
                    value = _array[i].Value;
                    return true;
                }
            }
            value = default(Tvalue);
            return false;
        }
        public bool ContainsKey(Tkey key)
        {
            return IsKeyPresent(key,out Tvalue value);

        }
        public bool ContainsValue(Tvalue value)
        { 
            for (int i = 0;i<_count;i++)
            {
                if(_array[i].Value.Equals(value))
                {
                    return true;
                }
            }
            return false;
            
        }
        private int KeyPosition(Tkey key)
        {
            for (int i = 0;i<_count;i++)
            {
                if(_array[i].Key.Equals(key))
                {   
                    
                    return i;
                }
               
            }
            return -1;
           
        }     
        
    }
}