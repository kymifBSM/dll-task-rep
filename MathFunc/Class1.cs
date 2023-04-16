using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunc
{
    public class Class1
    {
        public static void SumProductFunc(double[] nums, out double sum, out double product)
        {
            sum = 0;
            product = 1;

            foreach (double num in nums)
            {
                sum += num;
                product *= num;
            }
        }
    }
}
