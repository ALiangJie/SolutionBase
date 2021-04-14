using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class Program
    {
        # region 彩票生成器
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

        //        * 1.在控制台中购买彩票的方法int[7]
        //*      a.请输入第一个红球号码
        //* b.号码不能超过1-33，当前号码已经存在
        private static int[] BuyTicket()
        {
            int[] ballNumber = new int[7];
            int redBallNumber, blueBallNumber;
            for (int i = 0; i < ballNumber.Length - 1;)
            {
                Console.WriteLine("请输入第{0}个红球号码：", i + 1);
                redBallNumber = int.Parse(Console.ReadLine());
                if (redBallNumber < 1 || redBallNumber > 33)
                    Console.WriteLine("号码输入有误！");
                else if (Array.IndexOf(ballNumber, redBallNumber) >= 0)
                    Console.WriteLine("号码重复输入！");
                else
                    ballNumber[i++] = redBallNumber;
            }
            Console.WriteLine("请输入一个蓝球号码：");
            blueBallNumber = int.Parse(Console.ReadLine());
            if (blueBallNumber < 1 || blueBallNumber > 16)
                Console.WriteLine("号码输入有误！");
            else
                ballNumber[6] = blueBallNumber;
            return ballNumber;
        }

        //        * 2.随机产生一注彩票的方法int[7]
        //*      a.要求：红球号码不能重复，且按照从小到大排序
        //* b.
        private static int[] RandomTicket()
        {
            int[] ballNumber = new int[7];
            int redBallNumber, blueBallNumber;
            for (int i = 0; i < ballNumber.Length - 1;)
            {
                redBallNumber = random.Next(1, 34);
                if (Array.IndexOf(ballNumber, redBallNumber) == -1)
                    ballNumber[i++] = redBallNumber;
            }
            blueBallNumber = random.Next(1, 17);
            ballNumber[6] = blueBallNumber;
            Array.Sort(ballNumber, 0, 5);
            return ballNumber;

        }

        //        * 3.两注彩票比较的方法，返回中奖等级
        //* a.先计算红球，蓝球中奖数量
        private static int CompareTicket(int[] BuyTicket, int[] RandomTicket)
        {
            int redBallCount = 0, BlueBallCount = 0;
            for (int i = 0; i < BuyTicket.Length - 1; i++)
            {
                if (Array.IndexOf(RandomTicket, BuyTicket[i], 0, 5) >= 0)
                    redBallCount++;
            }
            if (BuyTicket[6] == RandomTicket[6])
                BlueBallCount = 1;
            return redBallCount + BlueBallCount;
        }

        private static void Input(int grade)
        {
            if (grade == 7)
                Console.WriteLine("中一等奖！");
            else if (grade == 6)
                Console.WriteLine("中二等奖！");
            else if (grade == 5)
                Console.WriteLine("中三等奖！");
            else if (grade == 4)
                Console.WriteLine("中四等奖！");
            else if (grade == 3)
                Console.WriteLine("中五等奖！");
            else if (grade == 2)
                Console.WriteLine("中六等奖！");
            else if (grade == 1)
                Console.WriteLine("中七等奖！");
            else
                Console.WriteLine("未中奖！");
        }

        private static void Main1()
        {
            int[] buyTicket = BuyTicket();
            int spendCount = 0, grade = 0;
            while (grade != 7)
            {
                grade = CompareTicket(buyTicket, RandomTicket());
                Input(grade);
                spendCount++;
                Console.WriteLine("共花费{0}", spendCount);
            }
        }
        #endregion

        //上次所学
        static void Main2()
        {
            //方法重载  递归  数组
            //Array.Sort()
            //1.5f   1.2f ...
            float[] array = new float[] { 1.5f, 1.2f, 1.0f };
            array[2] = 1.2f;
            //从头到尾  依次 读取元素
            foreach (float element in array)
            {
                Console.WriteLine(element);
            }

        }

        //for-for打印图形
        static void Main3()
        {
            //for  for  二维数组    交错数组
            for (int a = 0; a < 3; a++)
            {
                for (int e = 0; e < 4; e++)
                {
                    Console.Write("Hello !World！\t");
                }
                Console.WriteLine("\r\n");
            }

            //    //外层  4    行    内层
            //    /*
            //     #
            //     ##
            //     ###
            //     ####
            //     */
            for (int y = 1; y <= 4; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            //    //练习：
            //    /*
            //     *          空格   #
            //     ####      0     4
            //       ###      1     3
            //         ##      2     2
            //           #      3     1
            //     */

            for (int i = 0; i < 4; i++)
            {
                //                  0
                //0                1
                //0  1            2
                //0  1   2   3  4
                for (int h = 0; h < i; h++)
                {
                    Console.Write("\0");
                }
                //0 1  2  3  4
                //0 1  2      3
                //0  1         2
                //0             1
                for (int r = 0; r < 4 - i; r++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            //打印菱形
            //    *
            //  ***
            //*****
            //  ***
            //    *
            for (int i = 1; i <= 3; i++)
            {
                //0  1    2
                //0        1
                //          0
                for(int r = 0; r < 3 - i; r++)
                {
                    Console.Write("\0");
                }
                //0               1  1
                //0 1 2         3  2
                //0 1 2 3 4   5  3
                for(int h = 0; h < 2 * i - 1; h++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


            for (int ii = 1; ii <= 2; ii++)
            {
                //0     1
                //0 1  2
                for (int rr = 0; rr < ii; rr++)
                {
                    Console.Write("\0");
                }
                //0 1 2  3  1
                //0        1  2
                for (int hh = 0; hh < 5 - ii * 2; hh++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //    ////乘法表
            //    //for (int y = 1; y <= 9; y++)
            //    //{
            //    //    for (int x = 1; x <= y; x++)
            //    //    {
            //    //        Console.Write("{0}X{1}={2}\t", y, x, y * x);
            //    //    }
            //    //    Console.WriteLine();
            //    //}
            //}
        }

        static void Main4()
        {
            /*
                自定义排序
                2  8  6  1
                将第一个元素设置为最小值
                使用第一个元素 依此与后面的元素 进行比较
                1 8 6 2
                将第二个元素 依此与后面元素 进行比较
                使用第一个元素 依此与后面的元素 进行比较
                1 2 8 6
                将第三个元素设置为最小值
                使用第一个元素 依此与后面的元素 进行比较
                1 2 6 8
                四个数比较3轮  第一轮比较3次 第二轮比较2次 第三轮比较1次

            */
            //arr存数组的引用
            int[] array = { 2, 1, 8, 6, 1 };
            OrderBy1(array);
            bool res = IsRepeating(array);
        }

        //冒泡排序
        //问题：每轮交换次数可能过多
        private static int[] OrderBy1(int[] array)
        {
            //需要与后面比较的元素
            for (int currentIndex = 0; currentIndex < array.Length - 1; currentIndex++)
            {
                for (int i = currentIndex + 1; i < array.Length; i++)
                {
                    if (array[currentIndex] > array[i])
                    {
                        //交换
                        int temp = array[currentIndex];
                        array[currentIndex] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }

        //选择排序：每轮仅仅交换一次
        private static int[] OrderBy2(int[] array)
        {
            //需要与后面比较的元素   轮
            for(int currentIndex = 0; currentIndex < array.Length - 1; currentIndex++)
            {
                int minIndex =currentIndex;
                //次
                for(int i = currentIndex + 1; i < array.Length; i++)
                {
                    if (array[minIndex] > array[i])
                    {
                        //记录需要交换的索引   i
                        minIndex = i;
                    }
                }
                if (minIndex != currentIndex)
                {
                    //交换
                    int temp = array[currentIndex];
                    array[currentIndex] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
            return array;
        }

        //定义检查数组中是否存在相同元素的方法int[]
        private static bool IsRepeating(int[] array)
        {//5 3 1 3 8
            //取出元素
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {//array[i]
                    //与后面元素比较
                    if (array[i] == array[j])
                        return true;
                }
            }
            return false;
        }

        private static void Main5()
        {
            //数组分类：一维数组  多(二)维数组  交错数组
            int[,] array = new int[5, 3];
            //array.Length=15
            array[0, 2] = 6;
            //for -for 
            //array.GetLength(0)  行数
            //array.GetLength(1)  列数
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for(int c = 0; c < array.GetLength(1); c++)
                {
                    Console.Write(array[r, c]+"\t");
                }
                Console.WriteLine();
            }

            /*
             * 1.在控制台中录入学生成绩
             * “请输入学生总数：”
             * “请输入科目数：”
             * “请输入第1个学生的第1门成绩：”
             * “请输入第1个学生的第2门成绩：”
             * “请输入第2个学生的第1门成绩：”
             * “请输入第2个学生的第2门成绩：”
             *              科目1         科目2
             * 学生1
             * 学生2
             * 学生3
             * 
             * 
             * 2.在控制台中，以表格显示二维数组元素
             * 
             */
            float[,] scoreArray = StduentGrade();
            PrintDoubleArray(scoreArray);
            Console.WriteLine();
        }
        /*
 * 在控制台中录入学生成绩
 * “请输入学生总数：”
 * “请输入科目数：”
 * “请输入第1个学生的第1门成绩：”
 * “请输入第1个学生的第2门成绩：”
 * “请输入第2个学生的第1门成绩：”
 * “请输入第2个学生的第2门成绩：”
 *              科目1         科目2
 * 学生1
 * 学生2
 * 学生3
 */
        private static float[,] StduentGrade()
        {
            Console.WriteLine("请输入学生总数:");
            int stduentNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入科目数:");
            int objectNumber = int.Parse(Console.ReadLine());
            float[,] scoreArray = new float[stduentNumber, objectNumber];
            //学生
            for (int r = 0; r < stduentNumber; r++)
            {
                //科目
                for (int c = 0; c < objectNumber; c++)
                {
                    Console.WriteLine("请输入第{0}个学生的第{1}门科目成绩:", r + 1, c + 1);
                    scoreArray[r, c] = float.Parse(Console.ReadLine());
                }
            }
            return scoreArray;

        }

        private static void PrintDoubleArray(Array array)
        {
            for(int r = 0; r < array.GetLength(0); r++)
            {
                for(int c = 0; c < array.GetLength(1); c++)
                {
                    Console.Write(array.GetValue(r,c) + "\t");
                }
                Console.WriteLine();
            }
        }

        //2048核心算法
        //上移
        /*
         * 1.从上到下 获取列数据，形成一维数组
         * 2 2 0 0-》4 0 0 0
         * 2 2 2 0-》4 0 2 0-》4 2 0 0
         * 2 0 2 0-》2 2 0 0-》4 0 0 0
         * 2 2 0 4-》2 2 4 0-》4 0 4 0-》4 4 0 0
         * 0 2 4 2-》2 4 2 0
         * 2.合并数据，
         *      去零：将0元素移到末尾
         *      相邻相同，则合并(将后一个元素累加到前一个元素上，后一个元素清零)
         *      去零：将0元素移到末尾
         * 3.将一维数组  还原至原列
         */

        //下移 1.0
        /*
        * 1.从上到下 获取列数据，形成一维数组
        * 2 2 0 0-》0 0 0 4
        * 2 2 2 0-》0 2 2 2-》0 2 0 4-》0 0 2 4 
        * 2 0 2 0-》
        * 2 2 0 4-》
        * 0 2 4 2-》
        * 2.合并数据，
        *      去零：将0元素移到开头
        *      相邻相同，则合并(将前一个元素累加到后一个元素上，前一个元素清零)
        *      去零：将0元素移到开头
        * 3.将一维数组  还原至原列
        */

        //下移 2.0
        /*
         * 1.从下到上 获取列数据，形成一维数组

         * 2.合并数据，
         *      去零：将0元素移到末尾
         *      相邻相同，则合并(将后一个元素累加到前一个元素上，后一个元素清零)
         *      去零：将0元素移到末尾
         * 3.将一维数组  还原至原列
        */
        //左移
        //右移

        //编码
        //1.定义去零方法(针对一维数组)：将0元素移到末尾
        //2.合并数据方法(针对一维数组)
        //去零：将0元素移到末尾
        //相邻相同，则合并(将后一个元素累加到前一个元素上，后一个元素清零)
        //去零：将0元素移到末尾
        //3.上移
        //    从上到下 获取列数据，形成一维数组
        //    调用合并数据方法
        //    将一维数组  还原至原列
        //4.下移
        //    从下到上 获取列数据，形成一维数组
        //    调用合并数据方法
        //    将一维数组  还原至原列
        //5.左移
        //6.右移

        private static void Main()
        {
            int[,] map = new int[4, 4]
            {
                {2,2,4,8 },
                {2,4,4,4 },
                {0,8,4,0 },
                {2,4,0,4 }
            };
            PrintDoubleArray(map);
            Console.WriteLine("上移");
            map = MoveUp(map);
            PrintDoubleArray(map);

            Console.WriteLine("下移");
            map = MoveDown(map);
            PrintDoubleArray(map);

            //移动
            //Move(map,0);//上移
            //Move(map,MoveDirection.Up);//枚举可读性，限制调用者取值
            //Move(map,1);//下移

        }

        private static int[] RemoveZero(int[] array)
        {
            //0 0 0 0
            int[] newArray = new int[array.Length];
            int index=0;
            //将非零元素 依次赋值给新数组
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    newArray[index++] = array[i];
                }
            }
            return newArray;
            //array = newArray;替换引用  方法外不会受到影响
            //array[0] = newArray[0];//通过引用修改堆中数组对象
            //newArray.CopyTo(array, 0);
        }
         
        //2 2 0 2        2 0 0 2
        private static int[] Merge(int[] array)
        {
            array = RemoveZero(array);//2 2 2 0 
            //合并数据
            for (int i = 0; i < array.Length-1; i++)
            {
                //相邻相同
                if (array[i] != 0 && array[i] == array[i + 1])
                {
                    array[i] += array[i + 1];
                    array[i + 1] = 0;
                    //统计合并位置
                }
            }
            array = RemoveZero(array);

            return array;
        }

        private static int[,] MoveUp(int[,] map)
        {
            //    从上到下 获取每列数据，形成一维数组
            /*
             * 0,0      0,1      0,2    0,3
             * 1,0      1,1      1,2    1,3
             * 2,0      2,1      2,2    2,3
             * 3,0      3,1      3,2    3,3
             */
            int[] mergeArray = new int[map.GetLength(0)];
            for(int c = 0; c < map.GetLength(1); c++)
            {
                for (int r = 0; r < map.GetLength(0); r++)
                {
                    mergeArray[r] = map[r, c];
                }

                mergeArray = Merge(mergeArray);

                for (int r = 0; r < map.GetLength(0); r++)
                {
                    map[r, c] = mergeArray[r];
                }
            }
            return map;
        }

        private static int[,] MoveDown(int[,] map)
        {
            //    从上到下 获取每列数据，形成一维数组
            /*
             * 0,0      0,1      0,2    0,3
             * 1,0      1,1      1,2    1,3
             * 2,0      2,1      2,2    2,3
             * 3,0      3,1      3,2    3,3
             */
            int[] mergeArray = new int[map.GetLength(0)];
            for(int c = 0; c < map.GetLength(1); c++)
            {
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    mergeArray[3 - r] = map[r, c];//从头到尾存入一维数组
                }

                mergeArray = Merge(mergeArray);

                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    map[r, c] = mergeArray[3 - r];
                }
            }
            return map;
        }

        private static void MoveLeft(int[,] map) { }
        private static void MoveRight(int[,] map) { }

        //数据类型  int     值：0，1，2...

        private static void Move(int[,] map, int direction)
        {
            switch (direction)
            {
                case 0:
                    MoveUp(map);
                    break;
                case 1:
                    MoveDown(map);
                    break;
                case 2:
                    MoveLeft(map);
                    break;
                case 3:
                    MoveRight(map);
                    break;
            }
        }

        //数据类型 MoveDirection                值：MoveDirection.Up  MoveDirection.Down..加标签
        private static void Move(int[,] map, MoveDirection direction)
        {
            switch (direction)
            {
                case MoveDirection.Up:
                    MoveUp(map); 
                    break;
                case MoveDirection.Down:
                    MoveDown(map);
                    break;
                case MoveDirection.Left:
                    MoveLeft(map);
                    break;
                case MoveDirection.Right:
                    MoveRight(map);
                    break;
            }
        }

        //每日一练：左移  右移
    }
}
