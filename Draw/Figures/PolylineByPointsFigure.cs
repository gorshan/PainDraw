using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draw.Figures;
using System.Drawing.Drawing2D;


namespace Draw.Figures
{
   public class PolylineByPointsFigure : AbstractFigure
    {
       
       

        public PolylineByPointsFigure()
        {
            Drawer = new PenDrawer();
            Points = new List<Point>();
        }

        
        public override void Update(Point startPoint, Point endPoint)

        {
            Points.Add(endPoint);                
        }

        public override void Move(Point delta)
        {
            throw new NotImplementedException();
        }

        public override bool IsThisFigure(Point point)
        {
            throw new NotImplementedException();
        }

        
    }
}
