using Draw.Figures;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawTest.FiguresTest
{
    public class RectangleFigureTests
    {
        [Test, TestCaseSource(typeof(RectanglePointsMock))]
        public void RectangleGetPointsTest(AbstractFigure figure, PointF startPoint, PointF endPoint, PointF[] expected)
        {
            figure.Update(startPoint, endPoint);
            PointF[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }
    }
    public class RectanglePointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new RectangleFigure(), new PointF(315, 147), new PointF(335, 157), new PointF[4] { new PointF(315, 147), new PointF(315, 157), new PointF(335, 157), new PointF(335, 147) } };
            yield return new object[] { new RectangleFigure(), new PointF(666, 66), new PointF(646, 76), new PointF[4] { new PointF(666, 66), new PointF(666, 76), new PointF(646, 76), new PointF(646, 66) } };
            yield return new object[] { new RectangleFigure(), new PointF(218, 111), new PointF(238, 101), new PointF[4] { new PointF(218, 111), new PointF(218, 101), new PointF(238, 101), new PointF(238, 111) } };
            yield return new object[] { new RectangleFigure(), new PointF(32, 48), new PointF(12, 38), new PointF[4] { new PointF(32, 48), new PointF(32, 38), new PointF(12, 38), new PointF(12, 48) } };
        }
    }
}
