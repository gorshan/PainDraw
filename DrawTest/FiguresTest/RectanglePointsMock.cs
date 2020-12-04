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

            yield return new object[] { new RectangleFigure(), new Point(315, 147), new Point(335, 157), new Point[4] { new Point(315, 147), new Point(315, 157), new Point(335, 157), new Point(335, 147) } };
            yield return new object[] { new RectangleFigure(), new Point(666, 66), new Point(646, 76), new Point[4] { new Point(666, 66), new Point(666, 76), new Point(646, 76), new Point(646, 66) } };
            yield return new object[] { new RectangleFigure(), new Point(218, 111), new Point(238, 101), new Point[4] { new Point(218, 111), new Point(218, 101), new Point(238, 101), new Point(238, 111) } };
            yield return new object[] { new RectangleFigure(), new Point(32, 48), new Point(12, 38), new Point[4] { new Point(32, 48), new Point(32, 38), new Point(12, 38), new Point(12, 48) } };
        }
    }
}
