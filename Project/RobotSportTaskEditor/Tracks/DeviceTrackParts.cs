using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TimeBeam;

namespace RobotSportTaskEditor.Tracks
{
    /// <summary>
    /// Track容器
    /// </summary>
    public class DeviceTrackParts : IMultiPartTimelineTrack
    {
        public DeviceTrackParts()
        {
            Name = "DeviceParts_" + Guid.NewGuid().ToString();
        }

        private List<ITimelineTrack> _trackElements = new List<ITimelineTrack>();
        public IEnumerable<ITimelineTrack> TrackElements
        {
            get { return _trackElements; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        [Browsable(false)]
        public string Name { get; set; }
    }
}