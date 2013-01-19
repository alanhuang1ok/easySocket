using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace TestServer
{
    public class UserInfoServerPacket : Packet
    {

        public int id { get; set; }
        public string name { get; set; }
        public UserInfoServerPacket() { }
        public UserInfoServerPacket(int id, string name)
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
            Byte[] buffer = new Byte[1024];//确保容量足够
            WriteInt32(buffer,this.id,ref offset);
            WriteString(buffer, this.name, ref offset);
            return buffer;
        }
        /// <summary>
        /// 解包
        /// </summary>
        /// <param name="packetByte"></param>
        public override void ResolvePacket(byte[] packetByte)
        {
            int offset=0;
            this.msgLength= ReadInt32(packetByte, ref  offset);
            this.commands = ReadInt32(packetByte, ref  offset);
            this.id=ReadInt32(packetByte,ref  offset);
            this.name = ReadString(packetByte, ref  offset);
        }
    }
}
