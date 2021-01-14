using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_SysMap.Models
{
    public class Numbers
    {
        public int sum(int[] numbers)
        {
            Number number = new Number();
            int s = 0;

            foreach (var item in numbers)
            {
                s = number.sum(item, s);
            }
            return s;
        }

        public float avarage(int[] numbers)
        {
            return new Number().divide(sum(numbers), numbers.Length);
        }
    }
}
