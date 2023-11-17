using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CopyDataStruct
{
    public class MessageConstants
    {
        // WM_COPYDATA的消息常量
        public const int WM_COPYDATA = 0x004A;
    }

    // 定义COPYDATASTRUCT结构体
    [StructLayout(LayoutKind.Sequential)]
    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;    // 消息标识，可以根据需要自定义
        public int cbData;       // 消息数据的大小
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;    // 指向消息数据的指针
    }
}
