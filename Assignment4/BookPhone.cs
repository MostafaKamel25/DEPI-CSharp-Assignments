using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Assignment4
{
    internal class BookPhone
    {
        long[] _numbers;
        string[] _names;

        int _size;

        public int Size 
        { 
            get 
            { return _size; }    
        
        }

        public long this[string name]
        {
            get
            {
                if (name == null)
                    return -1;
                if(_names is not null && _numbers is not null)
                {
                    for (int i = 0; i < _size; i++)
                    {
                        if (name == _names[i])
                        {
                            return _numbers[i];
                        }
                    }
                    
                }
                return -1;
            }
        }
        public string this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < _size)
                {
                    return $"Position: {idx} :: name: {_names[idx]} :: PhoneNumber: {_numbers[idx]}";
                }
                return $"Position {idx} is not founded";
            }
        }
        public BookPhone(int idx)
        {
            _size = idx;
            _names = new string[_size];
            _numbers = new long[_size];
        }
        public void addPerson(int pos , long phoneNum , string name)
        {
            _names[pos] = name;
            _numbers[pos] = phoneNum;
        }
    }
    
}
