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
        private short version = 1;
        public YourPcNurse()
        {
            InitializeComponent();
        }
        int moveTimeCounter = 0;
        int eyeTimeCounter = 0;
        int eyeTimeSecondCounter = 0;
        int moveTimeSecondCounter = 0;

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

        private void YourPcNurse_Load(object sender, EventArgs e)
        {
            MoveController.moveCenter(this);
            lblVersion.Text = $" v{version}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            eyeTimer.Start();
            moveTimer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            eyeTimer.Stop();
            moveTimer.Stop();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            eyeTimer.Stop();
            moveTimer.Stop();
            moveTimeCounter = 0;
            eyeTimeCounter = 0;
            eyeTimeSecondCounter = 0;
            moveTimeSecondCounter = 0;
            lblEyeMin.Text = "00";
            lblEyeSn.Text = "00";
            lblMoveMin.Text = "00";
            lblMoveSn.Text = "00";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
