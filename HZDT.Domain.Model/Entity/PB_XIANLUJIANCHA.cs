using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_XIANLUJIANCHA 
    /// </summary>
    [Serializable()]
    public class PB_XIANLUJIANCHA : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// DateTime:日期
		/// </summary>                       
		public DateTime PB_RIQI { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:线别
		/// </summary>                       
		public String PB_XIANBIE { get;set;}         
		/// <summary>
		/// String:区间
		/// </summary>                       
		public String PB_SHANGXIAXING { get;set;}         
		/// <summary>
		/// String:里程
		/// </summary>                       
		public String PB_LICHENG { get;set;}         
		/// <summary>
		/// String:检查人员
		/// </summary>                       
		public String PB_JIANCHARENYUAN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_CHOUCHARENYUAN { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_KINDS { get;set;}   
    }    
}
	