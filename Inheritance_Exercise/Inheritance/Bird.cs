using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            Arms = 0;
            Skin = true;
            Heart = 1;
        }
        public bool HasWings { get; set; }
        public bool HasFeathers { get; set; }
        public bool HasClaws { get; set; }
        public bool CanFly { get; set; }


    }
}
