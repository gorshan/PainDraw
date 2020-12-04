using Draw.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NUnitTestProject1.FiguresTest
{
    public class SquarePointsMock : IEnumerable
    {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new SquareFigure(), new Point(0, 0), new Point(666, 666), new Point[4] { new Point(0, 0), new Point(0, 666), new Point(666, 666), new Point(666, 0) } };
                yield return new object[] { new SquareFigure(), new Point(100, 136), new Point(64, 172), new Point[4] { new Point(100, 136), new Point(100, 172), new Point(64, 172), new Point(64, 136) } };
                yield return new object[] { new SquareFigure(), new Point(333, 563), new Point(400, 496), new Point[4] { new Point(333, 563), new Point(333, 496), new Point(400, 496), new Point(400, 563) } };
                yield return new object[] { new SquareFigure(), new Point(387, 123), new Point(364, 100), new Point[4] { new Point(387, 123), new Point(387, 100), new Point(364, 100), new Point(364, 123) } };
            }
        
    }
}
