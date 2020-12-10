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
        public void GetPointsSquareTest(AbstractFigure figure, PointF startPoint, PointF endPoint, PointF[] expected)
        {
            figure.Update(startPoint, endPoint);
            PointF[] actual = figure.GetPoints();
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(SquareFigureIsThisMock))]
        public void IsThisFigureSquareTest(AbstractFigure figure, PointF touchPoint, bool expected)
        {
            bool actual = figure.IsThisFigure(touchPoint);
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(SquareFigureMoveMock))]
        public void MoveFigureSquareTest(AbstractFigure figure, PointF delta, PointF[] expected)
        {
            figure.Move(delta);

            PointF[] actual = figure.GetPoints();

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(SquareFigureMoveFaceMock))]
        public void MoveFaceSquareTest(AbstractFigure figure, PointF touchPoint, PointF delta, PointF[] expected)
        {
            figure.IsThisFigure(touchPoint);
            figure.MoveFace(delta);

            PointF[] actual = figure.GetPoints();

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(SquareFigureIsThisVertexMock))]
        public void IsThisVertexSquareTest(AbstractFigure figure, PointF touchPoint, bool expected)
        {
            bool actual = figure.IsThisVertex(touchPoint);

            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(SquareFigureMoveVertexMock))]
        public void MoveVertexSquareTest(AbstractFigure figure, PointF touchPoint, PointF delta, PointF[] expected)
        {
            figure.IsThisVertex(touchPoint);
            figure.MoveVertex(delta);

            PointF[] actual = figure.GetPoints();

            CollectionAssert.AreEqual(expected, actual);
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

    public class SquareFigureIsThisMock : IEnumerable
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

    public class SquareFigureMoveMock : IEnumerable
    {
        private AbstractFigure GetSquare1()
        {
            AbstractFigure figure = new SquareFigure();
            figure.Update(new PointF(0, 0), new PointF(10, 10));
            return figure;
        }

        public IEnumerator GetEnumerator()
        {
            yield return new object[] { GetSquare1(), new PointF(5, 0), new PointF[] { new PointF(5, 0), new PointF(5, 10), new PointF(15, 10), new PointF(15, 0) } }; 
            yield return new object[] { GetSquare1(), new PointF(0, 0), new PointF[] { new PointF(0, 0), new PointF(0, 10), new PointF(10, 10), new PointF(10, 0) } };
            yield return new object[] { GetSquare1(), new PointF(5, 10), new PointF[] { new PointF(5, 10), new PointF(5, 20), new PointF(15, 20), new PointF(15, 10) } };
            yield return new object[] { GetSquare1(), new PointF(-2, 3), new PointF[] { new PointF(-2, 3), new PointF(-2, 13), new PointF(8, 13), new PointF(8, 3) } };
        }

    }

    public class SquareFigureMoveFaceMock : IEnumerable
    {
        private AbstractFigure GetSquare1()
        {
            AbstractFigure figure = new SquareFigure();
            figure.Update(new PointF(0, 0), new PointF(10, 10));
            return figure;
        }

        public IEnumerator GetEnumerator()
        {
            yield return new object[] { GetSquare1(), new PointF(0,1), new PointF(5, 1), new PointF[] { new PointF(5, 1), new PointF(5, 11), new PointF(10, 10), new PointF(10, 0) } };
            yield return new object[] { GetSquare1(),new PointF(2,10), new PointF(2, 2), new PointF[] { new PointF(0, 0), new PointF(2, 12), new PointF(12, 12), new PointF(10, 0) } };
            yield return new object[] { GetSquare1(),new PointF(10,5), new PointF(7, 4), new PointF[] { new PointF(0, 0), new PointF(0, 10), new PointF(17, 14), new PointF(17, 4) } };
            yield return new object[] { GetSquare1(), new PointF(7, 0),new PointF(3,3), new PointF[] { new PointF(3, 3), new PointF(0, 10), new PointF(10, 10), new PointF(13, 3) } };
        }

    }

    public class SquareFigureIsThisVertexMock : IEnumerable
    {
        private AbstractFigure GetSquare1()
        {
            AbstractFigure figure = new SquareFigure();
            figure.Update(new PointF(0, 0), new PointF(10, 10));
            return figure;
        }

        public IEnumerator GetEnumerator()
        {
            yield return new object[] { GetSquare1(), new PointF(10, 0), true };
            yield return new object[] { GetSquare1(), new PointF(10, 10), true };
            yield return new object[] { GetSquare1(), new PointF(0, 10), true };
            yield return new object[] { GetSquare1(), new PointF(0, 0), true };
            yield return new object[] { GetSquare1(), new PointF(3, 0), true };
            yield return new object[] { GetSquare1(), new PointF(0, 3), true };
            yield return new object[] { GetSquare1(), new PointF(10, 11), true };
            yield return new object[] { GetSquare1(), new PointF(15, 10), false };
        }

    }

    public class SquareFigureMoveVertexMock : IEnumerable
    {
        private AbstractFigure GetSquare1()
        {
            AbstractFigure figure = new SquareFigure();
            figure.Update(new PointF(0, 0), new PointF(10, 10));
            return figure;
        }

        public IEnumerator GetEnumerator()
        {
            yield return new object[] { GetSquare1(), new PointF(0, 1), new PointF(5, 1), new PointF[] { new PointF(5, 1), new PointF(0, 10), new PointF(10, 10), new PointF(10, 0) } };
            yield return new object[] { GetSquare1(), new PointF(2, 10), new PointF(2, 2), new PointF[] { new PointF(0, 0), new PointF(2, 12), new PointF(10, 10), new PointF(10, 0) } };
            yield return new object[] { GetSquare1(), new PointF(10, 10), new PointF(7, 4), new PointF[] { new PointF(0, 0), new PointF(0, 10), new PointF(17, 14), new PointF(10, 0) } };
            yield return new object[] { GetSquare1(), new PointF(10, 0), new PointF(3, 3), new PointF[] { new PointF(0, 0), new PointF(0, 10), new PointF(10, 10), new PointF(13, 3) } };
        }

    }
}
