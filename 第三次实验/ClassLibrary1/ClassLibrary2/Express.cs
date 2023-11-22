using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("CA619F2D-F4EE-4B24-B3FF-5D613614E89F")]
    public class Express : IExpress
    {
        public string Minus(int a, int b)
        {
            int result = a - b;
            return $"{result} = {a} - {b}";
        }

        public string Divide(int a, int b)
        {
            if (b == 0)
                return "除零错误";
            else
            {
                int result = a / b;
                return $"{result} = {a} / {b}";
            }
        }
    }
}
