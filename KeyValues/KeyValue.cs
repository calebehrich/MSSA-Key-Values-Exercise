using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValues
{
    struct KeyValue<T>
    {
        public string key { get; }
        public T value { get; }

        public KeyValue(string key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
