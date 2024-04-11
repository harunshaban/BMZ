using BMZ.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMZ.Classes
{
    class Circle : IShape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Circle:");
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x <= radius; x++)
                {
                    double value = x * x + y * y;
                    if (value <= radius * radius)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
