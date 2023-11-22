using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("98ED9E4B-97D5-4772-9C31-F83C95F3887C")]
    public interface IExpress
    {
        string Minus(int a, int b);
        string Divide(int a, int b);
    }
}
