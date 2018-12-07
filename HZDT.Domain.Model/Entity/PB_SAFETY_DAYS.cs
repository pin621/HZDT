using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SAFETY_DAYS 
    /// </summary>
    [Serializable()]
    public class PB_SAFETY_DAYS : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PARENT_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:部门ID
		/// </summary>                       
		public String PB_UNITS_ID { get;set;}         
		/// <summary>
		/// String:安全天描述
		/// </summary>                       
		public String PB_DESCRIPTION { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_BEGINDATE { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ORDER_ID { get;set;}   
    }    
}
	