using System;
using System.Collections.Generic;
using System.Text;

namespace Display
{
    class Element :All
    {
        protected string _text { get; set; }
        public Element(int x, int y, string text) :base( x, y)
        {
            X = x;
            Y = y;
            _text = text;
        }
      
        public override string ToString()
        {
            return _text.ToString();
        }

    }
}
