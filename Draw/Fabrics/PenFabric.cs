﻿using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Fabrics
{
    public class PenFabric : IFabric
    {
        public AbstractFigure CreateFigure()
        {
            return new PenFigure();
        }
    }
}
