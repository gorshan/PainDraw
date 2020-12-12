using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.BitmapOperations.OperationParameters
{
   public class DrawFigureOperationParameters : IOperationParameters
    {
        public AbstractFigure Figure { get; set; }

        public DrawFigureOperationParameters(AbstractFigure figure)
        {
            Figure = figure;
        }
    }
}
