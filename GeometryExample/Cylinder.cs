using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Cylinder
    {
        public Cylinder() { }

        public float Radius { get; set; }

        public float Height { get; set; }  
        public void Process()
        {
            float BaseArea = (float)(Radius * Radius * Math.PI);

            float LateralArea = (float)(2 * Math.PI * Radius * Height);

            float TotalArea = (float)(2 * Math.PI * Radius * (Height + Radius));

            float Volume = (float)(Math.PI * Radius * Radius * Height);

        }

        public void Result()
        {

        }
    }
}
