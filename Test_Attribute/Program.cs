using System;

namespace Test_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.QQ = 123456;
            student.Accont = "hhhhhhhh";
            Console.WriteLine(student.Accont+student.QQ);
            //调用扩展方法，通过反射验证特性
            student.Validate();
        }
    }
}
