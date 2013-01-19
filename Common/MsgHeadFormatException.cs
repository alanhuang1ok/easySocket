using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class MsgHeadFormatException : ApplicationException
    {
        public MsgHeadFormatException()
            : base("信息头格式异常!")
        { }

        public MsgHeadFormatException(string message)
            : base(message)
        {

        }
    }
}