using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCal
{
    public class Row
    {
        public Dictionary<char, bool> Values { get; }
        
        public Row(Dictionary<char, bool> values)
        {
            Values = values;
        }
    }
}
