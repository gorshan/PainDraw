using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    public class CanvasCondition
    {
        public Bitmap RestoreBitmap { get; set; }
        public List<AbstractFigure> RestoreFigures { get; set; }

        public CanvasCondition(Bitmap bitmap, List<AbstractFigure> figures)
        {
            RestoreBitmap = bitmap;
            RestoreFigures = figures;
        }
    }
}
