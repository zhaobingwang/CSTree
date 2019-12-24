using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CSTree.BCLExtensions;
using Xunit;

namespace CSTree.UnitTests.BCLExtensions
{
    [Trait("BCL扩展方法", "enum扩展")]
    public class EnumsExtensionsTest
    {
        [Fact(DisplayName = "将value转为string")]
        public void ToStringValueShouldSuccess()
        {
            var stringVal1 = Order.ASC.ToStringValue();
            var stringVal2 = Order.DESC.ToStringValue();

            Assert.True(stringVal1 == "1");
            Assert.True(stringVal2 == "2");
        }

        [Fact(DisplayName = "将value转为int32")]
        public void ToInt32ValueShouldSuccess()
        {
            var int32Val1 = Order.ASC.ToInt32Value();
            var int32Val2 = Order.DESC.ToInt32Value();

            Assert.True(int32Val1 == 1);
            Assert.True(int32Val2 == 2);
        }

        [Fact(DisplayName = "获取枚举的特性(DisplayAttribute)的名称")]
        public void GetDisplayNameShouldSuccess()
        {
            Assert.True(Order.ASC.GetDisplayName() == "升序");
        }

        [Fact(DisplayName = "获取特性(DisplayAttribute)的描述")]
        public void GetDisplayDescriptionShouldSuccess()
        {
            Assert.True(Order.ASC.GetDisplayDescription() == "按照升序排序");
        }

        [Fact(DisplayName = "获取特性(DescriptionAttribute)的说明")]
        public void GetGetDescriptionShouldSuccess()
        {
            Assert.True(Order.ASC.GetDescription() == "asc");
        }

        [Fact(DisplayName = "获取特性")]
        public void GetCustomAttributesShouldSuccess()
        {
            Assert.True(Order.ASC.GetCustomAttributes<TestAttribute>().DisplayName == "测试");
            Assert.True(Order.ASC.GetCustomAttributes<ReadOnlyAttribute>() == null);
        }

        enum Order
        {
            /// <summary>
            /// 升序
            /// </summary>
            [Description("asc")]
            [Display(Name = "升序", Description = "按照升序排序")]
            [Test(DisplayName = "测试")]
            ASC = 1,
            DESC = 2
        }
        class TestAttribute : System.Attribute
        {
            public string DisplayName { get; set; }
        }
    }


}
