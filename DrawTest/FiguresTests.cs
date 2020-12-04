using NUnit.Framework;
using Draw.Figures;
using System.Drawing;
using NUnitTestProject1.FiguresTest;

namespace NUnitTestProject1
{
    public class FiguresTests
    {
     [Test, TestCaseSource(typeof(SquarePointsMock))]
        public void SquareGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point [] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(RectanglePointsMock))]
        public void RectangleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point [] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(RightTrianglePointsMock))]
        public void RightTriangleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(RightNAnglePointsMock))]
        public void RightNAngleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(IsoscelesTrianglePointsMock))]
        public void IsoscelesTriangleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(EllipsePointsMock))]
        public void EllipseGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(CirclePointsMock))]
        public void CircleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
           Assert.AreEqual(expected, actual);
        }

    }
}