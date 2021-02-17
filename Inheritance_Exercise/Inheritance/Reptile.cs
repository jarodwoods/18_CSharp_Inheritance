using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {
            Legs = 4;
            Arms = 0;
            Skin = false;
            Heart = 1;
        }
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasTail { get; set; }
        public bool LaysEggs { get; set; }
    }
}
