using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PingCommunicator
{
    public class AsyncPing
    {
        public event Action<string> OnPingCompleted; // 事件，当ping完成一次时触发
        public async Task PerformPingAsync(string ipAddress)
        {
            // 如果IP地址为空，使用默认值
            string defaultIP = String.IsNullOrEmpty(ipAddress) ? "www.sohu.com" : ipAddress;

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "ping",
                    Arguments = $"{defaultIP} -n 10",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            while (!process.StandardOutput.EndOfStream)
            {
                var line = await process.StandardOutput.ReadLineAsync();
                OnPingCompleted?.Invoke(line); // 触发事件，而不是直接写入TextBox
            }
        }
    }
}
