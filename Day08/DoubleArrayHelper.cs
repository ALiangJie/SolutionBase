using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    /// <summary>
    /// 二维数组助手类
    /// </summary>
    class DoubleArrayHelper
    {
        /// <summary>
        /// 获取二维数组元素
        /// </summary>
        /// <param name="array">二维数组</param>
        /// <param name="rIndex">行索引</param>
        /// <param name="cIndex">列索引</param>
        /// <param name="dir">方向</param>
        /// <param name="count">查找的数量</param>
        /// <returns>所有满足条件的元素</returns>

        public static string[] GetElements(string[,] array,int rIndex,int cIndex,Direction dir,int count)
        {
            List<string> result = new List<string>(count);
            for(int i = 0; i < count; i++)
            {
                rIndex += dir.RIndex;//-1
                cIndex += dir.CIndex;//0
                if (rIndex >= 0 && rIndex < array.GetLength(0) && cIndex>=0 && cIndex<array.GetLength(0))
                    result.Add(array[rIndex, cIndex]);
            }
            return result.ToArray();
        }

    }
}
