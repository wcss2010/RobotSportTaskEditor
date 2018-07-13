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

        /// <summary>
        /// 查询问答
        /// </summary>
        /// <param name="sqlWhere"></param>
        /// <returns></returns>
        public List<Robot_Questions> GetQuestions(string sqlWhere)
        {
            List<Robot_Questions> list = new List<Robot_Questions>();

            try
            {
                //打开连接
                _helper.Open();

                //查询数据
                SQLiteDataReader reader = _helper.ExecuteReader("select * from Robot_Questions " + (string.IsNullOrEmpty(sqlWhere) ? string.Empty : sqlWhere), null);

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Robot_Questions question = new Robot_Questions();
                        question.Id = reader.GetInt64(0);
                        question.Ask = reader.GetString(1);
                        question.Answer = reader.GetString(2);
                        question.ActionId = reader.GetInt64(3);

                        list.Add(question);
                    }
                }
            }
            finally
            {
                _helper.Close();
            }

            return list;
        }

        /// <summary>
        /// 查询动作
        /// </summary>
        /// <param name="sqlWhere"></param>
        /// <returns></returns>
        public List<Robot_Actions> GetActions(string sqlWhere)
        {
            List<Robot_Actions> list = new List<Robot_Actions>();

            try
            {
                //打开连接
                _helper.Open();

                //查询数据
                SQLiteDataReader reader = _helper.ExecuteReader("select * from Robot_Actions " + (string.IsNullOrEmpty(sqlWhere) ? string.Empty : sqlWhere), null);

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Robot_Actions question = new Robot_Actions();
                        question.Id = reader.GetInt64(0);
                        question.Code = reader.GetString(1);
                        question.Name = reader.GetString(2);

                        list.Add(question);
                    }
                }
            }
            finally
            {
                _helper.Close();
            }

            return list;
        }

        /// <summary>
        /// 查询步骤
        /// </summary>
        /// <param name="sqlWhere"></param>
        /// <returns></returns>
        public List<Robot_Steps> GetSteps(string sqlWhere)
        {
            List<Robot_Steps> list = new List<Robot_Steps>();

            try
            {
                //打开连接
                _helper.Open();

                //查询数据
                SQLiteDataReader reader = _helper.ExecuteReader("select * from Robot_Steps " + (string.IsNullOrEmpty(sqlWhere) ? string.Empty : sqlWhere), null);

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Robot_Steps question = new Robot_Steps();
                        question.Id = reader.GetInt64(0);
                        question.ActionId = reader.GetInt64(1);
                        question.StepType = reader.GetChar(2);
                        question.Value = reader.GetInt64(3);
                        question.Tag = reader.GetString(4);

                        list.Add(question);
                    }
                }
            }
            finally
            {
                _helper.Close();
            }

            return list;
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
        public char StepType { get; set; }

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