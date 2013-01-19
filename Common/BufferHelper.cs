using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    /// <summary>
    /// alan 编码辅助类
    /// </summary>
    public class BufferHelper
    {

        #region 读写Int32  4byte(字节)  (byte 0 到 255,无符号 8 位整数)
        public static void WriteInt32(Byte[] buffer, Int32 value, ref Int32 offset)
        {
            //将基础数据类型与字节数组相互转换
            byte[] bTemp = BitConverter.GetBytes(value);
            for (Int32 i = 0; i < bTemp.Length; i++)
            {
                buffer[offset++] = bTemp[i];
            }
        }
        public static Int32 ReadInt32(Byte[] buffer, ref Int32 offset)
        {
            Int32 value = BitConverter.ToInt32(buffer, offset);
 
            offset += 4;
 
            return value;
        }
        #endregion

        #region 读写Float
        public static void WriteFloat(Byte[] buffer, float value, ref Int32 offset)
        {
            byte[] bTemp = BitConverter.GetBytes(value);
            for (Int32 i = 0; i < bTemp.Length; i++)
            {
                buffer[offset++] = bTemp[i];
            }
        }
        public static Single ReadFloat(Byte[] buffer, ref Int32 offset)
        {
            Single value = BitConverter.ToSingle(buffer, offset);
 
            offset += 4;
 
            return value;
        }
        #endregion

        #region 读写Boolean
        public static void WriteBoolean(Byte[] buffer, bool value, ref Int32 offset)
        {
            byte[] bTemp = BitConverter.GetBytes(value);
            for (Int32 i = 0; i < bTemp.Length; i++)
            {
                buffer[offset++] = bTemp[i];
            }
        }
        public static Boolean ReadBoolean(Byte[] buffer, ref Int32 offset)
        {
            Boolean value = BitConverter.ToBoolean(buffer, offset);
 
            offset += 1;
 
            return value;
        }
        #endregion

        #region  读写String
        public static void WriteString(Byte[] buffer, String value, ref Int32 offset)
        {
            if (!String.IsNullOrEmpty(value))
            {
                byte[] bTemp = Encoding.UTF8.GetBytes(value);
 
                WriteInt32(buffer, bTemp.Length, ref offset);
                for (Int32 i = 0; i < bTemp.Length; i++)
                {
                    buffer[offset++] = bTemp[i];
                }
            }
            else
            {
                WriteInt32(buffer, 0, ref offset);
            }
        }
        public static String ReadString(Byte[] buffer, ref Int32 offset)
        {
            Int32 len = ReadInt32(buffer, ref offset);
 
            String str = String.Empty;
 
            if (len > 0)
            {
                Byte[] bTemp = new Byte[len];
                Buffer.BlockCopy(buffer, offset, bTemp, 0, len);
                offset += len;
                str = Encoding.UTF8.GetString(bTemp);
            }
            return str;
        }
        #endregion

        #region 读写Int64 long
        public static void WriteInt64(Byte[] buffer, long value, ref Int32 offset)
        {
            //将基础数据类型与字节数组相互转换
            byte[] bTemp = BitConverter.GetBytes(value);
            for (Int32 i = 0; i < bTemp.Length; i++)
            {
                buffer[offset++] = bTemp[i];
            }
        }
        public static Int64 ReadInt64(Byte[] buffer, ref Int32 offset)
        {
            Int64 value = BitConverter.ToInt64(buffer, offset);
            offset += 8;//可能有错
            return value;
        }
        #endregion

    }
}

