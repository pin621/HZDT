using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ROLE_TYPE1 
    /// </summary>
    [Serializable()]
    public class PB_ROLE_TYPE1 : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PARENT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_REMARK { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ORDER_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEIID_ARR { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_IS_ADMIN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_JIBIE { get;set;}   
    }    
}
	