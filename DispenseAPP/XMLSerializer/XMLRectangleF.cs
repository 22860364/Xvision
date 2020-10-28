using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DispenseAPP.XMLSerializer
{
    /// <summary>
    /// 
    /// </summary>
    public class XMLRectangleF
    {
        /// <summary>
        /// 用于序列化
        /// </summary>
        public XMLRectangleF()
        {

        }

        /// <summary>
        /// 用指定的位置和大小初始化XMLRectangleF的实例
        /// </summary>
        /// <param name="x">矩形左上角x</param>
        /// <param name="y">矩形右上角y</param>
        /// <param name="width">矩形的宽</param>
        /// <param name="height">矩形的高</param>
        public XMLRectangleF(float x,float y,float width,float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// 获得或设置此XMLRectangleF实例左上角的Y坐标
        /// </summary>
        public float X { get; set; } = 0f;

        /// <summary>
        /// 获取或设置此XMLRectangleF实例左上角的X坐标
        /// </summary>
        public float Y { get; set; } = 0f;

        /// <summary>
        /// 获取或设置此XMLRectangleF实例的宽度
        /// </summary>
        public float Width { get; set; } = 0f;

        /// <summary>
        /// 获取或设置此XMLRectangleF实例的高度
        /// </summary>
        public float Height { get; set; } = 0f;

        /// <summary>
        /// 创建System.Drawing.RectangleF 从XMLRectangleF
        /// </summary>
        /// <param name="xmlRectangleF">指定的XMLRectangleF</param>
        /// <returns>System.Drawing.RectnagleF 此方法创建的实例</returns>
        public static RectangleF FormXMLRectangleF(XMLRectangleF value)
        {
            return new RectangleF(value.X, value.Y, value.Width, value.Height);
        }
    }
}
