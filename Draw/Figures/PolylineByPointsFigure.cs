using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
   public class PolylineByPointsFigure : IFigure
    {
        public LinkedList<Point> Points { get; set; }

        public IDrawer Drawer { get; set; }
        List<Point> IFigure.Points { get; set; }

        public PolylineByPointsFigure()
        {
            Drawer = new PenDrawer();
            Points = new LinkedList<Point>();
        }

        private Point _startPoint;
        private Point _endPoint;

        internal void Clear()
        {
            Points.Clear();
        }

        
        public Point[] GetPoints()
        {
            return Points.ToArray();
        }


        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public void Update(Point startPoint, Point endPoint)

        {
            Points.Add(endPoint);                
        }
    }
}
