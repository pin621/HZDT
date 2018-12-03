using System;
using System.Collections.Generic;
using System.Text;

namespace HZDT.Respository.Interface
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// 是否提交
        /// </summary>
        bool IsCommitted { get; set; }
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        int Commit();
        /// <summary>
        /// 回滚
        /// </summary>
        void Rollback();
    }
}
