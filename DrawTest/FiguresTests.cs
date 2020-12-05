using NUnit.Framework;
using Draw.Figures;
using System.Drawing;
using NUnitTestProject1.FiguresTest;

namespace NUnitTestProject1
{
    public class FiguresTests
    {
     [Test, TestCaseSource(typeof(SquarePointsMock))]
        public void SquareGetPointsTest(AbstractFigure figure, Point startPoint, Point endPoint, Point [] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(RectanglePointsMock))]
        public void RectangleGetPointsTest(AbstractFigure figure, Point startPoint, Point endPoint, Point [] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(RightTrianglePointsMock))]
        public void RightTriangleGetPointsTest(AbstractFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(RightNAnglePointsMock))]
        public void RightNAngleGetPointsTest(AbstractFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(IsoscelesTrianglePointsMock))]
        public void IsoscelesTriangleGetPointsTest(AbstractFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(EllipsePointsMock))]
        public void EllipseGetPointsTest(AbstractFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(CirclePointsMock))]
        public void CircleGetPointsTest(AbstractFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            figure.Update(startPoint, endPoint);
            Point[] actual = figure.GetPoints();
           Assert.AreEqual(expected, actual);
        }

    }
}