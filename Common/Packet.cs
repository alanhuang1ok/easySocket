using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    /// <summary>
    /// 作者：alan (黄铭烺)
    /// 说明：封包类
    /// </summary>
    public abstract class Packet
    {
        /// <summary>
        /// 消息包长度
        /// </summary>
        public int msgLength { get; set; }

        public int commands { get; set; }
        /// <summary>
        /// 封包
        /// </summary>
        /// <returns></returns>
        public abstract byte[] GetPacketBytes(out int offset);
        /// <summary>
        /// 解包
        /// </summary>
        /// <returns></returns>
        public abstract void ResolvePacket(byte[] packetByte);

        public byte[] DoGetPacketBytes()
        {
            int leng= sizeof(int);
            int offset = 0;
            byte[] buffer = GetPacketBytes(out offset);
            int msgLength = offset + leng*2;

            Byte[] tagBuffer = new Byte[msgLength];
            int newOffset = 0;
            BufferHelper.WriteInt32(tagBuffer, msgLength, ref newOffset); //包长度
            BufferHelper.WriteInt32(tagBuffer, commands, ref newOffset); //指令
            Array.Copy(buffer, 0, tagBuffer, leng*2, offset);
            return tagBuffer;
        }


        #region 通用方法

        #region 读写byte (byte 0 到 255,无符号 8 位整数)
        public void WriteByte(Byte[] buffer, Byte value, ref Int32 offset)
        {
            buffer[offset++] = value;
        }
        public Byte ReadByte(Byte[] buffer, ref Int32 offset)
        {
            Byte value = buffer[offset++];
            return value;
        }
        #endregion

        #region 读写Int32  4byte(字节)  (byte 0 到 255,无符号 8 位整数)
        public void WriteInt32(Byte[] buffer, Int32 value, ref Int32 offset)
        {
            //将基础数据类型与字节数组相互转换
            byte[] bTemp = BitConverter.GetBytes(value);
            for (Int32 i = 0; i < bTemp.Length; i++)
            {
                buffer[offset++] = bTemp[i];
            }
        }
        public Int32 ReadInt32(Byte[] buffer, ref Int32 offset)
        {
            Int32 value = BitConverter.ToInt32(buffer, offset);

            offset += 4;

            return value;
        }
        #endregion

        #region 读写Float
        public void WriteFloat(Byte[] buffer, float value, ref Int32 offset)
        {
            byte[] bTemp = BitConverter.GetBytes(value);
            for (Int32 i = 0; i < bTemp.Length; i++)
            {
                buffer[offset++] = bTemp[i];
            }
        }
        public Single ReadFloat(Byte[] buffer, ref Int32 offset)
        {
            Single value = BitConverter.ToSingle(buffer, offset);

            offset += 4;

            return value;
        }
        #endregion

        #region 读写Boolean
        public void WriteBoolean(Byte[] buffer, bool value, ref Int32 offset)
        {
            byte[] bTemp = BitConverter.GetBytes(value);
            for (Int32 i = 0; i < bTemp.Length; i++)
            {
                buffer[offset++] = bTemp[i];
            }
        }
        public Boolean ReadBoolean(Byte[] buffer, ref Int32 offset)
        {
            Boolean value = BitConverter.ToBoolean(buffer, offset);

            offset += 1;

            return value;
        }
        #endregion

        #region  读写String
        public void WriteString(Byte[] buffer, String value, ref Int32 offset)
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
        public String ReadString(Byte[] buffer, ref Int32 offset)
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
        public void WriteInt64(Byte[] buffer, long value, ref Int32 offset)
        {
            //将基础数据类型与字节数组相互转换
            byte[] bTemp = BitConverter.GetBytes(value);
            for (Int32 i = 0; i < bTemp.Length; i++)
            {
                buffer[offset++] = bTemp[i];
            }
        }
        public Int64 ReadInt64(Byte[] buffer, ref Int32 offset)
        {
            Int64 value = BitConverter.ToInt64(buffer, offset);
            offset += 8;//可能有错
            return value;
        }
        #endregion

        #endregion

    }
}
