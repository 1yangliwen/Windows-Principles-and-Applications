using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("8B2661F6-1138-40AA-9B88-5D6A48EFB22D")]
    internal interface IExpress
    {
        string Minus(int a, int b);
        string Divide(int a, int b);
    }
}
