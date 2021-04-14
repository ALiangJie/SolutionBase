using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2048
{
    class Program
    {
        //消除类游戏做法
        //数据 （位置） 逻辑控制 与 显示（界面代码）   松散耦合
        //mvc
        //面向对象思想：分而治之 高内聚 低耦合
        static void Main(string[] args)
        {
            GameCore core = new GameCore();
            core.GenerateNumber();

            //显示界面
            DrawMap(core.Map);
            while (true)
            {
                //移动
                KeyDown(core);
                //如果map中的数据发生变化
                if(core.IsChange)
                {
                    core.GenerateNumber();
                    DrawMap(core.Map);
                    //如果游戏结束。。。。
                }
            }
        }

        private static void DrawMap(int[,] map)
        {
            Console.Clear();

            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(map[r, c] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void KeyDown(GameCore core)
        {
            //移动之前记录map

            switch (Console.ReadLine())
            {
                case "w":
                    core.Move(MoveDirection.Up);
                    break;
                case "s":
                    core.Move(MoveDirection.Down);
                    break;
                case "a":
                    core.Move(MoveDirection.Left);
                    break;
                case "d":
                    core.Move(MoveDirection.Right);
                    break;
            }
            //移动完毕对比map
        }
    }
}
