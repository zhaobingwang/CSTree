using System;
using System.Collections.Generic;
using System.Text;

namespace CSTree
{
    /// <summary>
    /// BCL扩展 - 日期时间
    /// </summary>
    public static partial class BCLExtensions
    {
        public static string ToChineseDateString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy年MM月dd日");
        }
    }
}
