using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using Common;

namespace TestServer
{
    class Program
    {
        private static int myProt = 8885;   //端口  
        static Socket serverSocket;
        static Dictionary<int, string> packets = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory + "==========-------============");
            
            /* MonitorPackets ps = new MonitorPackets();
            MonitorPacket[] temp = new MonitorPacket[] { new MonitorPacket(0, "okok"), new MonitorPacket(2, "222222222222") };
            ps.packets = temp;
            XMLSerialization.SaveXml(Commons.RootPath + "packets.xml", ps, typeof(MonitorPackets));  */
            packets.Add(0, "TestServer.UserInfoServerPacket");
            packets.Add(1, "TestServer.UserInfoServerPacket");
            packets.Add(2, "TestServer.UserInfoServerPacket");
            string ipstr = System.Configuration.ConfigurationSettings.AppSettings["ip"];
            string port = System.Configuration.ConfigurationSettings.AppSettings["port"];
            //服务器IP地址  
            IPAddress ip = IPAddress.Parse(ipstr);//"192.168.0.254"
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(ip, Convert.ToInt32(port)));  //绑定IP地址：端口  
            serverSocket.Listen(10);    //设定最多10个排队连接请求  
            Console.WriteLine("启动监听{0}成功", serverSocket.LocalEndPoint.ToString());
            //通过Clientsoket发送数据  
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();
            Console.ReadLine();
        }
        /// <summary>  
        /// 监听客户端连接  
        /// </summary>  
        private static void ListenClientConnect()
        {
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                clientSocket.Send(Encoding.ASCII.GetBytes("Server Say Hello"));
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);
            }
        }

        /// <summary>  
        /// 接收消息  
        /// </summary>  
        /// <param name="clientSocket"></param>  
        private static void ReceiveMessage(object clientSocket)
        {
            byte[] result = new byte[1024];
            //客户端
            Socket myClientSocket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据  
                    int receiveNumber = myClientSocket.Receive(result);
                  


                    if (receiveNumber != 0)
                    {
                        //Console.WriteLine("接收客户端{0}消息{1}", myClientSocket.RemoteEndPoint.ToString(), Encoding.ASCII.GetString(result, 0, receiveNumber));
                        //解包
                        int offset=0;
                        BufferHelper.ReadInt32(result, ref offset);
                        int key = BufferHelper.ReadInt32(result, ref offset);

                        Type type = Type.GetType(packets[key]);

                        System.Reflection.Assembly a = System.Reflection.Assembly.GetAssembly(type);
                        //根据名称创建对象实例
                        Packet obj = (Packet)a.CreateInstance(packets[key]);


                        UserInfoServerPacket user = new UserInfoServerPacket();
                        obj.ResolvePacket(result);
                        Console.WriteLine("数据包长度: " + obj.msgLength);
                        Console.WriteLine("id: " + user.id);
                        Console.WriteLine("name: " + user.name);
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Close();
                    break;
                }
            }
        }
    }
}
