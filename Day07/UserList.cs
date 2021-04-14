using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    /// <summary>
    /// 用户集合类
    /// </summary>
    class UserList
    {
        //*********字段*********
        private User[] data;
        private int currentIndex;

        //*********属性*********
        /// <summary>
        /// 有效元素个数
        /// </summary>
        public int Count
        {
            get
            { return currentIndex; }
        }

        //*********构造函数*********
        public UserList():this(8)
        {
            //data = new User[8];
        }
        public UserList(int capacity)
        {
            data = new User[capacity];
        }

        //*********方法*********

        //添加
        public void Add(User value)
        {
            CheckCapacity();

            data[currentIndex++] = value;
            //如果容量不够？
            //扩容：开辟更大的数组    拷贝原始数据  替换引用
        }

        //读取
         public User GetElement(int index)
         {
              return data[index];
         }

        //检查容量
        private void CheckCapacity()
        {
            if (currentIndex >= data.Length)
            {
                User[] newData = new User[data.Length * 2];
                data.CopyTo(newData, 0);
                data = newData;
            }

        }

    }
}
