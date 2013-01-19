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
    public partial class UserWin : Form
    {
        public UserWin()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (!string.IsNullOrEmpty(txt_id.Text))
                id = Convert.ToInt32(txt_id.Text);
            string name = txt_name.Text;
            new TcpClientTemplate().SendMessage(new UserInfoClientPacket(id, name));
        }
    }
}
