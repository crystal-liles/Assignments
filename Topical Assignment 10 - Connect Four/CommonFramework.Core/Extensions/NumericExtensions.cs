using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * Crystal Liles
 */

namespace CommonFramework.Core
{
    public static class NumericExtensions
    {
        public static int ToInt(this string content)
        {
            try
            {
                if (content == null) return 0;

                int result;
                if (int.TryParse(content, out result)) return result;

                return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}
