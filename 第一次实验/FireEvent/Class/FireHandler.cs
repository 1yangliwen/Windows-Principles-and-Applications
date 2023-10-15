using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireEvent.Class
{
    public class FireHandler
    {
        public void HandleFire1(object sender, FireEventArgs e)
        {
            MessageBox.Show($"Handler 1 received fire event: {e.Message}");
        }

        public void HandleFire2(object sender, FireEventArgs e)
        {
            MessageBox.Show($"Handler 2 received fire event: {e.Message}");
        }
    }
}
