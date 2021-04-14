﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2048
{
    /// <summary>
    /// 定义枚举类型：移动方向
    /// </summary>
    enum MoveDirection:long//默认int
    {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3,
    }
}
