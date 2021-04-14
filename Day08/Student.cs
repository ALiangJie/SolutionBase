using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    /// <summary>
    /// 学生类
    /// </summary>
    class Student :Person
    {
        //实例成员  静态成员
        
        //prop+TAB+TAB
        /// <summary>
        /// 成绩
        /// </summary>
        public int Score { get; set; }

        //每个对象都存储一份                 "杯子"
        public int InstanceCount { get; set; }

        //仅仅存储一份 所有对象共享       "饮水机"
        public static int StaticCount { get; set; }

        private Random random;

        //实例构造函数 作用：提供创建对象的方式，初始化类的实例数据成员
        public Student()
        {
            random = new Random();


            InstanceCount++;
            StaticCount++;
        }

        //静态构造函数作用：初始化类的静态数据成员。
        //执行时机：类加载时调用一次
        static Student()
        {
            //"非静态字段 要求 对象引用"==> 静态代码块，只能访问静态成员
            //InstanceCount++;
            StaticCount++;
        }

        public static void Fun1()
        {
            //Console.WriteLine(InstanceCount);
        }

        public void Fun2()
        {//实例代码块，可以访问实例成员，也可以访问静态成员
            Console.WriteLine(this.InstanceCount);
            Console.WriteLine(StaticCount);
        }
    }
}
