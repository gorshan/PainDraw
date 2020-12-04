using Draw.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NUnitTestProject1.FiguresTest
{
    public class RectanglePointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new RectangleFigure(), new Point(0, 0), new Point(666, 666), new Point[4] { new Point(0, 0), new Point(0, 666), new Point(666, 666), new Point(666, 0) } };
            yield return new object[] { new RectangleFigure(), new Point(139, 216), new Point(555, 32), new Point[4] { new Point(139, 216), new Point(139, 32), new Point(323, 32), new Point(323, 216) } };
            yield return new object[] { new RectangleFigure(), new Point(28, 111), new Point(69, 218), new Point[4] { new Point(28, 111), new Point(28, 218), new Point(135, 218), new Point(135, 111) } };
            yield return new object[] { new RectangleFigure(), new Point(35, 35), new Point(100, 100), new Point[4] { new Point(35, 35), new Point(35, 100), new Point(100, 100), new Point(100, 35) } };
        }
    }
}
