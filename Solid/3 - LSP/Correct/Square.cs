using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._3___LSP.Correct
{
    public class Square : Parallelogram
    {
        public Square(int height, int width) : base(height, width)
        {
            if (height != width)
                throw new ArgumentException("the sides are not equal");
        }
    }
}
