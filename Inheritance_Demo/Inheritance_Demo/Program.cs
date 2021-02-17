using System;

namespace Inheritance_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var top = new TopClass();
            var mid = new MiddleClass();
            var bot = new BottomClass();

            top.TopMethod();
            top.TopProperty = "something";
            
            
        }
    }
}
