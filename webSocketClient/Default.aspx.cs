using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Configuration;

namespace webSocketClient
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private static byte[] result = new byte[1024];
        protected void callSocket_Click(object sender, EventArgs e)
        {
            //设定服务器IP地址  
            string ipStr = ConfigurationSettings.AppSettings["ip"];
            IPAddress ip = IPAddress.Parse(ipStr); //192.168.0.254
            string portStr = ConfigurationSettings.AppSettings["port"];
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, Convert.ToInt32(portStr))); //配置服务器IP与端口  
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
                Thread.Sleep(1000);    //等待1秒钟  
                string sendMessage = " [ client send Message Hellp ]   time: " + DateTime.Now;
                clientSocket.Send(Encoding.ASCII.GetBytes(sendMessage));
                lab_result.Text = String.Format("向服务器发送消息：" + sendMessage);

            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                //break;
            }
        }
    }
}
