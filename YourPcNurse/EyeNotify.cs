using System;
using System.Runtime.InteropServices;
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
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        private async void EyeNotify_Load(object sender, EventArgs e)
        {
            MoveController.moveRightBottom(this);
            
            IntPtr hWnd = this.Handle;
            SetForegroundWindow(hWnd);

            var yourPcNurse = (YourPcNurse)Application.OpenForms["YourPcNurse"];
            await Task.Delay(3750);

            yourPcNurse.eyeTimer.Start();
            Notify.CloseNotify(this);
        }

        private void EyeNotify_MouseClick(object sender, MouseEventArgs e)
        {
            Notify.CloseNotify(this);
        }
    }
}
