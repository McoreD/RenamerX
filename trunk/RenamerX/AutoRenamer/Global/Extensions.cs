using System;

namespace RenamerX
{
    public static class Extensions
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}