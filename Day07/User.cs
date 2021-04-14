using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    /// <summary>
    /// 用户类
    /// </summary>
    class User
    {
        //字段
        private string loginld;

        //属性
        public string Loginld
        {
            get
            { return this.loginld; }
            set
            { this.loginld = value; }
        }

        //自动属性 包含1个字段 2个方法
        public string Password { get; set; }

        //构造函数
        public User()
        {

        }
        public User(string loginld,string pwd)
        {
            this.loginld = loginld;
            this.Password = pwd;
        }

        //方法
        public void PrintUser()
        {
            Console.WriteLine("账号：{0}，密码：{1}", loginld, Password);
        }
    }
}
