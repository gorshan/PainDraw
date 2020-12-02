using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Fabrics
{
    public class LineFabric : IFabric
    {
        public IFigure CreateFigure()
        {
            return new LineFigure();
        }
    }
}
