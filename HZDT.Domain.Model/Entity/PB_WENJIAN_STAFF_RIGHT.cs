using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_WENJIAN_STAFF_RIGHT 
    /// </summary>
    [Serializable()]
    public class PB_WENJIAN_STAFF_RIGHT : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_WENJIAN_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DESCRIPTION { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_OPERATION_DATE { get;set;}   
    }    
}
	