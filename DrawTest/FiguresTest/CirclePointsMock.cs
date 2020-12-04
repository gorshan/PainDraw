using Draw.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NUnitTestProject1.FiguresTest
{
   public class CirclePointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new CircleFigure(), new Point(53, 32), new Point(61, 55), new Point[4] { new Point(29, 0), new Point(8, 0), new Point(48, 0), new Point(48, 0) } };
            yield return new object[] { new CircleFigure(), new Point(122, 25), new Point(125, 43), new Point[4] { new Point(104, 0), new Point(7, 0), new Point(36, 0), new Point(36, 0) } };
            yield return new object[] { new CircleFigure(), new Point(115, 106), new Point(126, 145), new Point[4] { new Point(75,0), new Point(66, 0), new Point(80, 0), new Point(80, 0) } };
            yield return new object[] { new CircleFigure(), new Point(265, 73), new Point(267, 39), new Point[4] { new Point(231, 0), new Point(39, 0), new Point(68, 0), new Point(68, 0) } };
        }
    }
}
