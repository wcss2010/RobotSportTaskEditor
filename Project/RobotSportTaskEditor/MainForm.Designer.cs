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
            this.tlDesignView = new TimeBeam.Timeline();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gbDesignToolBox = new System.Windows.Forms.GroupBox();
            this.pgPropertyView = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.tlDesignView.Size = new System.Drawing.Size(1291, 127);
            this.tlDesignView.TabIndex = 0;
            this.tlDesignView.Text = "timeline1";
            this.tlDesignView.TrackBorderSize = 2;
            this.tlDesignView.TrackHeight = 30;
            this.tlDesignView.TrackSpacing = 1;
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
            this.gbDesignToolBox.Size = new System.Drawing.Size(909, 394);
            this.gbDesignToolBox.TabIndex = 3;
            this.gbDesignToolBox.TabStop = false;
            this.gbDesignToolBox.Text = "工具箱";
            // 
            // pgPropertyView
            // 
            this.pgPropertyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgPropertyView.Location = new System.Drawing.Point(3, 17);
            this.pgPropertyView.Name = "pgPropertyView";
            this.pgPropertyView.Size = new System.Drawing.Size(382, 374);
            this.pgPropertyView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgPropertyView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(909, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tlDesignView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1297, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "执行流程设计";
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
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
    }
}

