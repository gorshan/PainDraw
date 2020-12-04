using Draw.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NUnitTestProject1.FiguresTest
{
   public class EllipsePointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new EllipseFigure(), new Point(104, 40), new Point(214, 69), new Point[4] { new Point(104, 0), new Point(40, 0), new Point(110, 0), new Point(29, 0) } };
            yield return new object[] { new EllipseFigure(), new Point(54, 44), new Point(77, 130), new Point[4] { new Point(54, 0), new Point(44, 0), new Point(23, 0), new Point(86, 0) } };
            yield return new object[] { new EllipseFigure(), new Point(179, 116), new Point(239, 238), new Point[4] { new Point(179, 0), new Point(116, 0), new Point(60, 0), new Point(122, 0) } };
            yield return new object[] { new EllipseFigure(), new Point(362, 43), new Point(493, 111), new Point[4] { new Point(362, 0), new Point(43, 0), new Point(131, 0), new Point(68, 0) } };
        }
    }
}
