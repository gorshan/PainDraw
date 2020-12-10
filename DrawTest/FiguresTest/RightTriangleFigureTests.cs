using Draw.Figures;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawTest.FiguresTest
{
    public class RightTriangleFigureTests
    {
        [Test, TestCaseSource(typeof(RightTrianglePointsMock))]
        public void RightTriangleGetPointsTest(AbstractFigure figure, PointF startPoint, PointF endPoint, PointF[] expected)
        {
            figure.Update(startPoint, endPoint);
            PointF[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }
    }
   public class RightTrianglePointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new RightTriangleFigure(), new PointF(28, 0), new PointF(38, 10), new PointF[3] { new PointF(28, 0), new PointF(28, 10), new PointF(38, 10) } };
            yield return new object[] { new RightTriangleFigure(), new PointF(64, 32), new PointF(54, 42), new PointF[3] { new PointF(64, 32), new PointF(64, 42), new PointF(54, 42) } };
            yield return new object[] { new RightTriangleFigure(), new PointF(15, 37), new PointF(25, 27), new PointF[3] { new PointF(15, 37), new PointF(15, 27), new PointF(25, 27) } };
            yield return new object[] { new RightTriangleFigure(), new PointF(121, 665), new PointF(21, 565), new PointF[3] { new PointF(121, 665), new PointF(121, 565), new PointF(21, 565) } };
        }
    }
}
