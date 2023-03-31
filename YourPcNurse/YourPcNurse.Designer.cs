namespace YourPcNurse
{
    partial class YourPcNurse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourPcNurse));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMoveSn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEyeSn = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoveMin = new System.Windows.Forms.Label();
            this.lblEyeMin = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.eyeTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.appIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReturnTheAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(262, 214);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 24);
            this.btnClose.TabIndex = 31;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Mongolian Baiti", 7F);
            this.lblVersion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVersion.Location = new System.Drawing.Point(209, 26);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(15, 11);
            this.lblVersion.TabIndex = 30;
            this.lblVersion.Text = "v1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(88, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 39);
            this.label8.TabIndex = 29;
            this.label8.Text = ":";
            // 
            // lblMoveSn
            // 
            this.lblMoveSn.AutoSize = true;
            this.lblMoveSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMoveSn.ForeColor = System.Drawing.Color.White;
            this.lblMoveSn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMoveSn.Location = new System.Drawing.Point(110, 214);
            this.lblMoveSn.Name = "lblMoveSn";
            this.lblMoveSn.Size = new System.Drawing.Size(34, 25);
            this.lblMoveSn.TabIndex = 28;
            this.lblMoveSn.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(91, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 39);
            this.label6.TabIndex = 27;
            this.label6.Text = ":";
            // 
            // lblEyeSn
            // 
            this.lblEyeSn.AutoSize = true;
            this.lblEyeSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEyeSn.ForeColor = System.Drawing.Color.White;
            this.lblEyeSn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEyeSn.Location = new System.Drawing.Point(111, 110);
            this.lblEyeSn.Name = "lblEyeSn";
            this.lblEyeSn.Size = new System.Drawing.Size(39, 25);
            this.lblEyeSn.TabIndex = 26;
            this.lblEyeSn.Text = "00 ";
            // 
            // btnHide
            // 
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnHide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHide.Location = new System.Drawing.Point(252, 181);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(55, 30);
            this.btnHide.TabIndex = 25;
            this.btnHide.TabStop = false;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(132, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Your pc nurse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(49, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Move Timer";
            // 
            // lblMoveMin
            // 
            this.lblMoveMin.AutoSize = true;
            this.lblMoveMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblMoveMin.ForeColor = System.Drawing.Color.White;
            this.lblMoveMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMoveMin.Location = new System.Drawing.Point(44, 203);
            this.lblMoveMin.Name = "lblMoveMin";
            this.lblMoveMin.Size = new System.Drawing.Size(55, 39);
            this.lblMoveMin.TabIndex = 21;
            this.lblMoveMin.Text = "00";
            // 
            // lblEyeMin
            // 
            this.lblEyeMin.AutoSize = true;
            this.lblEyeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblEyeMin.ForeColor = System.Drawing.Color.White;
            this.lblEyeMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEyeMin.Location = new System.Drawing.Point(47, 99);
            this.lblEyeMin.Name = "lblEyeMin";
            this.lblEyeMin.Size = new System.Drawing.Size(55, 39);
            this.lblEyeMin.TabIndex = 20;
            this.lblEyeMin.Text = "00";
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 1000;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // eyeTimer
            // 
            this.eyeTimer.Interval = 1000;
            this.eyeTimer.Tick += new System.EventHandler(this.eyeTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Eye Timer";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClear.Location = new System.Drawing.Point(252, 145);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 30);
            this.btnClear.TabIndex = 19;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStart.Location = new System.Drawing.Point(252, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 31);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnPause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPause.Location = new System.Drawing.Point(252, 109);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(55, 30);
            this.btnPause.TabIndex = 17;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // appIcon
            // 
            this.appIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.appIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appIcon.Icon")));
            this.appIcon.Text = "YourPcNurse";
            this.appIcon.Visible = true;
            this.appIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.appIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReturnTheAppToolStripMenuItem,
            this.StartToolStripMenuItem,
            this.PauseToolStripMenuItem,
            this.CloseToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // ReturnTheAppToolStripMenuItem
            // 
            this.ReturnTheAppToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReturnTheAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ReturnTheAppToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReturnTheAppToolStripMenuItem.Image")));
            this.ReturnTheAppToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.ReturnTheAppToolStripMenuItem.Name = "ReturnTheAppToolStripMenuItem";
            this.ReturnTheAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReturnTheAppToolStripMenuItem.Text = "YourPcNurse";
            this.ReturnTheAppToolStripMenuItem.Click += new System.EventHandler(this.ReturnTheAppToolStripMenuItem_Click);
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.StartToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StartToolStripMenuItem.Text = "Start";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // PauseToolStripMenuItem
            // 
            this.PauseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PauseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem";
            this.PauseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PauseToolStripMenuItem.Text = "Pause";
            this.PauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem1
            // 
            this.CloseToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1";
            this.CloseToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.CloseToolStripMenuItem1.Text = "Close";
            this.CloseToolStripMenuItem1.Click += new System.EventHandler(this.CloseToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Visible = false;
            // 
            // YourPcNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(355, 310);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMoveSn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEyeSn);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMoveMin);
            this.Controls.Add(this.lblEyeMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YourPcNurse";
            this.Load += new System.EventHandler(this.YourPcNurse_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMoveSn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEyeSn;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMoveMin;
        private System.Windows.Forms.Label lblEyeMin;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Timer eyeTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.NotifyIcon appIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ReturnTheAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

