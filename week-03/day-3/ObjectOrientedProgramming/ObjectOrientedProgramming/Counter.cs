using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Counter
    {
        int Value { get; set; } 
        private int defaultValue = 0;

        public Counter (int value)

        {
            Value = value;
            defaultValue = value;
        }
        public Counter()
        {
            Value = defaultValue;
        }

        public void Add()
        {
            Value++;
        }
        public void Add(int addValue)
        {
            Value = Value + addValue;
        }
        public string Get()
        {
            return Value.ToString();
        }
        public void Reset()
        {
            Value = defaultValue;
        }
    }
}
