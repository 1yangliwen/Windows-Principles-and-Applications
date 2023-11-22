using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("8B2661F6-1138-40AA-9B88-5D6A48EFB22D")]
    public class Express
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