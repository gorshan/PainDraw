using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Draw.Figures;


namespace Draw.Figures
{
    class TriangleByPointsFigure : FigureByPoints
    {
        public override void DrawFigure(Graphics graphics, Pen pen, List<Point> points)
        {
                graphics.DrawLines(pen, GetPoints(points));
            
        }
  
        private Point [] GetPoints(List<Point> points)
        {
            Point[] pointsArray = new Point[4];
            points.CopyTo(0, pointsArray, 0, 3);
            pointsArray[3] = pointsArray[0];
            return pointsArray;
        }

    }

}
