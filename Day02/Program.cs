using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class Program
    {
        //占位符
        static void Main1(string[] args)
        {
            string gunName = "AK_47";
            string gunBuellt = "30";
            //占位符{位置编号}如果编号大于列表长度，出现异常
            string str = string.Format("gunName:{0},gunBuellt:{1}", gunName, gunBuellt);
            Console.WriteLine(str);

            //标准数字格式字符串
            Console.WriteLine("Spead:{0:c}", 30);
            Console.WriteLine("Time:{0:d2}", 10);//不足两位用零填充
            Console.WriteLine("Scroce:{0:f2}", 1.26);//指定精度显示
            Console.WriteLine("SuccefulPercentage:{0:p0}", 0.2);//以百分数显示

            //转义符：改变字符原始含义 \" \' \0
            Console.WriteLine("I love \"China\"");
            char n1 = '\'';// '
            char n2 = '\0';//空字符''

            //\r\n回车换行  \t水平制表符(Tab键)
            Console.WriteLine("Hi!\r\nI'm come form\tChina");
            Console.ReadLine();

            //.NET程序编译过程
            //源代码(.cs的文本文件)->CLS编译->CILexe(中间语言)->CLR编译(公共语言运行库)->机器码(0 1) 
        }

        //运算符：对数字做运算
        static void Main2()
        {
            int n1 = 5, n2 = 2;
            int r1 = n1 / n2;//  5/2=2.5  截断删除得2，改为float型得2.5
            int r2 = n1 % n2;//取余

            //%的作用
            //(1)判断一个数能否被另外一个数整除
            //n1能否被2整除  true or false
            bool r3 = n1 % 2 == 0;

            //(2)获取整数的个位
            int n3 = 25;
            int r4 = n3 % 10;

            string s1 = "5", s2 = "2";
            string r5 = s1 + s2;//"52"  字符的拼接

            //比较运算符
            //>  <  <=  >=  ==  !=
            bool r6 = n1 == n2;
            bool r7 = s1 == s2;//文本是否相同

            //逻辑运算符
            //&& || ！
            bool r8 = true && true;//并且
            bool r9 = true || false;//或者
            bool r10 = !true;//取反

            //快捷运算符+= *= /= %=
            int num01 = 1;
            num01 += 5;
            Console.WriteLine(num01);
            num01 *= 5;
            Console.WriteLine(num01);

            //一元运算符++ --  二元  三元
            //根据操纵数划分

            //(1)将a=num++赋值给某个变量，输出num++时
            int num02 = 1;
            Console.WriteLine(num02++);//先取值，再加一
            int num03 = 1;
            Console.WriteLine(++num03);//先加一，再取值

            //(2)将num++语句先进行，再输出时是num加一后面的值
            int num04 = 1;
            num04++;
            Console.WriteLine(num04);//2
            Console.WriteLine(num04++);//2
            Console.WriteLine(num04);//3
            int num05 = 1;
            ++num05;
            Console.WriteLine(num05);//2
            Console.WriteLine(++num05);//3

            // 三元运算符  数据类型 变量名 = 条件？满足条件结果：不满足条件结果 ；
            string s3 = 1 > 2 ? "Yes" : "No";
            float r11 = 1 == 1 ? 1.2f : 1.3f;

            //优先级  先加减后乘除  小括号优先级高于前
            int r12 = (1 + 2) * 2;




            Console.ReadLine();
        }

        //数据类型转换
        static void Main3()
        {
            //string “19”=》int 19

            //1.Parse转换：string 转换为其它数据类型
            //数据相像
            string strNumber = "19";
            int num01 = int.Parse(strNumber);
            float num02 = float.Parse(strNumber);

            //2.任意类型变成string类型
            int num03 = 18;
            string str = num03.ToString();

            //3.隐式转换：由小范围 到 大范围的自动转化
            byte b1 = 100;
            int i1 = b1;

            //4.显式转换：由大范围 到 小范围的强制转化
            //注意：有可能发生精度的丢失
            int i2 = 100;
            byte b2 = (byte)i2;
            //隐式，显式 通常发生在数值之间

            //由多种变量参与运算，结果向较大的类型提升
            byte number01 = 1;
            short number02 = 2;
            short result = (short)(number01 + number02);
            //int result1 = (short)(number01 + number02);

            byte b = 1;
            b += 3;//快捷运算符，不做自动类型提升
            b = (byte)(b + 3);
            int b0 = b + 3;

            Console.ReadLine();
        }

        /*练习：用户输入一个四位整数计算每一位数相加的和*/
        static void Main4()
        {
            /*练习：用户输入一个四位整数计算每一位数相加的和*/

            Console.WriteLine("Please input number:");
            string str1 = Console.ReadLine();

            //法一
            # region 方案一
            int number = int.Parse(str1);
            Console.WriteLine("Sum:{0}", number % 10 + number / 10 % 10 + number / 100 % 10 + number / 1000);
            #endregion

            //法二
            #region 方案二
            int r1 = int.Parse(str1[0].ToString());
            r1 += int.Parse(str1[1].ToString());
            r1 += int.Parse(str1[2].ToString());
            r1 += int.Parse(str1[3].ToString());
            Console.WriteLine("Sum:{0}", r1);
            #endregion


            Console.ReadLine();
        }

        //选择语句  循环语句  跳转语句
        static void Main5()
        {
            //选择语句
            Console.WriteLine("Please input sex:");
            string strSex = Console.ReadLine();
            if (strSex == "man")
            {
                Console.WriteLine("Hi! man");
            }
            else if (strSex == "woman")
            {
                Console.WriteLine("Hi! woman");
            }
            else
            {
                Console.WriteLine("Error!Please try again!");
            }

            Console.ReadLine();
        }

        /*练习：让用户在控制台输入两个数和一个运算符，输出两个数运算后的答案*/
        static void Main6()
        {
            /*练习：让用户在控制台输入两个数和一个运算符，输出两个数运算后的答案*/

            //获取数据
            Console.WriteLine("Please input  the first number:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please input  the second number:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please input  the sign:");
            char sign = Console.ReadLine()[0];
            //数据验证

            //逻辑处理(多路分支)

            #region if-else语句
            float result;
            if (sign == '+') result = num1 + num2;
            else if (sign == '-') result = num1 - num2;
            else if (sign == '*') result = num1 * num2;
            else if (sign == '/') result = num1 / num2;
            else result = 0;
            #endregion

            #region switch-case语句
            //判断bool ，char ，string，整型，枚举等,必须有一定值。
            //switch (sign)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        break;
            //    default:
            //        result=0;
            //        break;
            //}
            #endregion
            //显示结果
            if (sign == '+' || sign == '-' || sign == '*' || sign == '/')
                Console.WriteLine("The answer:" + result);
            //Console.WriteLine("The answer:{0:f2}", result);
            else
                Console.WriteLine("Error sign! Please try again!");
        }

        /*练习：让用户在控制台输入一个成绩，100-90 “优秀”，89-70“良好”，>=60 “及格”，<60“不及格”，其它“成绩错误”。*/
        static void Main7()
        {
            Console.WriteLine("Please input score:");
            int score = int.Parse(Console.ReadLine());
            string message="";
            if (score < 0 || score > 100) message = "Incorrect grade entry!";
            else if (score >= 90) message = "Excellent";
            else if (score >= 70) message = "Well";
            else if (score >= 60) message = "Pass";
            else message = "Fail";

            #region switch-case语句
            if (score>=0&&score<=100)
            {
                switch (score / 10)
                {
                    case 10:
                    case 9:
                        message = "Excellent";
                        break;
                    case 8:
                    case 7:
                        message = "Well";
                        break;
                    case 6:
                        message = "Pass";
                        break;
                    case 5:
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                    case 0:
                        message = "Fail";
                        break;
                }
            }
            else
            {
                message = "Incorrect grade entry!";
            }
            #endregion
            Console.WriteLine(message);
        }

        /*练习：让用户在控制台输入一个月份，输出这个月份的天数*/
        static void Main()
        {
            Console.WriteLine("Please input month:");
            int month = int.Parse(Console.ReadLine());
            int day = 0;
            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 2:
                        day = 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                    default:
                        day = 31;
                        break;
                }
                Console.WriteLine("The {0} month have {1} day！", month, day);
            }
            else
            {
                Console.WriteLine("The month does not exist！");
            }
        }

        //课后习题，计算税收。
    }
}
