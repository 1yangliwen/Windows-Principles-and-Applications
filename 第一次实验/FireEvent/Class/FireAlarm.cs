using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace FireEvent.Class
{
    public class FireAlarm
    {
        public event EventHandler<FireEventArgs> FireEvent;

        public void RaiseFireEvent(string message, string level, string location)
        {
            FireEvent?.Invoke(this, new FireEventArgs { Message = message, Level = level, Location = location});
        }
    }
}
    