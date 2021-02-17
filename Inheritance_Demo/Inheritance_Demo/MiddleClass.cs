using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Demo
{
    class MiddleClass : TopClass
    {
        public string MiddleProperty { get; set; }

        public void MiddleMethod()
        {
            Console.WriteLine("I am the middle method");
        }
    }
}
