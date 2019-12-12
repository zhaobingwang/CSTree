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

            DateTime? nullDateTime1 = null;
            DateTime? nullDateTime2 = datetime;

            Assert.True(datetime.ToChineseDateString() == expected);
            Assert.True(nullDateTime1.ToChineseDateString() == string.Empty);
            Assert.True(nullDateTime2.ToChineseDateString() == expected);
        }

        [Fact(DisplayName = "转中文日期时间格式-成功测试")]
        public void ToChineseDateTimeStringShouldSuccess()
        {
            var datetime = Convert.ToDateTime("2019-12-11 23:10:10");
            var expected = "2019年12月11日23时10分10秒";

            DateTime? nullDateTime1 = null;
            DateTime? nullDateTime2 = datetime;

            Assert.True(datetime.ToChineseDateTimeString() == expected);
            Assert.True(nullDateTime1.ToChineseDateTimeString() == string.Empty);
            Assert.True(nullDateTime2.ToChineseDateTimeString() == expected);
        }

        [Fact(DisplayName = "转为yyyy-MM-dd日期格式-成功测试")]
        public void ToDateStringShouldSuccess()
        {
            var datetime = Convert.ToDateTime("2019-12-11 23:10:10");
            var expected = "2019-12-11";

            DateTime? nullDateTime1 = null;
            DateTime? nullDateTime2 = datetime;

            Assert.True(datetime.ToDateString() == expected);
            Assert.True(nullDateTime1.ToDateString() == string.Empty);
            Assert.True(nullDateTime2.ToDateString() == expected);
        }

        [Theory(DisplayName = "转为友好的时间信息-成功测试")]
        [InlineData("刚刚", 0)]
        [InlineData("刚刚", 59)]
        [InlineData("1分钟前", 60)]
        [InlineData("1分钟前", 119)]
        [InlineData("2分钟前", 60 * 2)]
        [InlineData("2分钟前", 60 * 2 + 59)]
        [InlineData("1小时前", 60 * 60)]
        [InlineData("1小时前", 60 * 60 * 2 - 1)]
        [InlineData("2小时前", 60 * 60 * 2)]
        [InlineData("2小时前", 60 * 60 * 3 - 1)]
        [InlineData("3小时前", 60 * 60 * 3)]
        [InlineData("3小时前", 60 * 60 * 4 - 1)]
        [InlineData("昨天", 60 * 60 * 24)]
        [InlineData("1天前", 60 * 60 * 24 + 1)]
        [InlineData("1天前", 60 * 60 * 24 * 2 - 1)]
        [InlineData("2天前", 60 * 60 * 24 * 2)]
        [InlineData("6天前", 60 * 60 * 24 * 6)]
        [InlineData("6天前", 60 * 60 * 24 * 7 - 1)]
        [InlineData("上周", 60 * 60 * 24 * 7)]
        [InlineData("上周", 60 * 60 * 24 * 14 - 1)]
        [InlineData("2周前", 60 * 60 * 24 * 14)]
        [InlineData("2周前", 60 * 60 * 24 * 21 - 1)]
        [InlineData("3周前", 60 * 60 * 24 * 21)]
        [InlineData("3周前", 60 * 60 * 24 * 28 - 1)]
        [InlineData("上个月前", 60 * 60 * 24 * 28)]
        [InlineData("上个月前", 60 * 60 * 24 * 60 - 1)]
        [InlineData("2个月前", 60 * 60 * 24 * 60)]
        [InlineData("2个月前", 60 * 60 * 24 * 90 - 1)]
        [InlineData("3个月前", 60 * 60 * 24 * 90)]
        [InlineData("3个月前", 60 * 60 * 24 * 120 - 1)]
        [InlineData("12个月前", 60 * 60 * 24 * 365 - 1)]
        [InlineData("去年", 60 * 60 * 24 * 365)]
        [InlineData("去年", 60 * 60 * 24 * 730 - 1)]
        [InlineData("2年前", 60 * 60 * 24 * 365 * 2)]
        [InlineData("2年前", 60 * 60 * 24 * 365 * 3 - 1)]
        [InlineData("3年前", 60 * 60 * 24 * 365 * 3)]
        public void ToFriendlyDateStringShouldSuccess(string friendlyInfo, int beSubtractSeconds)
        {
            var publishTime = new DateTime(2019, 12, 12, 18, 30, 0);
            var now = new DateTime(2019, 12, 12, 18, 30, 0);

            Assert.True(publishTime.AddSeconds(-1 * beSubtractSeconds).ToFriendlyDateString(now) == friendlyInfo);
        }
    }
}
