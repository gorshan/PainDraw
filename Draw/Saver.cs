using Draw.Drawer;
using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Draw.Serialazers;

namespace Draw
{
    public class Saver
    {
        private static Dictionary<Type, ISerialazer> _serialazers = new Dictionary<Type, ISerialazer>()
        {
            {typeof(SquareFigure), new SquareSerialazer() }
        };
        private static Dictionary<string, ISerialazer> _deserialazers = new Dictionary<string, ISerialazer>()
        {
            {"Square", new SquareSerialazer() }
        };

        public static void SaveImage(Bitmap bitmap)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp|GIF|*.gif";
            saveFileDialog.FileName = "figure";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName);
            }
        }

        public static void SaveProject(List<AbstractFigure> figures)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PainDraw|*.pd";
            saveFileDialog.FileName = "figure";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                JArray jArray = new JArray();
                for (int i = 0; i < figures.Count; i++)
                {
                    jArray.Add(_serialazers[figures[i].GetType()].Serialaze(figures[i]));

                }
                //formatter.WriteObject(saveFileDialog.OpenFile(), figures[0]);
                //string json = JsonSerializer.Serialize(figures[0].GetType());
                File.WriteAllText(saveFileDialog.FileName, jArray.ToString());
            }
        }

        public static List<AbstractFigure> LoadProject()
        {
            List<AbstractFigure> loadFigures = null;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PainDraw|*.pd";
            openFileDialog.FileName = "figure";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                JArray jArray = JArray.Parse(json);
                if(jArray.Count != 0)
                {
                    loadFigures = new List<AbstractFigure>();
                }
                for(int i = 0; i < jArray.Count; i++)
                {
                    JArray jFigure = JArray.Parse(jArray[i].ToString());
                    loadFigures.Add( _deserialazers[jFigure[0].ToString()].Deserialaze(jFigure[1].ToString()));
                }
                //AbstractFigure square = JsonConvert.DeserializeObject<SquareFigure>(jArray[0].ToString());
                //loadFigures = JsonSerializer.Deserialize<List<AbstractFigure>>(json);
                //File.WriteAllText(openFileDialog.FileName, json);
            }
            return loadFigures;
        }
    }
}
