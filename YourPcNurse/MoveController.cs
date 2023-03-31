using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourPcNurse
{
    public static class MoveController
    {
        public static void moveCenter(Form form)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = form.Width;
            int formHeight = form.Height;

            int formX = (screenWidth - formWidth) / 2;
            int formY = (screenHeight - formHeight) / 2;

            form.Location = new Point(formX, formY);
        }
        public static void moveRightBottom(Form form)
        {
           
            int formWidth = form.Width;
            int formHeight = form.Height;

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formX = screenWidth - formWidth - 10;
            int formY = screenHeight - formHeight - 10;

            form.Location = new Point(formX, formY);
        }
    }
}
