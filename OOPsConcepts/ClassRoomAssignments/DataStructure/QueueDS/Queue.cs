namespace QueueDS;
public class Queue<DataType>
{
    private int _count ;
    public int Count { get{return _count;} }
    private int _capacity ; 
    private int _head ;
    private int _tail ;
    private DataType[] _array ;

    public Queue()
    {
        _count = 0;
        _capacity = 4 ;
        _head = 0;
        _tail = 0 ;
        _array = new DataType[_capacity];
    }

    public Queue(int size)
    {
        _count = 0 ;
        _capacity = size ;
        _head = 0;
        _tail = 0 ;
        _array = new DataType[_capacity];
    }

    public void Enqueue(DataType data)
    {
        if(_tail == _capacity)
        {
            GrowSize();
        }
        _array[_tail] = data ;
        _tail++;
        _count++;
    }
    void GrowSize()
    {
        _capacity = _capacity * 2;
        DataType[] temp = new DataType[_capacity]; 
        for(int i=_head ; i<_tail ; i++)
        {
            temp[i] = _array[i];
        }
        _array = temp ;
    }

    public DataType Dequeue()
    {
        DataType temp = default(DataType);
        if(_tail > _head)
        {
            temp = _array[ _head++];
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
        bool temp = false;
        for(int i=_head ; i<_tail ; i++)
        {
            if( _array[i].Equals(data))
            {
                temp = true;
            }
        }
        return temp;
    }

    public DataType Peek()
    {
        DataType temp = default(DataType);
        if(_count > 0)
        {
            temp = _array[ _head];
            return temp;
        }
        else
        {
            System.Console.WriteLine("Stack Empty");
            return temp;
        }
    }
}