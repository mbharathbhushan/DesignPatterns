using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractDP10.Factory.AbstractFactory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processor.i7.ToString();
        }
    }

    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processor.i5.ToString();
        }
    }

    public class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processor.i3.ToString();
        }
    }
}
