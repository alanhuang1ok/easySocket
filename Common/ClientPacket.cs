using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public abstract class ClientPacket
    {
        /// <summary>
        /// 消息包长度
        /// </summary>
        public int msgLength { get; set; }

        public abstract byte[] GetPacketBytes();
    }
}
