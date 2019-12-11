using System;
using Xunit;

namespace CSTree.UnitTests
{
    [Trait("BCL扩展方法", "System.DateTime")]
    public class BCLExtensions
    {
        [Fact(DisplayName = "转中文日期格式-成功测试")]
        public void ToChineseDateStringShouldSuccess()
        {
            var datetime = Convert.ToDateTime("2019-12-11 23:10:10");
            var expected = "2019年12月11日";
            Assert.True(datetime.ToChineseDateString() == expected);
        }
    }
}
