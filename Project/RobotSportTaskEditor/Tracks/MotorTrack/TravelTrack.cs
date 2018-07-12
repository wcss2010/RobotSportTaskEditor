﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RobotSportTaskEditor.Tracks.MotorTrack
{
    /// <summary>
    /// 行进电机
    /// </summary>
    public class TravelTrack : MotorTrackBase
    {
        public TravelTrack(int mIndex)
        {
            _motorType = MotorTypes.B_行进电机;
            _motorIndex = mIndex;
        }

        /// <summary>
        /// 行进电机动作
        /// </summary>
        [DisplayName("行进电机动作")]
        public TravelActionTypes TravelActionType { get; set; }
    }

    /// <summary>
    /// 行进电机动作
    /// </summary>
    public enum TravelActionTypes
    {
       A_前进,B_停止
    }
}