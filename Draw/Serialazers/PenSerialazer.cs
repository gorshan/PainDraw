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
    public class PenSerialazer : ISerialazer
    {
        public AbstractFigure Deserialaze(string json)
        {
            return JsonConvert.DeserializeObject<PenFigure>(json);
        }

        public string Serialaze(AbstractFigure figure)
        {
            JArray jArray = new JArray();
            jArray.Add("Pen");
            jArray.Add(JsonConvert.SerializeObject((PenFigure)figure));
            return jArray.ToString();
        }
    }
}
