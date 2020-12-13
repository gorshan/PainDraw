using Draw.Drawer;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class LineFigure : AbstractFigure
    {

        
        public LineFigure()
        {
            Drawer = new PenDrawer();
        }

        public override void Update(PointF startPoint, PointF endPoint)
        {
            Points = new List<PointF>
            {
                startPoint,
                endPoint
            };
        }

        public override void MoveFace(PointF delta)
        {
            
        }

        public override void FillFigure()
        {
            IsFilled = !IsFilled;
        }
    }
}
