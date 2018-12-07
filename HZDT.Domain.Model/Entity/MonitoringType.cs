using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：MonitoringType 
    /// </summary>
    [Serializable()]
    public class MonitoringType : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String type { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PID { get;set;}   
    }    
}
	