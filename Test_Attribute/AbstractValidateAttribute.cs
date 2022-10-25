using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Attribute
{
    /// <summary>
    /// 抽象类(特性)
    /// </summary>
    public abstract class AbstractValidateAttribute:Attribute
    {
        /// <summary>
        /// 验证抽象方法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract bool Validate(object value);
    }
}
