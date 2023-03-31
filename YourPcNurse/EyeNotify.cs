using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourPcNurse
{
    public partial class EyeNotify : Form
    {
        public EyeNotify()
        {
            InitializeComponent();
        }

        private async void EyeNotify_Load(object sender, EventArgs e)
        {
            MoveController.moveRightBottom(this);
            await Task.Delay(3003);
            Notify.CloseNotify(this);
        }

        private void EyeNotify_MouseClick(object sender, MouseEventArgs e)
        {
            Notify.CloseNotify(this);
        }
    }
}
