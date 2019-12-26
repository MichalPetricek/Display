using System;
using System.Collections.Generic;
using System.Text;

namespace Display
{
     abstract class All
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        protected All(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void GetPosition()
        {
            Console.SetCursorPosition(X, Y);
        }


    }
}
