namespace StackDS;
public class Stack<DataType>
{
    private int _count ;
    public int Count { get{return _count;} }
    private int _capacity ;
    private DataType[] _array ;


    public Stack()
    {
        _count = 0 ;
        _capacity = 4 ;
        _array = new DataType[_capacity];
    }
    public Stack(int size)
    {
        _count = 0 ;
        _capacity = size ;
        _array = new DataType[_capacity];
    }

    public void Push(DataType data)
    {
        if(_count == _capacity)
        {
            GrowSize();
        }
        _array[_count] = data ;
        _count++ ;
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

    public DataType Peek()
    {
        int top = _count;
        DataType temp = default(DataType);
        if(_count > 0)
        {
            temp = _array[ --top];
            return temp;
        }
        else
        {
            System.Console.WriteLine("Stack Empty");
            return temp;
        }
    }

    public DataType Pop()
    {
        DataType temp = default(DataType);
        if(_count > 0)
        {
            temp = _array[ --_count];
            return temp;
        }
        else
        {
            System.Console.WriteLine("Stack Empty");
            return temp;
        }
    }

    public bool Contains(DataType data)
    {
        bool flag = false;
        for(int i=0 ; i<_count ; i++)
        {
            if(_array[i].Equals(data))
            {
                flag = true ;
                return flag;
            }
        }
        if(flag)
        {
            return flag;
        }
        else
        {
            return flag;
        }
    }
}