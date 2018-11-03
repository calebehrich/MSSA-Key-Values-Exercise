using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValues
{
    class MyDictionary<T>
    {

        public KeyValue<T>[] keyValueArr = new KeyValue<T>[50];

        int counter = -1;

        public T this[string key]
        {
            get
            {
                for (int i = 0; i < keyValueArr.Length; i++)
                {
                    if(key ==keyValueArr[i].key)
                    {
                        return keyValueArr[i].value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                bool replace = false;
                for(int i = 0; i < counter; i++)
                {
                    if(key == keyValueArr[i].key)
                    {
                        keyValueArr[i] = new KeyValue<T>(key, keyValueArr[i].value);
                        replace = true;
                    }
                }
                if(replace == false)
                {
                    keyValueArr[counter + 1] = new KeyValue<T>(key, value);
                }
                counter++;
            }
        }
    }
}
