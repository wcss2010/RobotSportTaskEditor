using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RobotSportTaskEditor.Tracks.MotorTrack
{
    /// <summary>
    /// 电机Track基类
    /// </summary>
    public class MotorTrackBase : DeviceTrack
    {
        protected int _motorIndex = -1;
        /// <summary>
        /// 电机序号
        /// </summary>
        [DisplayName("电机序号")]
        public int MotorIndex
        {
            get { return _motorIndex; }
        }
        
        protected MotorTypes _motorType = MotorTypes.C_旋转电机;
        /// <summary>
        /// 电机类型
        /// </summary>
        [DisplayName("电机类型")]
        public MotorTypes MotorType
        {
            get { return _motorType; }
        }

        /// <summary>
        /// 电机名称
        /// </summary>
        [Browsable(false)]
        public string MotorName { get; set; }
    }

    /// <summary>
    /// 电机类型
    /// </summary>
    public enum MotorTypes
    {
        C_旋转电机, C_行进电机
    }
}