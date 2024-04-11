using BMZ.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMZ.Classes
{
    class Triangle : IShape
    {
        private int height;

        public Triangle(int height)
        {
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine("Triangle:");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
