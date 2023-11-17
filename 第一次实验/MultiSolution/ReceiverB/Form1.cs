using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyDataStruct;

namespace ReceiverB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "ReceiverB Window";
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == MessageConstants.WM_COPYDATA)
            {
                COPYDATASTRUCT cds = (COPYDATASTRUCT)m.GetLParam(typeof(COPYDATASTRUCT));
                string message = cds.lpData;
                DateTime receiveTime = DateTime.Now;

                // 在这里你可以更新你的UI控件，例如一个标签或文本框
                txtMessage.Text = message;
                // 在列表框中显示消息内容和接收时间
                lstMessages.Items.Add($"{receiveTime:HH:mm:ss} - {message}");
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }
    }
}
