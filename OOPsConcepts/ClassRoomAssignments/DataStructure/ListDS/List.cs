namespace ListDS;
public partial class List<DataType>
{
   private int _count ;
   public int Count { get{return _count;} } 
   private int _capacity ;
   public int Capacity { get{return _capacity;} }
   private DataType[] _array;

   public DataType this[int i]
   {
    get{return _array[i];}
    set{_array[i] = value ;}
   }

   public List()
   {
        _count = 0;
        _capacity = 4 ;
        _array = new DataType[_capacity] ;
   }

   public List(int size)
   {
        _count = 0;
        _capacity = size ;
        _array = new DataType[_capacity] ;
   }
   public void Add(DataType data)
   {
        if(_count == _capacity)
        {
            GrowSize();
        }
        _array[_count] = data ;
        _count++ ;
   }
   public void AddRange(List<DataType> data)
    {
        int capacity = _count + data.Count+4 ;
        DataType[] temp = new DataType[capacity];
        for(int i=0 ; i<_count ; i++)
        {
            temp[i] = _array[i];
        }
        for(int i=0 ; i<data.Count ; i++)
        {
            temp[i+_count] = data._array[i];
        }
        _array = temp;
        _count+=data._count;
    }

   void GrowSize()
    {
        _capacity = _capacity * 2 ;
        DataType[] _temp = new DataType[_capacity];
        for(int i=0 ; i<_count ; i++)
        {
            _temp[i] = _array[i];
        }
        _array = _temp ;
    }

    public void Insert(int index , DataType data)
    {
        DataType[] temp = new DataType[_capacity+1];
        for(int i=0 ; i<_count+1 ; i++)
        {
            if(i < index)
            {
                temp[i] = _array[i];
            }
            else if(i == index )
            {
                temp[i] = data;
            }
            else
            {
                temp[i] = _array[i-1];
            }
        }

        _array = temp;
        _count++;
       
    }
   
}