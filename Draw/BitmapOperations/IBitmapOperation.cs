using Draw.BitmapOperations.OperationParameters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.BitmapOperations
{
    public interface IBitmapOperation
    {
        Bitmap Action(IOperationParameters operationParameters);
    }
}
