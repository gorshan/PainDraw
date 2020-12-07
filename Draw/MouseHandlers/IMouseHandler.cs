using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.MouseHandlers
{
    public interface IMouseHandler
    {
        void OnMouseDown(Point location);
        void OnMouseMove(Point location);
        void OnMouseUp(Point location);
    }
}
