using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeBeam.Timing;
using RobotSportTaskEditor.Tracks;
using TimeBeam.Events;
using TimeBeam;
using System.Diagnostics;

namespace RobotSportTaskEditor.Controls
{
    public partial class ActionDesignControl : UserControl
    {
        private TimeBeamClockImpl _clock = new TimeBeamClockImpl();
        private DeviceTrackParts defaultParts = new DeviceTrackParts();

        public ActionDesignControl()
        {
            InitializeComponent();

            tlDesignView.SelectionChanged += TimelineSelectionChanged;
            // Register the clock with the timeline
            tlDesignView.Clock = _clock;

            defaultParts.DisplayText = "动作序列：";
            defaultParts.TrackElementList.Add(new StartTrack());
            tlDesignView.AddTrack(defaultParts);

            plRobotToolBox.Left = (gbDesignToolBox.Width - plRobotToolBox.Width) / 2;
            plRobotToolBox.Top = (gbDesignToolBox.Height - plRobotToolBox.Height) / 2;
        }

        private void TimelineSelectionChanged(object sender, SelectionChangedEventArgs selectionChangedEventArgs)
        {
            if (null != selectionChangedEventArgs.Deselected)
            {
                foreach (ITimelineTrackBase track in selectionChangedEventArgs.Deselected)
                {
                    Debug.WriteLine("Deselected: " + track);
                }
            }
            if (null != selectionChangedEventArgs.Selected)
            {
                foreach (ITimelineTrackBase track in selectionChangedEventArgs.Selected)
                {
                    Debug.WriteLine("Selected: " + track);
                }
            }
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            plRobotToolBox.Left = (gbDesignToolBox.Width - plRobotToolBox.Width) / 2;
            plRobotToolBox.Top = (gbDesignToolBox.Height - plRobotToolBox.Height) / 2;
        }

        private void lblDevice0_Click(object sender, EventArgs e)
        {

        }

        private void tlDesignView_DragEnter(object sender, DragEventArgs e)
        {
            object obj = e.Data.GetData(DataFormats.Text);
            if (obj != null)
            {
                string[] teams = obj.ToString().Split('%');
                if (teams != null && teams.Length >= 2)
                {
                    DeviceTrack dt = new DeviceTrack();
                    dt.BackgroundColor = Color.FromArgb(Int32.Parse(teams[0]));
                    dt.DisplayText = teams[1];

                    //查找开始位置
                    float defaultStart = 0;
                    foreach (DeviceTrack t in defaultParts.TrackElementList)
                    {
                        if (t.End > defaultStart)
                        {
                            defaultStart = t.End;
                        }
                    }

                    defaultStart += 10;

                    dt.Start = defaultStart;
                    dt.End = dt.Start + 130;

                    defaultParts.TrackElementList.Add(dt);
                    tlDesignView.Invalidate();
                }
            }
        }

        private void lblDevice11_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            string destString = string.Empty;
            destString += label.BackColor.ToArgb() + "%";
            destString += label.Text;

            label.DoDragDrop(destString, DragDropEffects.Copy);
        }

        private void lblDevice11_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            plRobotToolBox.Left = (gbDesignToolBox.Width - plRobotToolBox.Width) / 2;
            plRobotToolBox.Top = (gbDesignToolBox.Height - plRobotToolBox.Height) / 2;
        }

        private void tlDesignView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (tlDesignView.SelectedTracks.Count() > 0)
                {
                    if (MessageBox.Show("真的要进行吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (ITimelineTrack tt in tlDesignView.SelectedTracks)
                        {
                            if (tt is StartTrack)
                            {
                                continue;
                            }

                            defaultParts.TrackElementList.Remove(tt);
                        }

                        tlDesignView.Invalidate();
                    }
                }
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                if (tlDesignView.SelectedTracks.Count() > 0)
                {
                    ITimelineTrack first = tlDesignView.SelectedTracks.First();
                    int indexx = defaultParts.TrackElementList.IndexOf(first);
                    if (indexx >= 0 && defaultParts.TrackElementList.Count - 1 > indexx)
                    {
                        tlDesignView.SelectTrack(defaultParts.TrackElementList[indexx + 1]);
                    }
                }
            }
            else if (e.KeyCode == Keys.PageUp)
            {
                if (tlDesignView.SelectedTracks.Count() > 0)
                {
                    ITimelineTrack first = tlDesignView.SelectedTracks.First();
                    int indexx = defaultParts.TrackElementList.IndexOf(first);
                    if (indexx >= 1)
                    {
                        tlDesignView.SelectTrack(defaultParts.TrackElementList[indexx - 1]);
                    }
                }
            }
        }
    }
}