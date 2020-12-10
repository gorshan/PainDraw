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
    public class IsoscelesTriangleSerialazer : ISerialazer
    {
        public AbstractFigure Deserialaze(string json)
        {
            return JsonConvert.DeserializeObject<IsoscelesTriangleFigure>(json);
        }

        public string Serialaze(AbstractFigure figure)
        {
            JArray jArray = new JArray();
            jArray.Add("IsoscelesTriangle");
            jArray.Add(JsonConvert.SerializeObject((IsoscelesTriangleFigure)figure));
            return jArray.ToString();
        }
    }
}
