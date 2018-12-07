using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SERVICELOG 
    /// </summary>
    [Serializable()]
    public class PB_SERVICELOG : IEntity
    {    
		         
		/// <summary>
		/// Int64:
		/// </summary>                       
		public Int64 PB_ID { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_DATE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LOG { get;set;}   
    }    
}
	