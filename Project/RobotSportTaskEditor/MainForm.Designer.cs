namespace RobotSportTaskEditor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tsTopToolBar = new System.Windows.Forms.ToolStrip();
            this.ssState = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionDesignControl1 = new RobotSportTaskEditor.Controls.ActionDesignControl();
            this.ssState.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsTopToolBar
            // 
            this.tsTopToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsTopToolBar.Location = new System.Drawing.Point(0, 0);
            this.tsTopToolBar.Name = "tsTopToolBar";
            this.tsTopToolBar.Size = new System.Drawing.Size(1323, 25);
            this.tsTopToolBar.TabIndex = 1;
            // 
            // ssState
            // 
            this.ssState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.ssState.Location = new System.Drawing.Point(0, 860);
            this.ssState.Name = "ssState";
            this.ssState.Size = new System.Drawing.Size(1323, 22);
            this.ssState.TabIndex = 4;
            this.ssState.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 17);
            this.lblStatus.Text = "动作设计器";
            // 
            // actionDesignControl1
            // 
            this.actionDesignControl1.BackColor = System.Drawing.Color.White;
            this.actionDesignControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionDesignControl1.Location = new System.Drawing.Point(0, 25);
            this.actionDesignControl1.Name = "actionDesignControl1";
            this.actionDesignControl1.Size = new System.Drawing.Size(1323, 835);
            this.actionDesignControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 882);
            this.Controls.Add(this.actionDesignControl1);
            this.Controls.Add(this.tsTopToolBar);
            this.Controls.Add(this.ssState);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ssState.ResumeLayout(false);
            this.ssState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTopToolBar;
        private System.Windows.Forms.StatusStrip ssState;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private Controls.ActionDesignControl actionDesignControl1;
    }
}

