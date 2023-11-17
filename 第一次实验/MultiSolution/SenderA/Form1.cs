using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CopyDataStruct;

namespace SenderA
{
    public partial class Form1 : Form
    {
        // 使用P/Invoke导入FindWindow函数
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // 使用P/Invoke导入SendMessage函数
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref COPYDATASTRUCT lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string targetWindowName = txtTargetWindowName.Text;
            string message = txtMessage.Text;

            // 使用FindWindow函数查找目标窗体
            IntPtr targetHWnd = FindWindow(null, targetWindowName);

            if (targetHWnd == IntPtr.Zero) // 判断是否找到窗体
            {
                MessageBox.Show("目标窗体未找到！");
                return;
            }

            // 创建COPYDATASTRUCT结构并填充消息内容
            COPYDATASTRUCT cds = new COPYDATASTRUCT();
            cds.dwData = IntPtr.Zero;
            cds.lpData = message;
            cds.cbData = message.Length + 1;

            // 使用SendMessage函数发送消息
            SendMessage(targetHWnd, MessageConstants.WM_COPYDATA, this.Handle, ref cds);
        }
    
    }
}
