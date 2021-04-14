using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Program
    {
        //方法重载
        //每日一练：
        //1.根据分钟数 计算 总秒数
        //2.根据分钟数 小时数 计算总秒数
        //3.根据分钟数 小时数 天数 计算总秒数
        //改进后代码
        static void Main1(string[] args)
        {
            int theSumOfSecond = TheSumOfSecond(1,1,0);

            //方法重载
            //定义：方法名称相同，参数列表不同
            //作用：在不同条件下，解决同一类问题，让调用者仅仅记忆1个方法
        }

        //分钟转秒钟
        private static int TheSumOfSecond(int minute)
        {
            return minute * 60;
        }
        //小时转分钟
        private static int TheSumOfSecond(int minute,int hour)
        {
            return TheSumOfSecond(minute + hour * 60);
        }
        //天转小时
        private static int TheSumOfSecond(int minute, int hour,int day)
        {
            return TheSumOfSecond(minute, hour + day * 24);
        }

        static void Main2()
        {
            //递归   数组
            //int result = GetFactiorial(3);
            //result = NumberSum(8);
            //ArrayTest();
            float[] grade = OutputStudentsGrade(5);
            float max = GetMax(grade);
            Console.WriteLine(max);
        }

        //计算阶乘 (请使用递归算法实现)5！
        private static int GetFactiorial(int num)//3
        {
            /*3  3 * 3-1
             *2  2 * 2-1
             *1  retuen 1
             */
            if (num == 1) return 1;
            //方法内部又调用自身的构成
            //核心思想：将问题转移给范围缩小的子问题
            //适用性：在解决问题过程中，又遇到相同问题
            //优点：将复杂的问题简单化
            //缺点：性能较差
            //注意：堆栈溢出
            return num*GetFactiorial(num-1);
        }

        /*编写一个函数，计算当参数为8时的结果为多少？
         * 使用递归实现
         * 1-2+3-4+5-6......
         */
        private static int NumberSum(int num)
        {
            if (num == 1) return 1;
            if (num % 2 != 0)
                return num+NumberSum(num-1);
            return NumberSum(num-1) - num;
        }

        //数组
        private static void ArrayTest()
        {
            //声明
            int[] array;//null
            //初始化 new 数据类型[容量]
            array = new int[3];
            //通过索引读写每个元素
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //a[0] = 1;//赋值
            //a[1] = 1;
            //a[2] = 1;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //在控制台中录入学生成绩float[]
        //"请输入学生总数："new floa[5]
        //"请输入第一个学生成绩："
        //要求：如果成绩不在0-100之间，则提示成绩有误
        private static float[] OutputStudentsGrade(int studentNumber)
        {
            float[] array;
            array = new float[studentNumber];
            for (int i = 0; i < array.Length;)
            {
                Console.WriteLine("Please input the {0} student grade:", i + 1);
                float grade = float.Parse(Console.ReadLine());
                if (grade <= 100 && grade >= 0)
                    array[i++] = grade;
                else
                    Console.WriteLine("Error!Again input!");
            }
            return array;
        }

        //定义查找数组元素最大值的方法float[]
        private static float GetMax(float[] array)
        {
            //假设第一个元素为最大值
            float max = array[0];
            //依次比较
            for(int i=1;i<array.Length;i++)
            {
                //如果发现更大的元素   替换最大值
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }

        //数组的其它写法
        private static void Main3()
        {
            //1.初始化 + 赋值
            string[] array01 = new string[2] { "a", "b" };

            //2.声明 + 初始化 + 赋值
            bool[] array02 = { true, false };
            //3.
            float max = GetMax(new float[] { 3, 4, 5 });
        }

        //定义方法：根据年月日，计算当天是本年的第几天
        //将每月天数存储到数组中
        private static int TotalDays(int year,int month,int day)
        {
            int[] daysOfMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //如果闰年
            if(Isleapyear(year)) daysOfMonth[1] = 29;
            int days = 0;
            for(int i = 0; i < month-1; i++)
            {
                days += daysOfMonth[i];
            }
            days += day;
            return days;
        }

        // 判断闰年
        private static bool Isleapyear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        private static void Main()
        {
            int[] array = { 1, 2, 3, 4, 531, 231, 2 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            //1.foreach(元素类型  变量名  in  数组名称)
            //{
            //    变量名即数组每个元素
            //}
            //从头到尾 依次 读取 数组元素
            //优点：使用简单
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
            
            //2.推断类型：根据所赋数据，推断出类型
            //适用性:数据类型名称较长
            var v1 = 1;
            var v2 = "1";
            var v3 = '4';

            //3.声明 父类类型  赋值  子类对象
            Array arr01 = new int[2];
            Array arr02 = new string[2];
            Array arr03 = new double[2];

            PrintElement(new int[] { 12, 3213, 1231 });
            PrintElement(new float[] { 13, 213, 123 });

            //4.object 万类之祖
            //声明object类型 赋值 任意类型
            object o1 = 1;
            object o2 = true;
            object o3 = new int[3];

        }

        //定义方法，形参可传任意类型数据
        private static void Fun1(object obj)
        {

        }

        //定义方法，将数组所有元素显示到控制台中

        private static void PrintElement(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        //常用方法及属性
        //练习：
        //彩票生成器
        /*
         * 红球：1-33  6个   不能重复
         * 蓝球：1-16  1个   
         * 1.在控制台中购买彩票的方法int[7]
         *      a.请输入第一个红球号码
         *      b.号码不能超过1-33，当前号码已经存在
         * 2.随机产生一注彩票的方法int[7]
         *      a.要求：红球号码不能重复，且按照从小到大排序
         *      b.
         * 3.两注彩票比较的方法，返回中奖等级
         *      a.先计算红球，蓝球中奖数量
         *      
         * 在Main中测试
         */
         //方法的外面   类的内部
        
        static Random random = new Random();
        int number = random.Next(1, 34);
    }
}
