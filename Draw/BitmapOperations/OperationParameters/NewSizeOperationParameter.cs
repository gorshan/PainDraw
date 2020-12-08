using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.BitmapOperations.OperationParameters

{
    public class NewSizeOperationParameter : IOperationParameters
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
