using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PingCommunicator
{
    public class SyncPing
    {
/*        private TextBox _outputTextBox;

        public AsyncPing(TextBox outputTextBox)
        {
            _outputTextBox = outputTextBox;
        }
*/

        public string PerformPing(string ipAddress)
        {
            // 如果IP地址为空，使用默认值
            string defaultIP = String.IsNullOrEmpty(ipAddress) ? "www.sohu.com" : ipAddress;
            string pingArgs = $"ping {defaultIP} -n 10";

            // 设置进程信息
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardInput = true,// 重定向标准输出，这样就可以在程序中读取ping命令的结果
                RedirectStandardOutput = true,
                CreateNoWindow = true, // 不创建新窗口
                UseShellExecute = false // 不使用系统shell执行命令，这样可以重定向
            };

            // 启动进程
            using (Process process = Process.Start(psi))
            {
                // 写入ping命令
                process.StandardInput.WriteLine(pingArgs);
                process.StandardInput.Close(); // 关闭输入流

                // 读取输出
                string output = process.StandardOutput.ReadToEnd();

                // 等待进程结束
                process.WaitForExit();

                return output; // 返回ping命令的结果
            }
        }
    }
}
