using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo02
{
    public class NaturalNumbersCalculator
    {
        internal object Substract(int v1, int v2)
        {
            //if (v2 > v1)
            //    return 0;

            //return v1 - v2;

            // Replace above logic in 1 line
            return (v2 > v1) ? 0 : v1 - v2;
        }
    }
}
