using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile() 
        {
            AnimalType = "reptile";
            Legs = 4;
            SkinType = "scales";
            Habitat = "land";
        }
        public string Classification { get; set; }
        public bool BackBone { get; set; }
        public bool EggLayer { get; set; }
        public int AgeLength { get; set; }




    }
}
