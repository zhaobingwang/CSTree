using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace CSTree.BCLExtensions
{
    public static class EnumsExtensions
    {
        /// <summary>
        /// 将枚举值转为string
        /// </summary>
        /// <param name="source">枚举源</param>
        /// <returns></returns>
        public static string ToStringValue(this Enum source)
        {
            return Convert.ChangeType(source, typeof(int)).ToString();
        }

        /// <summary>
        /// 将枚举值转为int32
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int ToInt32Value(this Enum source)
        {
            return (int)Convert.ChangeType(source, typeof(int));
        }

        /// <summary>
        /// 获取特性 (DisplayAttribute) 的名称
        /// 如果未使用该特性，则返回枚举的名称
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum source)
        {
            FieldInfo fieldInfo = source.GetType().GetField(source.ToString());
            DisplayAttribute[] attrs =
                fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

            return attrs.Length > 0 ? attrs[0].Name : source.ToString();
        }

        /// <summary>
        /// 获取特性(DisplayAttribute)的描述
        /// 如果未使用该特性，则返回枚举的名称
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetDisplayDescription(this Enum source)
        {
            FieldInfo fieldInfo = source.GetType().GetField(source.ToString());
            DisplayAttribute[] attrs =
                fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

            return attrs.Length > 0 ? attrs[0].Description : source.ToString();
        }

        /// <summary>
        /// 获取特性 (DescriptionAttribute)的说明
        /// 如果未使用该特性，则返回枚举的名称。
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum source)
        {
            FieldInfo fieldInfo = source.GetType().GetField(source.ToString());
            DescriptionAttribute[] attrs =
                fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attrs.Length > 0 ? attrs[0].Description : source.ToString();
        }

        /// <summary>
        /// 获取特性
        /// 不存在返回null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T GetCustomAttributes<T>(this Enum source) where T : Attribute
        {
            Type type = source.GetType();
            MemberInfo[] memInfo = type.GetMember(source.ToString());
            object[] attributes = memInfo[0].GetCustomAttributes(typeof(T), false);

            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
    }

}
