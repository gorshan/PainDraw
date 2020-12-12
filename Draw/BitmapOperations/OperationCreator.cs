using Draw.BitmapOperations.OperationParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.BitmapOperations
{
    public class OperationCreator
    {
        private Dictionary<Type, IBitmapOperation> _operations = new Dictionary<Type, IBitmapOperation>() {
            {typeof(SizeOperationParameter), new ResizeBitmapOperation() },
            {typeof(ClearOperationParameters), new ClearBitmapOperation() },
            {typeof(CancelLastActionParameter), new CancelLastActionOperation() },
            {typeof(SaveBitmapOperationParameters), new SaveBitmapOperation() },
            {typeof(ChangeBackgroundColorOperationParameters), new ChangeBackgroundColorOperation() }
        };

        public IBitmapOperation GetOperation(Type type)
        {
            return _operations[type];
        }
    }
}
