using HZDT.Infrastructure.ConfigHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HZDT.Infrastructure.DataAccess.SqlDBHelper
{
    /// <summary>
    /// SqlServer数据库帮助类
    /// </summary>
    public class DBAdaptor : IDBHelper
    {
        /// <summary>
        /// 默认数据库连接字符串【键】
        /// </summary>
        private string connectionStringKey = "DefaultConnection";

        public DBAdaptor() { }
        public DBAdaptor(string connectionStringKey)
        {
            if (!string.IsNullOrEmpty(connectionStringKey))
            {
                this.connectionStringKey = connectionStringKey;
            }
        }

        /// <summary>
        /// 取得数据库连接
        /// </summary>
        /// <param name="connectionStringKey">数据库连接字符串【键】</param>
        /// <returns></returns>
        public static IDbConnection GetConnection(string connectionStringKey)
        {
            ConfigurationHelper configurationHelper = ConfigurationHelper.GetInstance();
            string connectionString = configurationHelper.GetConnectionString(connectionStringKey);
            return new SqlConnection(connectionString);
        }

        public IDbTransaction BeginTractionand(IsolationLevel Iso = IsolationLevel.Unspecified)
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTractionand(string connKey, IsolationLevel Iso = IsolationLevel.Unspecified)
        {
            throw new NotImplementedException();
        }

        public void CommitTractionand(IDbTransaction dbTransaction)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecuteDataSet(string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecuteDataSet(string connKey, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecuteDataSet(IDbConnection conn, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecuteDataSet(IDbTransaction trans, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteIEnumerable<T>(string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteIEnumerable<T>(string connKey, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteIEnumerable<T>(IDbConnection conn, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteIEnumerable<T>(IDbTransaction trans, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public int ExecuteNonQuery(string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public int ExecuteNonQuery(string connKey, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public int ExecuteNonQuery(IDbConnection conn, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public int ExecuteNonQuery(IDbTransaction trans, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public IDataReader ExecuteReader(string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public IDataReader ExecuteReader(string connKey, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public IDataReader ExecuteReader(IDbConnection conn, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public IDataReader ExecuteReader(IDbTransaction trans, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string connKey, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(string connKey, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(IDbConnection conn, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(IDbConnection conn, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(IDbTransaction trans, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(IDbTransaction trans, string commandText, List<IDataParameter> commandParameters = null, CommandType commandType = CommandType.Text, int? commandTimeout = null)
        {
            throw new NotImplementedException();
        }

        public string GetPagingSql(int pageIndex, int pageSize, string selectSql, string sqlCount, string orderBy)
        {
            throw new NotImplementedException();
        }

        public void RollbackTractionand(IDbTransaction dbTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
