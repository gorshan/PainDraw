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
            yield return new object[] { new NAngleFigure(), new Point(300, 80), new Point(275, 37), new Point[6] { new Point(300, 80), new Point(275, 123), new Point(225, 123), new Point(200, 80), new Point(225, 37), new Point(275, 37) } };
            yield return new object[] { new NAngleFigure(), new Point(100, 136), new Point(64, 172), new Point[6] { new Point(0, 0), new Point(0, 0), new Point(100, 136), new Point(64, 136), new Point(64, 172), new Point(100, 172) } };
            yield return new object[] { new NAngleFigure(), new Point(333, 563), new Point(400, 496), new Point[5] { new Point(0, 0), new Point(333, 563), new Point(333, 496), new Point(400, 496), new Point(400, 563) } };
            yield return new object[] { new NAngleFigure(), new Point(387, 123), new Point(364, 100), new Point[5] { new Point(0, 0), new Point(387, 123), new Point(387, 100), new Point(364, 100), new Point(364, 123) } };
        }
    }
}
