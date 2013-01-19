using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public abstract class ServerPacket
    {
        /// <summary>
        /// 消息包长度
        /// </summary>
        public int msgLength { get; set; }

        /// <summary>
        /// 解包
        /// </summary>
        /// <returns></returns>
        public abstract void ResolvePacket(byte[] packetByte);


    }
}
