using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PROJECT_ROLE_JIANCEBAOBIAO 
    /// </summary>
    [Serializable()]
    public class PB_PROJECT_ROLE_JIANCEBAOBIAO : IEntity
    {    
		         
		/// <summary>
		/// Int32:自增Id，主键
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// String:对应工程Id
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ROLE_ID { get;set;}   
    }    
}
	