using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._3___LSP.Incorrect
{
    public class Square : Rectangle
    {
        public override double Height
        {
            set { base.Height = base.Width = value; }
        }

        public override double Width
        {
            set { base.Height = base.Width = value; }
        }
    }
}
