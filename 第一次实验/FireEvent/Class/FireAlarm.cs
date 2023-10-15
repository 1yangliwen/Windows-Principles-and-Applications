using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEvent.Class
{
    public class FireAlarm
    {
        public event EventHandler<FireEventArgs> FireEvent;

        public void RaiseFireEvent(string message)
        {
            FireEvent?.Invoke(this, new FireEventArgs { Message = message });
        }
    }
}
