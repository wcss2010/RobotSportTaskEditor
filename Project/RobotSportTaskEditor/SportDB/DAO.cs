using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace RobotSpeaker.SportDB
{
    public class DAO
    {
        protected SQLiteHelper _helper = null;
        public DAO(string dbFile)
        {
            _helper = new SQLiteHelper(dbFile);   
        }


    }

    /// <summary>
    /// 问答表
    /// </summary>
    public class Robot_Questions
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 问
        /// </summary>
        public string Ask { get; set; }

        /// <summary>
        /// 答
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// 动作ID
        /// </summary>
        public long ActionId { get; set; }
    }

    /// <summary>
    /// 动作表
    /// </summary>
    public class Robot_Actions
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// 动作序列表
    /// </summary>
    public class Robot_Steps
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 动作ID
        /// </summary>
        public long ActionId { get; set; }

        /// <summary>
        /// 步骤类型
        /// </summary>
        public string StepType { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public long Value { get; set; }

        /// <summary>
        /// 备用项
        /// </summary>
        public string Tag { get; set; }
    }
}