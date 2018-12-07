using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ROLE_MODULE_RIGHT_DENY 
    /// </summary>
    [Serializable()]
    public class PB_ROLE_MODULE_RIGHT_DENY : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ROLE_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_RIGHT_ID { get;set;}   
    }    
}
	