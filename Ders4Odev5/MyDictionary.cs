using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Odev5
{
    class MyDictionary<T, K>
    {
        T[] _keys;
        K[] _values;

        public MyDictionary()
        {
            _keys = new T[0];
            _values = new K[0];
        }

        public void Add(T key, K value)
        {
            T[] tempArrayKeys;
            K[] tempArrayValues;

            tempArrayKeys = _keys;
            tempArrayValues = _values;

            _keys = new T[tempArrayKeys.Length + 1];
            _values = new K[tempArrayValues.Length + 1];

            for (int i = 0; i <tempArrayKeys.Length; i++)
            {
                _keys[i] = tempArrayKeys[i];
                _values[i] = tempArrayValues[i];
            }

            _keys[_keys.Length-1] = key;
            _values[_values.Length-1] = value;
        }
    }
}
