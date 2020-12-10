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
    public class SquareSerialazer : ISerialazer
    {
        public AbstractFigure Deserialaze(string json)
        {
            return JsonConvert.DeserializeObject<SquareFigure>(json);
        }

        public string Serialaze(AbstractFigure figure)
        {
            JArray jArray = new JArray();
            jArray.Add("Square");
            jArray.Add(JsonConvert.SerializeObject((SquareFigure)figure));
            return jArray.ToString();
        }
    }
}
