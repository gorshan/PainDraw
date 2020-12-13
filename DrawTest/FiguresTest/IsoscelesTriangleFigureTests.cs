using Draw.Figures;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawTest.FiguresTest
{
    public class IsoscelesTriangleFigureTests
    {
        [Test, TestCaseSource(typeof(IsoscelesTrianglePointsMock))]
        public void IsoscelesTriangleGetPointsTest(AbstractFigure figure, PointF startPoint, PointF endPoint, PointF[] expected)
        {
            figure.Update(startPoint, endPoint);
            PointF[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }
    }
   public class IsoscelesTrianglePointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new IsoscelesTriangleFigure(), new PointF(128, 420), new PointF(228, 727), new PointF[3] { new PointF(128, 420), new PointF(28, 727), new PointF(228, 727) } };
            yield return new object[] { new IsoscelesTriangleFigure(), new PointF(36, 48), new PointF(11, 81), new PointF[3] { new PointF(36, 48), new PointF(61, 81), new PointF(11, 81) } };
            yield return new object[] { new IsoscelesTriangleFigure(), new PointF(42, 94), new PointF(27, 56), new PointF[3] { new PointF(42, 94), new PointF(57, 56), new PointF(27, 56) } };
            yield return new object[] { new IsoscelesTriangleFigure(), new PointF(18, 33), new PointF(21, 14), new PointF[3] { new PointF(18, 33), new PointF(15, 14), new PointF(21, 14) } };
        }
    }
}
