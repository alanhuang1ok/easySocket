using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Test
{
    public class UserInfoClientPacket : Packet
    {

       private int id {get;set;}
        private string name{get;set;}
        public UserInfoClientPacket() { }
        public UserInfoClientPacket(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        /// <summary>
        /// 封包
        /// </summary>
        /// <returns></returns>
        public override byte[] GetPacketBytes(out int offset)
        {
            offset = 0;
            Byte[] buffer = new Byte[1024];
            WriteInt32(buffer, this.id, ref offset);
            WriteString(buffer, this.name, ref offset);
            return buffer;
        }
        /// <summary>
        /// 解包
        /// </summary>
        /// <param name="packetByte"></param>
        public override void ResolvePacket(byte[] packetByte)
        {
            int offset = 0;
            int msgLength = ReadInt32(packetByte, ref  offset);
            this.id = ReadInt32(packetByte, ref  offset);
            this.name = ReadString(packetByte, ref  offset);
        }

    }
}
