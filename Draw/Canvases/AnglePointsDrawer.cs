using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using Draw.Figures;

namespace Draw.Canvases
{
   public class AnglePointsDrawer :IDrawer
    {

        public void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints)
        {

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            for (int i = 0; i < 3; i++)
            {
                graphics.DrawLine(pen, figurePoints[i], figurePoints[i + 1]);

            }
            graphics.DrawLine(pen, figurePoints[3], figurePoints[0]);

            //pen.StartCap = LineCap.Round;
            //pen.EndCap = LineCap.Round;
            //for (int i = 0; i < figurePoints.Length - 1; i++)
            //{
            //    graphics.DrawLine(pen, figurePoints[i], figurePoints[i + 1]);

            //}
        }
    }
}
