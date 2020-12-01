using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using Draw.Figures;
using Draw.Drawer;

namespace Draw.Canvases
{
   internal class AnglePointsDrawer :IDrawer
    {

        public void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints)
        {

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            for (int i = 0; i < figurePoints.Length - 1; i++)
            {
                graphics.DrawLine(pen, figurePoints[i], figurePoints[i + 1]);
                if (i == 2)
                {
                    graphics.DrawLine(pen, figurePoints[i], figurePoints[0]);
                    break;
                }
            }

            
            //graphics.DrawLine(pen, figurePoints[3], figurePoints[0]);

            //pen.StartCap = LineCap.Round;
            //pen.EndCap = LineCap.Round;
            //for (int i = 0; i < figurePoints.Length - 1; i++)
            //{
            //    graphics.DrawLine(pen, figurePoints[i], figurePoints[i + 1]);

            //}
        }
    }
}
