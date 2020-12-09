using Draw.Figures;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawTest.FiguresTest
{
    public class SquareFigureTests
    {
        [Test, TestCaseSource(typeof(SquarePointsMock))]
        public void SquareGetPointsTest(AbstractFigure figure, PointF startPoint, PointF endPoint, PointF[] expected)
        {
            figure.Update(startPoint, endPoint);
            PointF[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(SquareIsThisFigureMock))]
        public void SquareIsThisFigureTest(AbstractFigure figure, PointF touchPoint, bool expected)
        {
            bool actual = figure.IsThisFigure(touchPoint);
            Assert.AreEqual(expected, actual);
        }
    }
    public class SquarePointsMock : IEnumerable
    {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new SquareFigure(), new PointF(0, 0), new PointF(666, 666), new PointF[4] { new PointF(0, 0), new PointF(0, 666), new PointF(666, 666), new PointF(666, 0) } };
                yield return new object[] { new SquareFigure(), new PointF(100, 136), new PointF(64, 172), new PointF[4] { new PointF(100, 136), new PointF(100, 172), new PointF(64, 172), new PointF(64, 136) } };
                yield return new object[] { new SquareFigure(), new PointF(333, 563), new PointF(400, 496), new PointF[4] { new PointF(333, 563), new PointF(333, 496), new PointF(400, 496), new PointF(400, 563) } };
                yield return new object[] { new SquareFigure(), new PointF(387, 123), new PointF(364, 100), new PointF[4] { new PointF(387, 123), new PointF(387, 100), new PointF(364, 100), new PointF(364, 123) } };
            }
        
    }

    public class SquareIsThisFigureMock : IEnumerable
    {
        private AbstractFigure GetSquare1()
        {
            AbstractFigure figure = new SquareFigure();
            figure.Update(new PointF(0, 0), new PointF(10, 10));
            return figure;
        }

        private AbstractFigure GetFatSquare()
        {
            AbstractFigure figure = new SquareFigure();
            figure.Update(new PointF(0, 0), new PointF(10, 10));
            figure.Width = 3;
            return figure;
        }
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { GetSquare1(), new PointF(5, 0), true };
            yield return new object[] { GetSquare1(), new PointF(10, 0), true };
            yield return new object[] { GetFatSquare(), new PointF(1, 7), true };
            yield return new object[] { GetFatSquare(), new PointF(14, 1), false };
        }

    }
}
