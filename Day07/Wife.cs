using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    /// <summary>
    /// 定义老婆类
    /// </summary>
    class Wife
    {
        //数据成员
        //字段：存储数据   老板
        private string name;

        //属性：保护字段  本质就是两个方法     助理
        public string Name
        {
            //读取时保护
            get
            { return name; }
            //写入时保护  value要设置的数据
            set
            { this.name = value; }
        }

        private string sex;

        public int age;

        public int Age
        {
            get
            { return this.age; }

            set
            {
                if (value <= 40& value >= 18)
                    this.age = value;
                else
                    throw new Exception("错误");
             }

        }

        //构造函数:提供了创建对象的方式，常常用于初始化类的数据成员。
        //一个类若没有构造函数，那么编译器会自动提供一个无参数构造函数
        //一个类若具有构造函数，那么编译器不会提供一个无参数构造函数
        //本质：方法
        //特点：没有返回值  与类同名   创建对象时自动调用（不能手动调用）
        //private Wife()//如果不希望在类的外部被创建对象，就将构造函数私有化
        //{     }


        public Wife()
        {
            Console.WriteLine("创建对象就执行");

        }
        public Wife(string name):this()
        {
            //Wife();//调用无参数构造函数
            this.name = name;
        }
        public Wife(string name,int age):this(name)
        {
            //Wife(name);
            //this.name = name;//构造函数如果为字段赋值，属性中的代码块不会执行
            this.Age = age;
        }

        //int a;
        //方法成员
        public void SetName(string name)
        {
            //this 这个对象(引用)
            this.name = name;

            //int a = 1;
            //Console.WriteLine(a);//就近
            //Console.WriteLine(this.a);

        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
    }
}
