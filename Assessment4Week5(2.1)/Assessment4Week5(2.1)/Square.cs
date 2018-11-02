using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4Week5_2._1_
{
        class Square : Shape
        {
            private double _side;

            public double Side
            {
                get { return _side; }
            }

            public Square()
            {
                _side = 0;
            }

            public Square(double Side)
            {
                _side = Side;
            }

            public override void Draw()
            {
                Console.WriteLine("Hi, I am a square!");
            }

            public double GetArea()
            {
                return _side * _side;
            }
        }
    }
