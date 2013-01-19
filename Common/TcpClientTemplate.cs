using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Common
{
    public class TcpClientTemplate
    {
        public void SendMessage(Packet  clientPacket)
        {
            byte[] result = new byte[1024];
            //设定服务器IP地址  
            IPAddress ip = IPAddress.Parse("192.168.0.22");
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, 11111)); //配置服务器IP与端口  
                Console.WriteLine("连接服务器成功");
            }
            catch
            {
                Console.WriteLine("连接服务器失败，请按回车键退出！");
                return;
            }
            //通过clientSocket接收数据  
            int receiveLength = clientSocket.Receive(result);
            Console.WriteLine("接收服务器消息：{0}", Encoding.ASCII.GetString(result, 0, receiveLength));
            //通过 clientSocket 发送数据  

            try
            {
                //string sendMessage = "client send Message Hellp" + DateTime.Now;
                //clientSocket.Send(Encoding.ASCII.GetBytes(sendMessage));
                clientSocket.Send(clientPacket.DoGetPacketBytes());
                //Console.WriteLine("向服务器发送消息：{0}" + sendMessage);
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            
        }
    }
}
