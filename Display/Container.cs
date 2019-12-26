using System;
using System.Collections.Generic;
using System.Text;

namespace Display
{
    class Container :All
    {
        protected object _cover { get; set; }

        public Container(int x, int y, object cover) :base(x,y)
        {
            _cover = cover;
        }


        public override string ToString()
        {
            return _cover.ToString();
        }
    }
}
