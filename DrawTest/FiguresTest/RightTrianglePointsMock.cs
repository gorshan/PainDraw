using Draw.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NUnitTestProject1.FiguresTest
{
   public class RightTrianglePointsMock : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new RightTriangleFigure(), new Point(28, 0), new Point(38, 10), new Point[3] { new Point(28, 0), new Point(28, 10), new Point(38, 10) } };
            yield return new object[] { new RightTriangleFigure(), new Point(64, 32), new Point(54, 42), new Point[3] { new Point(64, 32), new Point(64, 42), new Point(54, 42) } };
            yield return new object[] { new RightTriangleFigure(), new Point(15, 37), new Point(25, 27), new Point[3] { new Point(15, 37), new Point(15, 27), new Point(25, 27) } };
            yield return new object[] { new RightTriangleFigure(), new Point(121, 665), new Point(21, 565), new Point[3] { new Point(121, 665), new Point(121, 565), new Point(21, 565) } };
        }
    }
}
