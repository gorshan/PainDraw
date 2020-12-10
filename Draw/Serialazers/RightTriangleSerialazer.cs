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
    public class RightTriangleSerialazer : ISerialazer
    {
        public AbstractFigure Deserialaze(string json)
        {
            return JsonConvert.DeserializeObject<RightTriangleFigure>(json);
        }

        public string Serialaze(AbstractFigure figure)
        {
            JArray jArray = new JArray();
            jArray.Add("RightTriangle");
            jArray.Add(JsonConvert.SerializeObject((RightTriangleFigure)figure));
            return jArray.ToString();
        }
    }
}
