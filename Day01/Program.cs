using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引入命名空间

//定义命名空间（类的地址）:对类进行逻辑上的划分，避免重名
namespace Day01
{
    //定义类（做工具）
    class Program
    {
        //定义方法（做功能）
        //程序的入口方法
        static void Main()
        {
            //简单的输入输出
            //枪的名字，枪的弹匣容量，枪的弹匣当前子弹数，枪的剩余子弹数
            //console.writeline("input gunname:");
            //string gunname = console.readline();
            //console.writeline("input gunmagazinecapacity:");
            //string gunmagazinecapacity = console.readline();
            //console.writeline("input gunnowmagazinebullet");
            //string gunnowmagazinebullet = console.readline();
            //console.writeline("input gunremainbullet");
            //string gunremainbullet = console.readline();
            //console.writeline("gunname:" + gunname +" "+
            //                  "gunmagazinecapacity:" + gunmagazinecapacity + " " +
            //                  "gunnowmagazinebullet:" + gunnowmagazinebullet + " " +
            //                  "gunremainbullet:" + gunremainbullet);
            //console.readline();

            //错误的代码，有问题调试
            //float num01 = 1.0f;
            //float num02 = 0.9f;
            //float result = num01 - num02;
            //bool result1 = result == 0.1;
            //Console.WriteLine(result1);

            //改进后
            //decimal num01 = 1.0m;
            //decimal num02 = 0.9m;
            //decimal result = num01 - num02;
            //bool result1 = result == 0.1m;
            //Console.WriteLine(result1);

            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"hello {name.ToUpper()}!");
                
            }
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
              Console.WriteLine("hello "+name.ToUpper()+"!");
            }

            Console.WriteLine($"My name is {names[0]}.");
            //Console.WriteLine("I've added "+names[0]+" and "+names[3]+" to the list.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            //Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

            var index = names.IndexOf("Felipe");
            if (index != -1)
              Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
        }

        //字符串输入，输出
        static void Main1(string[] args)
        {
            //语句
            Console.Title = "My First Program";
            Console.WriteLine("Put Your Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Hi!" + Name);
            Console.ReadLine();
            string gunName="AK 47";
            int intAge = 19;
        }
    }
}
