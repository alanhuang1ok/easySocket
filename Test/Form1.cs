using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int offset = 0;
            //开辟空间
            //Byte[] buffer = getPacket(ref offset);
            //string result=println(buffer);
            //txt_result.Text = result;

            //测试模板
            new TcpClientTemplate().SendMessage(new UserInfoClientPacket(1,"name"));
        }
        private Byte[] getPacket(ref int offset)
        {
            //开辟空间
            Byte[] buffer = new Byte[1024];
            if (!string.IsNullOrEmpty(txt_int.Text))
            {
                int temp = Convert.ToInt32(txt_int.Text);
                BufferHelper.WriteInt32(buffer, temp, ref offset);
            }
            if (!string.IsNullOrEmpty(txt_string.Text))
            {
                BufferHelper.WriteString(buffer, txt_string.Text, ref offset);
            }
            if (!string.IsNullOrEmpty(txt_bool.Text))
            {
                bool temp = Convert.ToBoolean(txt_bool.Text);
                BufferHelper.WriteBoolean(buffer, temp, ref offset);
            }

            //目标数组
            Byte[] tagBuffer = new Byte[offset];
            Array.Copy(buffer, 0, tagBuffer, 0, offset);
            return tagBuffer;
        }

        public static string println(byte[] buff)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in buff)
            {
                sb.Append(b.ToString());
            }
            return sb.ToString();

        }
    }
}
