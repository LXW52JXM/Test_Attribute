using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Attribute
{
    public class Student
    {
        public string Accont { get; set; }

        [Long(10001, 999999999999)]
        public long QQ { get; set; }
    }
}
