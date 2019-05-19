using System;

namespace LogiCal
{
    sealed class RightBracketExpectedException : Exception
    {
        public RightBracketExpectedException() : base("Syntax error: Expected closing bracket.") { }
    }
}
