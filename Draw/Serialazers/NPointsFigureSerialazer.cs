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
    public class NPointsFigureSerialazer : ISerialazer
    {
        public AbstractFigure Deserialaze(string json)
        {
            return JsonConvert.DeserializeObject<NPointsFigure>(json);
        }

        public string Serialaze(AbstractFigure figure)
        {
            JArray jArray = new JArray();
            jArray.Add("NPointsFigure");
            jArray.Add(JsonConvert.SerializeObject((NPointsFigure)figure));
            return jArray.ToString();
        }
    }
}
