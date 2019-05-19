using System;

namespace LogiCal
{
    sealed class SeparatorExpectedException : Exception
    {
        public SeparatorExpectedException() : base("Syntax error: Expected ',' separator.") { }
    }
}
