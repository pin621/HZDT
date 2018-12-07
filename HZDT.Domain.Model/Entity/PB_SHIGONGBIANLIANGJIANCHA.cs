using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SHIGONGBIANLIANGJIANCHA 
    /// </summary>
    [Serializable()]
    public class PB_SHIGONGBIANLIANGJIANCHA : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_RIQI { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_XIANBIELICHENG { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_JIANCHAREN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_KINDS { get;set;}   
    }    
}
	