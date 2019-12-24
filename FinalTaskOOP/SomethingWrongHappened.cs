using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTaskOOP
{
    class SomethingWrongHappened : Exception
    {
        public SomethingWrongHappened(string message) : base(message)
        { }
    }
}
