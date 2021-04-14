using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    /// <summary>
    /// 人 类
    /// </summary>
    class Person
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        //仅仅本“家族”使用，继承使用
        protected int a;
    }
}
