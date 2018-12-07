using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_TAIZHANGFENGMIAN 
    /// </summary>
    [Serializable()]
    public class PB_TAIZHANGFENGMIAN : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ZERENREN { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_KAISHIRIQI { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_JIESHURIQI { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}   
    }    
}
	