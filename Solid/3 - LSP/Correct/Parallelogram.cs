using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._3___LSP.Correct
{
    public abstract class Parallelogram
    {
        protected Parallelogram(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Area { get { return Height * Width; } }
    }
}
