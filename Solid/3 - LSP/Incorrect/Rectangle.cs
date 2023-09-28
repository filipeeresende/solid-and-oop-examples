using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._3___LSP.Incorrect
{
    public class Rectangle
    {
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }
        public double Area { get { return Height * Width; } }
    }
}
