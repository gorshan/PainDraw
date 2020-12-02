using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Fabrics
{
    public class NAngleFabric : IFabric
    {
        public IFigure CreateFigure()
        {
            return new NAngleFigure();
        }
    }
}
