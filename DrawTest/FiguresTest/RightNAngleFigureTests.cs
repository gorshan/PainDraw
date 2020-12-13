using Draw.Figures;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawTest.FiguresTest
{
    public class RightNAngleFigureTests
    {
        [Test, TestCaseSource(typeof(RightNAnglePointsMock))]
        public void RightNAngleGetPointsTest(AbstractFigure figure, PointF startPoint, PointF endPoint, PointF[] expected)
        {
            figure.Update(startPoint, endPoint);
            PointF[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }
    }
    public class RightNAnglePointsMock: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new RightNAngleFigure(6), new PointF(72, 53), new PointF(93, 80), new PointF[6] { new PointF(106, 53), new PointF(89, 83), new PointF(55, 83), new PointF(38, 53), new PointF(55, 23), new PointF(89, 23) } };
            yield return new object[] { new RightNAngleFigure(6), new PointF(203, 80), new PointF(228, 138), new PointF[6] { new PointF(266, 80), new PointF(235, 135), new PointF(171, 135), new PointF(140, 80), new PointF(171, 25), new PointF(235, 25) } };
            yield return new object[] { new RightNAngleFigure(5), new PointF(77, 51), new PointF(86, 84), new PointF[5] { new PointF(111, 51), new PointF(88, 84), new PointF(49, 71), new PointF(49, 31), new PointF(88, 18) } };
            yield return new object[] { new RightNAngleFigure(5), new PointF(62, 157), new PointF(83, 188), new PointF[5] { new PointF(99, 157), new PointF(74, 193), new PointF(32, 179), new PointF(32, 135), new PointF(74, 121) } };
        }
    }
}
