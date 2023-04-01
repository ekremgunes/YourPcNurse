using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourPcNurse
{
    public static class Notify
    {
        public static void CloseNotify(Form form)
        {
            Timer timer = new Timer();
            timer.Interval = 25;
            timer.Tick += (s, ev) =>
            {

                if (form.Opacity > 0)
                {
                    form.Opacity -= 0.05;
                }
                else
                {
                    timer.Stop();
                    form.Close();
                }
            };
            timer.Start();
        }
       
    }
}
