﻿namespace RobotSportTaskEditor.Forms
{
    partial class QuestionEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewAction = new System.Windows.Forms.Button();
            this.cbActions = new System.Windows.Forms.ComboBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.tbAsk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditAction = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditAction);
            this.groupBox1.Controls.Add(this.btnNewAction);
            this.groupBox1.Controls.Add(this.cbActions);
            this.groupBox1.Controls.Add(this.tbAnswer);
            this.groupBox1.Controls.Add(this.tbAsk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnNewAction
            // 
            this.btnNewAction.Location = new System.Drawing.Point(398, 218);
            this.btnNewAction.Name = "btnNewAction";
            this.btnNewAction.Size = new System.Drawing.Size(88, 23);
            this.btnNewAction.TabIndex = 3;
            this.btnNewAction.Text = "新建动作";
            this.btnNewAction.UseVisualStyleBackColor = true;
            this.btnNewAction.Click += new System.EventHandler(this.btnNewAction_Click);
            // 
            // cbActions
            // 
            this.cbActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActions.FormattingEnabled = true;
            this.cbActions.Location = new System.Drawing.Point(52, 220);
            this.cbActions.Name = "cbActions";
            this.cbActions.Size = new System.Drawing.Size(340, 20);
            this.cbActions.TabIndex = 2;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(52, 118);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(521, 96);
            this.tbAnswer.TabIndex = 1;
            // 
            // tbAsk
            // 
            this.tbAsk.Location = new System.Drawing.Point(52, 16);
            this.tbAsk.Multiline = true;
            this.tbAsk.Name = "tbAsk";
            this.tbAsk.Size = new System.Drawing.Size(521, 96);
            this.tbAsk.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "动作：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "答：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "问：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(196, 257);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditAction
            // 
            this.btnEditAction.Location = new System.Drawing.Point(494, 218);
            this.btnEditAction.Name = "btnEditAction";
            this.btnEditAction.Size = new System.Drawing.Size(75, 23);
            this.btnEditAction.TabIndex = 4;
            this.btnEditAction.Text = "编辑动作";
            this.btnEditAction.UseVisualStyleBackColor = true;
            this.btnEditAction.Click += new System.EventHandler(this.btnEditAction_Click);
            // 
            // QuestionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑问答";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbAsk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.ComboBox cbActions;
        private System.Windows.Forms.Button btnNewAction;
        private System.Windows.Forms.Button btnEditAction;
    }
}