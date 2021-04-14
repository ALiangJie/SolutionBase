using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    /// <summary>
    /// 方向
    /// </summary>
    class Direction
    {
        private int rIndex;

        public int RIndex
        {
            get
            { return this.rIndex; }
            set
            { this.rIndex = value; }
        }

        public int CIndex { get; set; }

        //类型与结构体的区别     因为结构体自带无参数构造函数，结构体不能包含无参数构造函数
        public Direction()
        { }

        public Direction(int rIndex,int cIndex)//:this()
        {
            //构造函数中，必须为所有字段赋值
            //:this()有参数构造函数 先调用无参数构造函数，为自动属性的字段赋值

            this.rIndex = rIndex;
            this.CIndex = cIndex;
        }

        public static Direction Up
        {
            get
            {
                return new Direction(-1, 0);
            }
        }

        public static Direction Down
        {
            get
            {
                return new Direction(1, 0);
            }
        }

        public static Direction Left
        {
            get
            {
                return new Direction(0, -1);
            }
        }

        public static Direction Right
        {
            get
            {
                return new Direction(0, 1);
            }
        }
    }
}
