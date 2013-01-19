using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml.Serialization;

namespace TestServer
{
     [XmlRootAttribute("packets1")]
    public class MonitorPacket
    {
        public MonitorPacket(int command, string action)
        {
            this.command = command;
            this.action = action;
        }
        [XmlElementAttribute("command")]
        public int command{get;set;}
        [XmlElementAttribute("action")]
        public string action {get; set;}
    }
    [XmlRootAttribute("Root")]
    public class MonitorPackets
    {
       [XmlArray("TeamMembers")]  
        public  MonitorPacket[] packets { get;set;}

       
    }
}
