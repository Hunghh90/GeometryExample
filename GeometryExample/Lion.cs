using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Lion : Animal
    {
        public override string Name { get; set; }
        public override double Weight { get; set; }

        public Lion() { }

        public override void SetMe(string name, double weight)
        {
            Name = name; Weight = weight;
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + Name + ", Weight: " + Weight);
        }
    }
}
