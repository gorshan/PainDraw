using Draw.Figures;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawTest.FiguresTest
{
   public class EllipseFigureTests
    {
        [Test, TestCaseSource(typeof(EllipseFigureMocks))]
        public void EllipseGetPointsTest(AbstractFigure figure, PointF startPoint, PointF endPoint, PointF[] expected)
        {
            figure.Update(startPoint, endPoint);
            PointF[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }
    }

    public class EllipseFigureMocks : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new EllipseFigure(), new PointF(104, 40), new PointF(214, 69), new PointF[4] { new PointF(104, 0), new PointF(40, 0), new PointF(110, 0), new PointF(29, 0) } };
            yield return new object[] { new EllipseFigure(), new PointF(54, 44), new PointF(77, 130), new PointF[4] { new PointF(54, 0), new PointF(44, 0), new PointF(23, 0), new PointF(86, 0) } };
            yield return new object[] { new EllipseFigure(), new PointF(179, 116), new PointF(239, 238), new PointF[4] { new PointF(179, 0), new PointF(116, 0), new PointF(60, 0), new PointF(122, 0) } };
            yield return new object[] { new EllipseFigure(), new PointF(362, 43), new PointF(493, 111), new PointF[4] { new PointF(362, 0), new PointF(43, 0), new PointF(131, 0), new PointF(68, 0) } };
        }
    }
}
