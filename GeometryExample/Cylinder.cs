using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Cylinder
    {
        public Cylinder() { }

        public double Radius { get; set; }

        public double Height { get; set; }  

        public double BaseArea { get; set; }

        public double LateralArea { get; set; }

        public double TotalArea { get; set; }

        public double Volume { get; set; }
        public void Process()
        {
             BaseArea = (float)(Radius * Radius * Math.PI);

             LateralArea = (float)(2 * Math.PI * Radius * Height);

             TotalArea = (float)(2 * Math.PI * Radius * (Height + Radius));

             Volume = (float)(Math.PI * Radius * Radius * Height);

        }

        public void Result()
        {
            Console.WriteLine("Enter the dimentstions of the cylinder");
            Console.WriteLine("Radius : "+Radius);
            Console.WriteLine("Height : "+Height);
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius : " + Radius + " Height : " + Height);
            Console.WriteLine("Base: "+BaseArea+" | "+" Latera: "+LateralArea + " | " +" Total: "+TotalArea + " | " +" Volume: "+Volume);
            
        }
    }
}
