using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Program
    {
        //短路逻辑
        static void Main1(string[] args)
        {
            //短路逻辑
            //好处：计算量大的放后头，可以减少计算量
            //是否会产生影响，来判断是否后面会执行
            int n1 = 1, n2 = 2;
            bool r1 = n1 > n2 && n1++ > 1;//对于&&运算符，当第一个操作数为false，不判断下一个数是啥
            Console.WriteLine(n1);//1

            bool r2 = n1 < n2 || n2++ < 1;//对于||运算符，当第一个为true，不判断下一个数是啥
            Console.WriteLine(n2);//2
        }

        //循环语句
        static void Main2()
        {
            //循环语句  跳转语句  方法
            //初始化；循环条件；增减变量
            //for(int i=0;i<5;i++)
            //{
            //    Console.WriteLine("Hello World!");
            //}

            //作用域：起作用的范围
            //从 声明 到 } 结束
            //预定次数循环
            for (int i = 0; i < 5;)
            {
                Console.WriteLine(i);
                ++i;//无区别i++；
            }
            //Console.WriteLine(i);

            //一张纸的厚度为0.01毫米
            //请计算对折30 次以后厚度为多少米
            //累乘
            double tickness = 0.01;
            for (int i = 0; i < 30; i++)
            {
                tickness *= 2;
            }
            Console.WriteLine(tickness * 0.001);
            //1+2+3+4+...+100
            //累加
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                // if (i % 3 == 0) continue;//被3整除数相加和。
                //continue语句 结束这次循环，继续下次循环。 
                sum += i;
            }
            Console.WriteLine(sum);
            //while
            //while（条件）
            //{循环体； 增减变量；}

            //练习：一个球从100m高度落下
            //每次落地后，弹回原高度一半，总共经过多少次落地和总共经过多少米（最小弹起高度：0.01m）
            float height = 100f, sum1 = 100;
            int count = 0;
            while (height / 2 >= 0.01f)
            {
                height /= 2;
                //累加起落距离
                sum1 += height * 2;
                count++;
                Console.WriteLine("The {0} height {1}m", count, height);
            }
            Console.WriteLine(count);
            Console.WriteLine(sum1);
            // Console.WriteLine("{0:f1}",sum1);


            //do-while
            //do{循环体}
            //while(条件)
            //先执行一次循环体，再判断条件。

            //练习：程序产生1-100之间的随机数
            //让玩家重复猜测，直到猜到位置。
            //“大了”，“小了”，“恭喜！猜到了，总共猜了？多少次”

            //创建一个随机数工具
            Random random = new Random();
            //产生一个随机数
            //int number = random.Next(1, 101), inputnumber, count = 0;
            //do
            //{
            //    Console.WriteLine("Please input number:");
            //    inputnumber = int.Parse(Console.ReadLine());
            //    count++;
            //    if (inputnumber > number)
            //        Console.WriteLine("Big!");
            //    else if (inputnumber < number)
            //        Console.WriteLine("Small!");
            //    else
            //    {
            //        Console.WriteLine("Good!  Guess {0} time!", count);
            //        break;
            //    }
            //} while (inputnumber != number);
        }

        //跳转语句
        static void Main3()
        {
            //continue,break,return
            //跳过这次循环，退出最近循环体

        }

        //方法（函数调用）
        static void Main4()
        {
            //定义方法：[访问修饰符][可选修饰符]   返回类型   方法名称（参数列表）
            //{方法体  return 结果；}
            //调用方式：方法名称（参数）；
            Mytest1();
            //方法的调用者
            int number = Mytest2();
            Console.WriteLine(number);
            int aa = 100;
            string bb = "ok!";
            //实参与形参一一对应（类型，顺序，个数）
            //方法定义者要求调用者必须传递的信息
            Mytest3(aa, bb);//实际参数

            //学会调用别人提供的方法
            //1.看名字猜，看描述
            //2.看参数（类型，名称，描述）
            //3.看返回值
            //4.测试


            //添加指定索引位置的字符串
            string str = "Hello World!";
            str = str.Insert(5, "Hi");
            //查找指定字符在字符串中的索引
            int index = str.IndexOf('H');
            //删除指定索引后的指定数量的字符，
            str = str.Remove(7, 5);
            //用一字符代替所有的另一字符
            str = str.Replace('H', 'h');
            //比较原有字符串与参数字符的首字符是否相等，逐一往后推，比较两个字符串是否相同
            bool result = str.StartsWith("heo");
            //比较原有字符串中是否有此字符子串，查找是否存在这样的子串
            result = str.Contains("hi");
        }

        //定义方法
        //方法：表示功能
        //返回值：功能的结果
        //            方法定义者  告诉  方法调用者的  结果
        //返回值类型；int  float   double  string
        //void  没有返回值
        private static void Mytest1()
        {
            Console.WriteLine("1");
            return;//没有返回值，也可以写return关键字    退出方法
        }

        //方法的定义者
        private static int Mytest2()
        {//方法的定义者
            //返回的数据必须与返回值类型兼容
            int i = 1;
            float a = i;
            Console.WriteLine("1");
            return 250;//返回数据   退出方法
        }

        //形式参数
        private static void Mytest3(int a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        //如何定义方法
        static void Main()
        {
            //日历
            int twoNumberSum = Add(1, 1);
            while (true)
            {
                Console.WriteLine("Please input year:");
                PrintYearCalendar(int.Parse(Console.ReadLine()));
                Console.WriteLine("\r\n");
            }
            //时间的转换
            //Console.WriteLine("Please input minute,hour,day:");
            //int minute = MinuteTurnSecond(int.Parse(Console.ReadLine()));
            //int hour = HourTurnMinute(int.Parse(Console.ReadLine()));
            //int day = DayTurnHour(int.Parse(Console.ReadLine()));
            //int sum = minute + hour + day;
            //Console.WriteLine("The Sum Of Second is:{0}s", sum);

        }

        //两个整数相加的方法{一个功能}
        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        /*练习
         * 1.在控制台显示年历的方法
         * --调用12遍月历
            2.在控制台中实现月历的方法
            --显示表头 Console.WriteLine("日\t一\t二");
            --计算当月一日星期数，输出空白（\t）
            Consloe.Write("\t");
            --计算当月天数，输出1 \t 2
            --每逢周六换行
         * 3.根据年月日，计算星期数
         * 4.计算指定月份的天数
         * 5.判断闰年的方法 
         *    2月有闰年29天  平年28天
         *    年份能被4整除但是不能被100整除
         *    或年份能被400整除
         */

        //1.打印一年的12个月
        private static void PrintYearCalendar(int year)
        {
            for(int i=1;i<=12;i++)
            {
                Header(year, i);
            }
        }

        //2.在控制台中实现月历的方法
        //--显示表头 Console.WriteLine("日\t一\t二");
        //--计算当月一日星期数，输出空白（\t）
        //Consloe.Write("\t");
        //--计算当月天数，输出1 \t 2
        //--每逢周六换行
        private static void Header(int year, int month)
        {
            Console.WriteLine("\r\n");
            Console.WriteLine("{0}年{1}月", year, month);
            Console.Write("日\t一\t二\t三\t四\t五\t六\r\n");
            int week = GetWeekByDay(year, month, 1);
            for (int i = 1; i <= week; i++)
            {
                Console.Write("\t");
            }
            int day = MonthDay(year, month);
            for (int i = 1; i <= day; i++)
            {
                Console.Write(i+"\t");
                //Console.Write("\t");
                if (GetWeekByDay(year, month, i) == 6)
                {
                    Console.WriteLine();
                }
                //if (week == 6 || week == 13 || week == 20 || week == 27 || week == 34)
                //{
                //    Console.Write("\r\n");
                //}
                //week++;
            }
        }

        //        * 3.根据年月日，计算星期数
        /// <summary>
        /// 根据年月日，计算星期数的方法
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <param name="day">日</param>
        /// <returns>星期数</returns>
        private static int GetWeekByDay(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return (int)dt.DayOfWeek;
        }

        //       * 4.计算指定月份的天数
        private static int MonthDay(int year, int month)
        {
            //改进后
            if (month < 1 || month > 12) return 0;

            switch (month)
            {
                case 2:
                    return Isleapyear(year) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
            //未改进代码
            //int day = 0;
            //if (month >= 1 && month <= 12)
            //{
            //    if (Isleapyear(year) && month == 2) day = 29;
            //    else if (month == 2) day = 28;
            //    else if (month == 4 && month == 6 && month == 9 && month == 11) day = 30;
            //    else day = 31;
            //}
            //else
            //{
            //    Console.WriteLine("Month Error！");
            //}
            //return day;

        }

        //        * 5.判断闰年的方法
        private static bool Isleapyear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        //每日一练：
        //1.根据分钟数 计算 总秒数
        //2.根据分钟数 小时数 计算总秒数
        //3.根据分钟数 小时数 天数 计算总秒数

        //分钟转秒钟
        private static int MinuteTurnSecond(int minute)
        {
            return minute * 60;
        }
        //小时转分钟
        private static int HourTurnMinute(int hour)
        {
            return MinuteTurnSecond(hour * 60);
        }
        //天转小时
        private static int DayTurnHour(int day)
        {
            return HourTurnMinute(day * 24);
        }

    }
}
