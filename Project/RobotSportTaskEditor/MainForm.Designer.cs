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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsTopToolBar = new System.Windows.Forms.ToolStrip();
            this.ssState = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnNewAction = new System.Windows.Forms.ToolStripButton();
            this.btnNewQuestion = new System.Windows.Forms.ToolStripButton();
            this.tcActionAndQuestion = new System.Windows.Forms.TabControl();
            this.tpAction = new System.Windows.Forms.TabPage();
            this.tpQuestion = new System.Windows.Forms.TabPage();
            this.tsTopToolBar.SuspendLayout();
            this.ssState.SuspendLayout();
            this.tcActionAndQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsTopToolBar
            // 
            this.tsTopToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsTopToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewAction,
            this.btnNewQuestion});
            this.tsTopToolBar.Location = new System.Drawing.Point(0, 0);
            this.tsTopToolBar.Name = "tsTopToolBar";
            this.tsTopToolBar.Size = new System.Drawing.Size(1323, 56);
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
            // btnNewAction
            // 
            this.btnNewAction.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAction.Image")));
            this.btnNewAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAction.Name = "btnNewAction";
            this.btnNewAction.Size = new System.Drawing.Size(60, 53);
            this.btnNewAction.Text = "新建动作";
            this.btnNewAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnNewQuestion.Image")));
            this.btnNewQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(60, 53);
            this.btnNewQuestion.Text = "新建问答";
            this.btnNewQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tcActionAndQuestion
            // 
            this.tcActionAndQuestion.Controls.Add(this.tpAction);
            this.tcActionAndQuestion.Controls.Add(this.tpQuestion);
            this.tcActionAndQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcActionAndQuestion.Location = new System.Drawing.Point(0, 56);
            this.tcActionAndQuestion.Name = "tcActionAndQuestion";
            this.tcActionAndQuestion.SelectedIndex = 0;
            this.tcActionAndQuestion.Size = new System.Drawing.Size(1323, 804);
            this.tcActionAndQuestion.TabIndex = 5;
            // 
            // tpAction
            // 
            this.tpAction.Location = new System.Drawing.Point(4, 22);
            this.tpAction.Name = "tpAction";
            this.tpAction.Padding = new System.Windows.Forms.Padding(3);
            this.tpAction.Size = new System.Drawing.Size(1315, 778);
            this.tpAction.TabIndex = 0;
            this.tpAction.Text = "动作";
            this.tpAction.UseVisualStyleBackColor = true;
            // 
            // tpQuestion
            // 
            this.tpQuestion.Location = new System.Drawing.Point(4, 22);
            this.tpQuestion.Name = "tpQuestion";
            this.tpQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuestion.Size = new System.Drawing.Size(1315, 778);
            this.tpQuestion.TabIndex = 1;
            this.tpQuestion.Text = "问答";
            this.tpQuestion.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 882);
            this.Controls.Add(this.tcActionAndQuestion);
            this.Controls.Add(this.tsTopToolBar);
            this.Controls.Add(this.ssState);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "机器人语音动作指令编辑器 V1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsTopToolBar.ResumeLayout(false);
            this.tsTopToolBar.PerformLayout();
            this.ssState.ResumeLayout(false);
            this.ssState.PerformLayout();
            this.tcActionAndQuestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTopToolBar;
        private System.Windows.Forms.StatusStrip ssState;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton btnNewAction;
        private System.Windows.Forms.ToolStripButton btnNewQuestion;
        private System.Windows.Forms.TabControl tcActionAndQuestion;
        private System.Windows.Forms.TabPage tpAction;
        private System.Windows.Forms.TabPage tpQuestion;
    }
}

