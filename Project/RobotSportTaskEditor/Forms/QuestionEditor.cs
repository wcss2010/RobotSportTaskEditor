using RobotSpeaker.SportDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RobotSportTaskEditor.Forms
{
    public partial class QuestionEditor : Form
    {
        public QuestionEditor(bool isNew)
        {
            InitializeComponent();

            IsNewRecord = isNew;

            if (IsNewRecord)
            {
                Text = "创建问答";
            }
            else
            {
                Text = "修改问答";
            }

            OnLoad(new EventArgs());
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


        }

        public bool IsNewRecord { get; set; }

        private Robot_Questions _object = null;
        public Robot_Questions Object
        {
            get { return _object; }
            set
            {
                _object = value;
                OnLoad(new EventArgs());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}