using System;
using System.Collections.Generic;
using System.Text;

namespace JsonDataResult
{
    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Pet[] pets { get; set; }
    }

    public class Pet
    {
        public string name { get; set; }
        public string type { get; set; }
    }
}


