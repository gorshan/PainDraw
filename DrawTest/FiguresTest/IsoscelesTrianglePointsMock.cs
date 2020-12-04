using Draw.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NUnitTestProject1.FiguresTest
{
   public class IsoscelesTrianglePointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new IsoscelesTriangleFigure(), new Point(128, 420), new Point(228, 727), new Point[3] { new Point(128, 420), new Point(28, 727), new Point(228, 727) } };
            yield return new object[] { new IsoscelesTriangleFigure(), new Point(36, 48), new Point(11, 81), new Point[3] { new Point(36, 48), new Point(61, 81), new Point(11, 81) } };
            yield return new object[] { new IsoscelesTriangleFigure(), new Point(42, 94), new Point(27, 56), new Point[3] { new Point(42, 94), new Point(57, 56), new Point(27, 56) } };
            yield return new object[] { new IsoscelesTriangleFigure(), new Point(18, 33), new Point(21, 14), new Point[3] { new Point(18, 33), new Point(15, 14), new Point(21, 14) } };
        }
    }
}
