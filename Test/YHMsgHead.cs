using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Test
{
    /// <summary>
    /// 游戏信息头
    /// </summary>
    class YHMsgHead
    {
        //byte 0 到 255
       public byte[] msgLen; //两个字节长度	 
       public byte[] msgId;
       public byte[] msgSubId;
       public void BuilderHeader(byte[] msgLen, byte[] msgId, byte[] msgSubId) 
       {

           if (msgLen.Length != 2 || msgId.Length != 2 || msgSubId.Length!=2)
                   throw new  MsgHeadFormatException();
           
           this.msgLen = msgLen;
           this.msgId = msgId;
           this.msgSubId = msgSubId;
       }
    }
}
