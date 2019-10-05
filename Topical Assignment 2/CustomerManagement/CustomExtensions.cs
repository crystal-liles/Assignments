using System;
using System.Collections.Generic;
using System.Text;

/*
 * Crystal Liles
 */

namespace CustomerManagement
{
    static class CustomExtensions
    {
        public static bool IsNullOrEmpty(this string content)
        {
            return string.IsNullOrEmpty(content);
        }
        public static bool IsNullOrWhiteSpace(this string content)
        {
            return string.IsNullOrWhiteSpace(content);
        }
    }
}
