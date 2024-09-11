using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird() 
        {
            AnimalType = "bird";
            Legs = 2;
            SkinType = "feathers";
            Habitat = "air";
        }
        public string Classification { get; set; }
        public string CanFly { get; set; }
        public string Color { get; set; }
        public double WingSpan { get; set; }

    }
}
