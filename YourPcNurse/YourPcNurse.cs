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
    public partial class YourPcNurse : Form
    {
        public YourPcNurse()
        {
            InitializeComponent();
        }
        private short appUsingMin = 0;
        private int appUsingHours = 0;
        private int moveTimeCounter = 0;
        private int eyeTimeCounter = 0;
        private int eyeTimeSecondCounter = 0;
        private int moveTimeSecondCounter = 0;
        private bool isStoped = false;
        
        #region tickEvents
        private void appTimer_Tick(object sender, EventArgs e)
        {
            appUsingMin++;
            if (appUsingMin == 60)
            {
                appUsingHours++;
                appUsingMin = 0;
            }
            if (appUsingHours > 0)
            {
                minToolStripMenuItem.Text = $"{appUsingHours} h | {appUsingMin} min";
            }
            else
            {
                minToolStripMenuItem.Text = $"{appUsingMin} min";

            }
        }

        private void eyeTimer_Tick(object sender, EventArgs e)
        {
            eyeTimeSecondCounter++;
            if (eyeTimeSecondCounter < 10) // default 12:1 - this make 12:01
            {
                lblEyeSn.Text = $"0{eyeTimeSecondCounter}";
            }
            else
            {
                lblEyeSn.Text = eyeTimeSecondCounter.ToString();
            }
            if (eyeTimeSecondCounter / 60 == 1) // 1 is mean equal one min
            {
                eyeTimeCounter++;
                if (eyeTimeCounter < 10) // default 1:34  - this make  01:34
                {
                    lblEyeMin.Text = $"0{eyeTimeCounter}";
                }
                else
                {
                    lblEyeMin.Text = eyeTimeCounter.ToString();
                }
                eyeTimeSecondCounter = 0;
                lblEyeSn.Text = "00";

            }
            if (eyeTimeCounter == 25) // 25 min
            {
                var eyeNotfiy = new EyeNotify();
                eyeNotfiy.Show();
                eyeTimeCounter = 0;
                lblEyeMin.Text = "00";
            }
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            moveTimeSecondCounter++;
            if (moveTimeSecondCounter < 10) // default 12:1 - this make 12:01
            {
                lblMoveSn.Text = $"0{moveTimeSecondCounter}";
            }
            else
            {
                lblMoveSn.Text = moveTimeSecondCounter.ToString();
            }
            if (moveTimeSecondCounter / 60 == 1) // 1 is mean equal one min
            {
                moveTimeCounter++;
                if (moveTimeCounter < 10) // default 1:34  - this make  01:34
                {
                    lblMoveMin.Text = $"0{moveTimeCounter}";
                }
                else
                {
                    lblMoveMin.Text = moveTimeCounter.ToString();
                }
                moveTimeSecondCounter = 0;
                lblMoveSn.Text = "00";

            }

            if (moveTimeCounter == 55) // 55 min.
            {
                var moveNotfiy = new MoveNotify();
                moveNotfiy.Show();

                moveTimeCounter = 0;
                lblMoveMin.Text = "00";
            }
        }
        #endregion


        #region buttons



        private void btnStart_Click(object sender, EventArgs e)
        {
            eyeTimer.Start();
            moveTimer.Start();
            if (isStoped != true)
            {
                appTimer.Start();

            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            eyeTimer.Stop();
            moveTimer.Stop();
            isStoped = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            eyeTimer.Stop();
            moveTimer.Stop();
            appTimer.Stop();
            appUsingMin = 0;
            appUsingHours = 0;
            moveTimeCounter = 0;
            eyeTimeCounter = 0;
            eyeTimeSecondCounter = 0;
            moveTimeSecondCounter = 0;
            lblEyeMin.Text = "00";
            lblEyeSn.Text = "00";
            lblMoveMin.Text = "00";
            lblMoveSn.Text = "00";
            minToolStripMenuItem.Text = "0 min";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region menuStripMethods


        private void appIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void ReturnTheAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eyeTimer.Start();
            moveTimer.Start();
            if (isStoped != true)
            {
                appTimer.Start();

            }
        }

        private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eyeTimer.Stop();
            moveTimer.Stop();
            isStoped = true;
        }

        private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void YourPcNurse_Load(object sender, EventArgs e)
        {
            MoveController.moveCenter(this);
        }


    }
}
