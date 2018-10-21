using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValues
{
    class MyDictionary
    {

        public KeyValue[] keyValueArr = new KeyValue[50];
        int counter = -1;

        public Object this[string key]
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
                        keyValueArr[i] = new KeyValue(key, keyValueArr[i].value);
                        replace = true;
                    }
                }
                if(replace == false)
                {
                    keyValueArr[counter + 1] = new KeyValue(key, value);
                }
                counter++;
            }
        }
    }
}
