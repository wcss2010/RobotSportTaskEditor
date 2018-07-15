﻿using Noear.Weed;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace RobotSpeaker.SportDB
{
    public class DBInstance
    {
        private static DbContext _dbHelper = null;
        /// <summary>
        /// 数据访问接口
        /// </summary>
        public static DbContext DbHelper
        {
            get { return _dbHelper; }
        }

        public static void Init(string dbFile)
        {
            _dbHelper = new DbContext("main", "Data Source=" + dbFile, new SQLiteFactory());
            _dbHelper.IsSupportInsertAfterSelectIdentity = false;
        }
    }

    /// <summary>
    /// 问答表
    /// </summary>
    [Serializable]
    public class Robot_Questions : IBinder 
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

        public void bind(GetHandlerEx source)
        {
            Id = source("Id").value<long>(0);
            Ask = source("Ask").value("");
            Answer = source("Answer").value("");
            ActionId = source("ActionId").value<long>(0);
        }

        public IBinder clone()
        {
            return new Robot_Questions();
        }
    }

    /// <summary>
    /// 动作表
    /// </summary>
    [Serializable]
    public class Robot_Actions : IBinder
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

        public void bind(GetHandlerEx source)
        {
            Id = source("Id").value<long>(0);
            Code = source("Code").value("");
            Name = source("Name").value("");
        }

        public IBinder clone()
        {
            return new Robot_Actions();
        }
    }

    /// <summary>
    /// 动作序列表
    /// </summary>
    [Serializable]
    public class Robot_Steps : IBinder 
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
        public char StepType { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public long Value { get; set; }

        /// <summary>
        /// 备用项
        /// </summary>
        public string Tag { get; set; }

        public void bind(GetHandlerEx source)
        {
            Id = source("Id").value<long>(0);
            ActionId = source("ActionId").value<long>(0);
            StepType = source("StepType").value<char>('A');
            Value = source("Value").value<long>(0);
            Tag = source("Tag").value("");
        }

        public IBinder clone()
        {
            return new Robot_Steps();
        }
    }
}