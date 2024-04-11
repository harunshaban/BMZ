using BMZ.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMZ.Classes
{
    class Square : IShape
    {
        private int size;

        public Square(int size)
        {
            this.size = size;
        }

        public void Draw()
        {
            Console.WriteLine("Square:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
