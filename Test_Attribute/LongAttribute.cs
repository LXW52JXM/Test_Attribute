using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Attribute
{
    /// <summary>
    /// 这是一个自定义特性，间接继承Attribute
    /// 验证类，继承抽象类
    /// </summary>
    public class LongAttribute : AbstractValidateAttribute
    {
        private long MAX = 0;
        private long MIN = 0;
        public LongAttribute(long min,long max)
        {
            MAX = max;
            MIN = min;
        }
        //重写抽象方法
        public override bool Validate(object value)
        {
            if (value!=null&&string.IsNullOrWhiteSpace(value.ToString()))
            {
                if (long.TryParse(value.ToString(),out long Iresult))
                {
                    if (Iresult>this.MIN&&Iresult<MAX)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
