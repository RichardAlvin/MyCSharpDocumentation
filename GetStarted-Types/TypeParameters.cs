using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStarted_Types
{
    public class TypeParameters<TFirst,TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }

        public TypeParameters(TFirst first, TSecond second) =>
            (First, Second) = (first, second);
    }
}
