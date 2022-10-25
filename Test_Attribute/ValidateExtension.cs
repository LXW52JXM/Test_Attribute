using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Attribute
{
    /// <summary>
    /// 扩展方法
    /// 当我们需要给一个类增加方法，但又不希望修改这些类，
    /// 也不希望创建这些类的子类，可以采用扩展方法。扩展方法使你能够向现有类型“添加”方法，
    /// 而无需创建新的派生类型、重新编译或以其他方式修改原始类型。
    /// 扩展方法是一种特殊的静态方法，但可以像扩展类型上的实例方法一样进行调用
    /// </summary>
    public static class ValidateExtension
    {
        public static bool Validate(this object obj) 
        {
            //反射获取类型信息
            Type type = obj.GetType();
            //获取类型所有的公共属性
            foreach (var item in type.GetProperties())
            {
                //获取属性的特性
                object[] attr = item.GetCustomAttributes(typeof(AbstractValidateAttribute), true);
                foreach (AbstractValidateAttribute ab in attr)
                {
                    if (!ab.Validate(item.GetValue(obj)))
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }
    }
}
