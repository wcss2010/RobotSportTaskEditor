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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gbDesignToolBox = new System.Windows.Forms.GroupBox();
            this.pgPropertyView = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlDesignView = new TimeBeam.Timeline();
            this.ssState = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ssState.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1297, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // gbDesignToolBox
            // 
            this.gbDesignToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDesignToolBox.Location = new System.Drawing.Point(0, 25);
            this.gbDesignToolBox.Name = "gbDesignToolBox";
            this.gbDesignToolBox.Size = new System.Drawing.Size(909, 342);
            this.gbDesignToolBox.TabIndex = 3;
            this.gbDesignToolBox.TabStop = false;
            // 
            // pgPropertyView
            // 
            this.pgPropertyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgPropertyView.Location = new System.Drawing.Point(3, 40);
            this.pgPropertyView.Name = "pgPropertyView";
            this.pgPropertyView.Size = new System.Drawing.Size(382, 299);
            this.pgPropertyView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgPropertyView);
            this.groupBox1.Controls.Add(this.lblSelected);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(909, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tlDesignView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1297, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "动作执行流程";
            // 
            // tlDesignView
            // 
            this.tlDesignView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tlDesignView.BackgroundColor = System.Drawing.Color.Black;
            this.tlDesignView.Clock = null;
            this.tlDesignView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDesignView.GridAlpha = 40;
            this.tlDesignView.Location = new System.Drawing.Point(3, 17);
            this.tlDesignView.Name = "tlDesignView";
            this.tlDesignView.Size = new System.Drawing.Size(1291, 157);
            this.tlDesignView.TabIndex = 0;
            this.tlDesignView.Text = "timeline1";
            this.tlDesignView.TrackBorderSize = 2;
            this.tlDesignView.TrackHeight = 30;
            this.tlDesignView.TrackSpacing = 1;
            // 
            // ssState
            // 
            this.ssState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.ssState.Location = new System.Drawing.Point(0, 544);
            this.ssState.Name = "ssState";
            this.ssState.Size = new System.Drawing.Size(1297, 22);
            this.ssState.TabIndex = 4;
            this.ssState.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lblSelected
            // 
            this.lblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelected.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelected.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSelected.Location = new System.Drawing.Point(3, 17);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(382, 23);
            this.lblSelected.TabIndex = 1;
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 566);
            this.Controls.Add(this.gbDesignToolBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ssState);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ssState.ResumeLayout(false);
            this.ssState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TimeBeam.Timeline tlDesignView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox gbDesignToolBox;
        private System.Windows.Forms.PropertyGrid pgPropertyView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip ssState;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblSelected;
    }
}

