using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structage
{
    class Program
    {
        struct Rectangle
        {
            private int m_width;

            public int Width
            {
                get { return m_width; }
                set { m_width = value; }
            }

            private int m_height;

            public int Height
            {
                get { return m_height; }
                set { m_height = value; }
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangleOne = new Rectangle();
            rectangleOne.Width = 5;
            rectangleOne.Height = 10;

            Console.WriteLine("Rectangle One has the following dimension ratio... {0}:{1}", rectangleOne.Width, rectangleOne.Height);

            Console.ReadLine();
        }
    }
}
