using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SYSCODE_TYPE 
    /// </summary>
    [Serializable()]
    public class PB_SYSCODE_TYPE : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_TAG { get;set;}         
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
    }    
}
	