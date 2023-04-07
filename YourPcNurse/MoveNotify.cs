using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourPcNurse
{
    public partial class MoveNotify : Form
    {
        public MoveNotify()
        {

            InitializeComponent();
        }
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);


        private async void MoveNotify_Load(object sender, EventArgs e)
        {
            MoveController.moveRightBottom(this);

            IntPtr hWnd = this.Handle;
            SetForegroundWindow(hWnd);

            var yourPcNurse = (YourPcNurse)Application.OpenForms["YourPcNurse"];
            await Task.Delay(4000);

            yourPcNurse.moveTimer.Start();
            Notify.CloseNotify(this);

        }


        private void MoveNotify_MouseClick(object sender, MouseEventArgs e)
        {
            Notify.CloseNotify(this);

        }
    }
}
