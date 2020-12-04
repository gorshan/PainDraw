using Draw.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NUnitTestProject1.FiguresTest
{
    public class RightNAnglePointsMock: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new NAngleFigure(6), new Point(72, 53), new Point(93, 80), new Point[6] { new Point(106, 53), new Point(89, 83), new Point(55, 83), new Point(38, 53), new Point(55, 23), new Point(89, 23) } };
            yield return new object[] { new NAngleFigure(6), new Point(203, 80), new Point(228, 138), new Point[6] { new Point(266, 80), new Point(235, 135), new Point(171, 135), new Point(140, 80), new Point(171, 25), new Point(235, 25) } };
            yield return new object[] { new NAngleFigure(5), new Point(77, 51), new Point(86, 84), new Point[5] { new Point(111, 51), new Point(88, 84), new Point(49, 71), new Point(49, 31), new Point(88, 18) } };
            yield return new object[] { new NAngleFigure(5), new Point(62, 157), new Point(83, 188), new Point[5] { new Point(99, 157), new Point(74, 193), new Point(32, 179), new Point(32, 135), new Point(74, 121) } };
        }
    }
}
