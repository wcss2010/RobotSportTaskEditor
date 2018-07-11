using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeBeam;
using TimeBeam.Events;
using TimeBeam.Timing;

namespace RobotSportTaskEditor
{
    public partial class MainForm : Form
    {
        private TimeBeamClockImpl _clock = new TimeBeamClockImpl();

        public MainForm()
        {
            InitializeComponent();

            tlDesignView.SelectionChanged += TimelineSelectionChanged;
            // Register the clock with the timeline
            tlDesignView.Clock = _clock;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


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
    }
}