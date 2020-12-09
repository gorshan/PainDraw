using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Serialazers
{
    public interface ISerialazer
    {
        string Serialaze(AbstractFigure figure);
        AbstractFigure Deserialaze(string json);
    }
}
