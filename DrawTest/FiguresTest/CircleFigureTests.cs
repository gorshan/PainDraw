using Draw.Figures;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawTest.FiguresTest
{
   public class CircleFigureTests
    {
        [Test, TestCaseSource(typeof(CircleFigureMocks))]
        public void CircleGetPointsTest(AbstractFigure figure, PointF startPoint, PointF endPoint, PointF[] expected)
        {
            figure.Update(startPoint, endPoint);
            PointF[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }
    }

    public class CircleFigureMocks : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new CircleFigure(), new PointF(1, 1), new PointF(1, 11), new PointF[4] { new PointF(-9, 0), new PointF(-9, 0), new PointF(20, 0), new PointF(20, 0) } };
            yield return new object[] { new CircleFigure(), new PointF(0, 0), new PointF(1, 0), new PointF[4] { new PointF(-1, 0), new PointF(-1, 0), new PointF(2, 0), new PointF(2, 0) } };
            yield return new object[] { new CircleFigure(), new PointF(5, 5), new PointF(9, 8), new PointF[4] { new PointF(0, 0), new PointF(0, 0), new PointF(10, 0), new PointF(10, 0) } };
            yield return new object[] { new CircleFigure(), new PointF(20, 20), new PointF(30, 20), new PointF[4] { new PointF(10, 0), new PointF(10, 0), new PointF(20, 0), new PointF(20, 0) } };
        }
    }
}
