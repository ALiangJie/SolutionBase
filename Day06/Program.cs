using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class Program
    {
        static void Main1(string[] args)
        {
            //[行,列]
            int[,] arr = null;
            arr = new int[5, 3];

            arr[0, 2] = 100;
            arr.GetLength(0);

            //参数数组 参数类型         数据类型
            //交错数组：每个元素都为一维数组，分布通常想象为“不规则表格”
            //创建具有4个元素的交错数组
            int[][] array02 = new int[4][];
            //创建一维数组  赋值给  交错数组的第一个元素
            array02[0] = new int[3];
            array02[1] = new int[2];
            array02[2] = new int[5];
            array02[3] = new int[5];
            //将数组1赋值给交错数组的的第一个元素的第一个元素
            array02[0][0] = 1;
            array02[1][0] = 2;

            //数据类型  变量名
            //int a;
            //int[] arr;

            //array02.Length 交错数组元素数（理解为：行数）
            for (int r = 0; r < array02.Length; r++)
            {
                for(int c = 0; c < array02[r].Length; c++)
                {
                    Console.Write(array02[r][c]+"\t");
                }
                Console.WriteLine();
            }
            //foreach (int[] array in array02)
            //{
            //    foreach (int element in array)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}


            //练习：学生缺考
        }

        static void Main2()
        {
            int result01 = Add(new int[] { 12, 32, 42, 54 });
            int result02 = Add(12, 32, 42, 54);

            int result03 = Add();//Add(new int[0]);

           // Console.WriteLine("{0}{1}{2}", new object[] { 12, 32, 54 ,32});
            Console.WriteLine("{0}{1}{2}", new object[] { 12, 32, 54, 32 });
        }

        //整数相加的方法
        //当类型确定  个数不确定的情形
        //params 参数数组
        //对于方法内部而言：就是个普通数组
        //对于方法外部（调用者）而言：
             //可以传递数组
             //传递一组数据类型相同的变量集合
             //可以不传递参数
        //作用：简化调用者调用方法的代码

        
        private static int Add(params int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        //数据类型
        static void Main3()
        {
            //值类型                       引用类型
            //int bool char             string int[](Array)
            //1.因为方法执行在栈中，所以在方法中声明的变量都在栈中
            //2.又因为值类型直接存储数据，所以数据储存在栈中
            //3.又因为引用类型存储数据的引用，所以数据在堆中，栈中储存数据的内存地址。


            //a在栈中  1在栈中
            int a = 1;
            int b = a;
            a = 2;
            Console.WriteLine(b);//?

            //arr在栈中存储数组对象的引用(内存地址)  1在堆中
            int[] arr = new int[] { 1 };
            int[] arr2 = arr;
            //arr[0] = 2; //修改的是堆中的数据
            arr = new int[] { 2 };//修改的是栈中存储的引用
            Console.WriteLine(arr2[0]);//?

            string s1 = "男";
            string s2 = s1;
            s1 = "女";
           // s1[0] = "女";//堆中的文字    不能修改
            Console.WriteLine(s2);//？

            //o1在栈中    数据1 在堆中
            object o1 = 1;
            object o2 = o1;//o2得到的是 数据1的地址
            o1 = 2;//修改的是栈中o1存储的引用
            Console.WriteLine(o2);//？
        }

        //值类型与引用类型的应用
        static void Main4()
        {
            int num01 = 1, num02 = 2;
            bool r1 = num01 == num02;//?   因为值类型存储的是数据，所以比较的是数据


            int[] arr01 = new int[] { 1 }, arr02 = new int[] { 1 };
            bool r2 = arr01 == arr02;//? 因为引用类型存储的是数据的引用，所以比较的是存储的引用
            bool r3 = arr01[0] == arr02[0];



            int a = 1;
            int[] arr = new int[] { 1 };
            Fun1(a,arr);//实参将 数据1 赋值给形参 /数组引用 赋值给形参
            Console.WriteLine(a);//？
            Console.WriteLine(arr[0]); //？
        }

        static void Main5()
        {
            int a = 1;
            int[] arr = new int[] { 1 };
            Fun1(a, arr);//传递实参变量存储的内容

            int a2 = 1;
            Fun2(ref a2);
            Console.WriteLine(a2);//?2

            //区别2：输出参数 传递 之前可以不赋值
            int a3 = 1;//用于接收方法发结果
            Fun3(out a3);
            Console.WriteLine(a3);//2
        }

        //值参数：按值传递--传递实参变量存储的内容
        //作用：传递信息
        private static void Fun1(int a,int[] arr)
        {
            a = 2;
            arr[0] = 2;
            //arr = new int[]{ 2 };
        }

        //引用参数：按引用传递--传递实参变量自身的内存地址
        //作用：改变数据
        private static void Fun2(ref int a)
        {
            //方法内部修改引用参数 实质上就是在修改实参变量
            a = 2;
        }

        //输出参数:  按引用传递--传递实参变量自身的内存地址
        //作用：返回结果
        private static void Fun3(out int a)
        {//区别1：方法内部必须为输出参数赋值
            a = 2;
            //int number = int.Parse("250+");
            int result;
            //TryParse方法，返回2个结果
            //out：转换后的结果
            //返回值:是否可以转换
            bool re =int.TryParse("250", out result);
        }

        //练习1：定义  两个整数交换的方法

        private static void Swap(ref int one,ref int two)
        {
            int temp = one;
            one = two;
            two = temp;
        }

        //练习2：根据矩形长，宽计算面积与周长

        private static void CalculateRect(int legth,int width,out int area,out int perimeter)
        {
            area = legth * width;
            perimeter = (legth + width) * 2;
        }

        //拆装箱
        static void Main6()
        {
            int a = 1;
            //装箱操作：”比较“消耗性能
            object o = a;

            //拆箱操作：消耗性能
            int b = (int)o;

            int num = 100;
            string str = num.ToString();//没装

            string str02 = "" + num;//装箱
            //string str02 = string.Concat("", num);//int =》 object
        }

        //形参object类型，实参数传递值，则装箱
        //可以通过 重载避免，泛型避免。

        private static void Fun1(int obj)
        {

        }

        static void Main()
        {
            string s1 = "da";
            string s2 = "da";//同一个字符串

            string s3 = new string(new char[] { 'd', 'a' });
            string s4 = new string(new char[] { 'd', 'a' });

            bool r1 = object.ReferenceEquals(s1, s2);

            //字符串池
            //重新开辟空间 存储 新字符串，再替换栈中的引用
            s2 = "da";
            Console.WriteLine(s2);

            //每次修改，都是重新开辟新的空间存储数据，替换栈中的引用
            object o1 = 1;
            o1 = 2.0;

            //不可取
            string strNumber = "";
            for (int i = 0;i < 10; i++)
            {
                //"    "+" 0 "
                //" 0 "+" 1 "每次拼接产生新的对象 替换引用 (原有数据产生垃圾）

                strNumber += i.ToString();
            }
            Console.WriteLine(strNumber);

            //解决方法:可变字符串
            //一次开辟可以容纳10个字符大小的空间
            //优点：可以在原有空间修改字符串，可以避免产生垃圾
            //适用性：频繁对字符串操作(增加 替换 移除)
            StringBuilder bulider = new StringBuilder(10);//
            for(int i = 0; i < 10; i++)
            {
                bulider.Append(i);
            }
            bulider.Append("Hello");
            string result = bulider.ToString();
            //bulider.Insert(0,"hi");
            //bulider.Remove();
            //bulider.Replace();

            s1 = s1.Insert(0, "s1");
            //先自学字符串常用方法
            //再做练习
            
            //1.单词反转 How are you! => you are  How
            //2.字符反转 How are you=>uoy era woH
            //3.查找指定字符串中不重复出现的的文字(重复的文字保留1个)
        }
        //
    }
}
