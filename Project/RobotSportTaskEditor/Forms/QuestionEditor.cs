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

            LoadActions();
            if (Object != null)
            {
                tbAsk.Text = Object.Ask;
                tbAnswer.Text = Object.Answer;

                if (ActionList != null)
                {
                    foreach (Robot_Actions action in ActionList)
                    {
                        if (action.Id == Object.ActionId)
                        {
                            cbActions.SelectedItem = action.Name;
                            break;
                        }
                    }
                }
            }
        }

        public void LoadActions()
        {
            ActionList = DBInstance.DbHelper.table("Robot_Actions").select("*").getList<Robot_Actions>(new Robot_Actions());
            if (ActionList != null)
            {
                cbActions.Items.Clear();
                foreach (Robot_Actions a in ActionList)
                {
                    cbActions.Items.Add(a.Name);
                }
            }
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
            if (string.IsNullOrEmpty(tbAsk.Text))
            {
                MessageBox.Show("请输入问内容！");
                return;
            }
            if (string.IsNullOrEmpty(tbAnswer.Text))
            {
                MessageBox.Show("请输入答内容！");
                return;
            }

            if (IsNewRecord)
            {
                _object = new Robot_Questions();
                Object.Id = DBInstance.DbHelper.table("Robot_Questions").select("max(Id)").getValue<long>(0) + 1;
            }

            Object.Ask = tbAsk.Text;
            Object.Answer = tbAnswer.Text;

            if (cbActions.SelectedIndex >= 0 && ActionList != null && ActionList.Count > cbActions.SelectedIndex)
            {
                Object.ActionId = ActionList[cbActions.SelectedIndex].Id;
            }

            if (IsNewRecord)
            {
                //Insert
                DBInstance.DbHelper.table("Robot_Questions").set("Id", Object.Id).set("Ask", Object.Ask).set("Answer", Object.Answer).set("ActionId", Object.ActionId).insert();
            }
            else
            {
                //Update
                DBInstance.DbHelper.table("Robot_Questions").set("Ask", Object.Ask).set("Answer", Object.Answer).set("ActionId", Object.ActionId).where("Id=?", new object[] { Object.Id }).update();
            }

            MessageBox.Show("操作完成！");
            Close();
        }

        private void btnNewAction_Click(object sender, EventArgs e)
        {
            new ActionEditor(true).ShowDialog();
            LoadActions();
        }

        public List<Robot_Actions> ActionList { get; set; }
    }
}