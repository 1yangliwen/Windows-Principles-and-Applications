using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEvent.Class
{
    public class FireEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string Level { get; set; }
        public string Location { get; set; }

    }
}
