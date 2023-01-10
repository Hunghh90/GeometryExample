using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Exercise2
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract double Weight { get; set; }

        public abstract void SetMe(string name, double weight);



        public abstract void Show();
        
    }
}
