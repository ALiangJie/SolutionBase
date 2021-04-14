using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class Program
    {
        static void Main1(string[] args)
        {
            //数据类型
            //1.值类型：直接存储数据
            //2.引用类型：存储数据的引用（内存地址）
            //3.方法执行在栈中，执行完毕清楚栈帧。
            //4.局部变量的值类型：声明在栈中，数据在栈中。
            //5.局部变量的引用类型：声明在栈中，数据在堆中，栈中存储数据的引用
            //6.区分修改的是栈的存储的引用，还是堆中的数据(看赋值号左边)

            int a;//存储在？栈中
            a = 1;//数据1存储在？栈中，值类型直接存储数据

            int[] arr;//存储在？栈中，指向数组的地址
            arr = new int[] { 1, 2 };//数组存储在？数组数据存储在堆中，arr为指向数组的地址

            string[] arr01 = new string[1];//hello在哪？堆中
            arr01[0] = "hello";
            arr01[0] = "hi";

            string name = "王";
            name = "孙";

            int a1 = 1;
            int[] a2 = new int[] { 1 };
            Fun1(a1);
            Fun2(a2);
            Console.WriteLine(a1);//?
            Console.WriteLine(a2[0]);//?
        }

        private static void Fun1(int a)
        {
            a = 2;
        }
        private static void Fun2(int[] a)
        {
            a = new int[] { 2 };
        }

        static void Main2()
        {
            //0000000001 | 0000000010 =》0000000011
            PrintPersonStyle(PersonStye.tall | PersonStye.rich);

            //数据类型转换
            //int ==>Enum
            PersonStye style01 = (PersonStye)2;

            PrintPersonStyle(style01);
            //PrintPersonStyle((PersonStye)2);

            //Enum ==>int
            int enumNumber = (int)(PersonStye.beauty | PersonStye.handsome);

            //string ==>Enum
            //"beauty"

            PersonStye style02 = (PersonStye)Enum.Parse(typeof(PersonStye), "beauty");

            //Enum ==>string
            string strEnum = PersonStye.handsome.ToString();
        }

        //枚举      类和对象
        private static void PrintPersonStyle(PersonStye style)
        {
            //包含
            if ((style & PersonStye.tall) == PersonStye.tall)
                Console.WriteLine("大个子");
            if ((style & PersonStye.rich)== PersonStye.rich)
                Console.WriteLine("富豪");
            if ((style &PersonStye.handsome) != 0)
                Console.WriteLine("英俊");
            if ((style & PersonStye.white)==PersonStye.white)
                Console.WriteLine("洁白");
            if ((style & PersonStye.beauty)!=0)
                Console.WriteLine("漂亮");

        }

        //类和对象
        static void Main3()
        {
            //声明Wife类型的引用
            Wife wife01;
            //指向Wife类型的对象(实例化Wife类型对象)
            wife01 = new Wife();
            wife01.SetName("零号");
            wife01.SetAge(18);


            Wife wife02 = wife01;
            //wife02 = new Wife();//?
            wife02.SetName("一号");


            Console.WriteLine(wife01.GetName());//?
            Console.WriteLine(wife01.GetAge());

            Wife wife03 = new Wife();
            wife03.Name = "二号";//执行属性Name的Set代码块
            wife03.Age = 19;

            Console.WriteLine(wife03.Name);//执行属性Name的Set代码块
            Console.WriteLine(wife03.Age);

            Wife wife04 = new Wife("三号", 19);

            Wife wife05 = new Wife("四号");


        }


        static void Main4()
        {
            Wife w01 = new Wife();
            w01.Name = "01";
            w01.Age = 35;

            Wife w02 = new Wife("02",30);

            Wife[] wifeArray = new Wife[5];
            wifeArray[0] = w01;
            wifeArray[1] = w02;
            wifeArray[2] = new Wife("03", 40);
            wifeArray[3] = new Wife("04", 20);
            wifeArray[4] = new Wife("05", 25);

            //练习1：查找年龄最小的老婆（返回Wife类型的引用）
            Wife min = GetWifeByMinimumAge(wifeArray);

        }

        //练习1：查找年龄最小的（返回Wife类型的引用）
        private static Wife GetWifeByMinimumAge(Wife[] wifes)
        {
            Wife minWife = wifes[0];
            for(int i = 1; i < wifes.Length; i++)
            {
                if (minWife.Age > wifes[i].Age)
                    minWife = wifes[i]; 
            }
            return minWife;
        }

        static void Main()
        {
            //每日一练
            User u1 = new User();
            //数组初始化 必须 指定大小
            //User[] userArray = new User[];
            //读写元素 必须通过 索引
            //userArray[]= user01;

            //StringBuilder
            /*
             * 用户集合类 UserList
             * {
             *      private User[] data = null; //真正存储用户的字段
             *      
             *      public UserList():this(8)
             *      { 
             *          //data = new User[8];
             *      }
             *      public UserList(int capacity)
             *      { 
             *          data = new User[capacity];
             *      }
             *      
             *      public void Add(User value)
             *      {
             *          data[?] = value;
             *          //如果容量不够？
             *          //扩容：开辟更大的数组    拷贝原始数据  替换引用
             *      }
             *      
             *      public  User GetElement(int index)
             *      {
             *          return data[index];
             *      }
             *      
             *      //插入功能  删除功能
             * }
             * 
             * 需求：   使用：
             * UserList list=new UserList(10);
             * list.Add(u1);
             * list.Add(u2);
             * list.Add(u3);    
             * list.Add(u4);
             * 
             * for(int i=0;i<list.Count;i++)
             * {
             *      User user=list.GetElement(i);
             *      user.PrintUser();
             * }
             */
            UserList list = new UserList(3);
            list.Add(u1);
            list.Add(new User());
            list.Add(new User());
            list.Add(new User());

            for (int i = 0; i < list.Count; i++)
            {
                User user = list.GetElement(i);
                user.PrintUser();
            }

            //c# 泛型 集合          List<数据类型>
            //User[]                  new User[];
            List<User> list02 = new List<User>();
            list02.Add(u1);
            list02.Add(new User());
            list02.Add(new User());
            //list02.Insert();
            //list02.RemoveAt();
            //list02.Remove();
            User u2 = list02[0];//根据索引获取元素
            //读取所有元素
            for (int i = 0; i < list02.Count; i++)
            {
                User u = list02[i];
            }

            //字典集合  根据？查找？
            Dictionary<string, User> dic = new Dictionary<string, User>();
            dic.Add("hi", new User("hi", "123"));
            User hiUser = dic["hi"];

            //
        }
    }
}
