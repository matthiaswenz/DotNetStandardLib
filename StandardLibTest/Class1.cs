using System;

namespace StandardLibTest
{
    public class Class1
    {
        public Class1() {
            throw new AccessViolationException();
        }
    }
}
