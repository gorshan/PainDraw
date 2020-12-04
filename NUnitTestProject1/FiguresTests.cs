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
            Point[] actual = figure.GetPoints(startPoint, endPoint);
            Assert.AreEqual(expected, actual);
        }
        
        public void RectangleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point [] expected)
        {
            Point[] actual = figure.GetPoints(startPoint, endPoint);
            Assert.AreEqual(expected, actual);
        }

        public void RightTriangleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            Point[] actual = figure.GetPoints(startPoint, endPoint);
            Assert.AreEqual(expected, actual);
        }

        public void RightNAngleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            Point[] actual = figure.GetPoints(startPoint, endPoint);
            Assert.AreEqual(expected, actual);
        }

        public void IsoscelesTriangleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            Point[] actual = figure.GetPoints(startPoint, endPoint);
            Assert.AreEqual(expected, actual);
        }

        public void EllipseGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            Point[] actual = figure.GetPoints(startPoint, endPoint);
            Assert.AreEqual(expected, actual);
        }

        public void CircleGetPointsTest(IFigure figure, Point startPoint, Point endPoint, Point[] expected)
        {
            Point[] actual = figure.GetPoints(startPoint, endPoint);
            Assert.AreEqual(expected, actual);
        }

    }
}