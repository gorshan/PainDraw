using Draw.Figures;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
