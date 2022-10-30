using System;
using System.Collections.Generic;

namespace CafeteriaCardManagement;
public partial class List<DataType>
{
    public void RemoveAt(int index)
    {
        for(int i=index ; i<_count ;i++)
        {
            _array[i] = _array[i+1];
        }
        _count--;
    }
     public void Bubble()
    {
        DataType temp;
        for (int j = 0; j<=_count-2; j++)
        {
            for (int i = 0; i<=_count-2;i++)
            {
                if(IsGreater(_array[i],_array[i+1]))
                {
                    temp = _array[i+1];
                    _array[i+1] = _array[i];
                    _array[i] = temp;

                }
            }
        }
        
    }
    public bool IsGreater(DataType value1,DataType value2) 
    {
        var result = Comparer<DataType>.Default.Compare(value1,value2);
        if(result >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}