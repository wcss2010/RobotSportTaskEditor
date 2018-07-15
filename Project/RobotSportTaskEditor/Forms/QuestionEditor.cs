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
        }

        public bool IsNewRecord { get; set; }

        public Robot_Questions Object { get; set; }
    }
}