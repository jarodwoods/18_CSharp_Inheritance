using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Demo
{
    class BottomClass : MiddleClass
    {
        public string BottomProperty { get; set; }

        public void BottomMethod()
        {
            Console.WriteLine("I am the Bottom Method");
        }


    }
}
