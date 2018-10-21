using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValues
{
    struct KeyValue
    {
        public string key { get; }
        public Object value { get; }

        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
