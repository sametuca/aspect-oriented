using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOriented.Core
{
    public interface ICalculator
    {
        public int Add(int a, int b);
        public int Multiply(int a, int b);
    }
}
