using System;

namespace DictionaryDS
{
    public class KeyValuePair<Tkey,Tvalue>
    {
        public Tkey Key { get; set; }
        public Tvalue Value { get; set; }
    }
}