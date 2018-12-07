using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PROJECT_PEIZHI 
    /// </summary>
    [Serializable()]
    public class PB_PROJECT_PEIZHI : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:工程地图配置路径
		/// </summary>                       
		public String PB_DTURL { get;set;}         
		/// <summary>
		/// String:描述
		/// </summary>                       
		public String PB_DESCRIPTION { get;set;}         
		/// <summary>
		/// String:形变汇总时间段
		/// </summary>                       
		public String PB_XINGBIAN_HUIZONG { get;set;}         
		/// <summary>
		/// String:测斜汇总时间段
		/// </summary>                       
		public String PB_CEXIE_HUIZONG { get;set;}         
		/// <summary>
		/// String:水位汇总时间段
		/// </summary>                       
		public String PB_SHUIWEI_HUIZONG { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:自动上报用户名
		/// </summary>                       
		public String PB_JCSBYH { get;set;}   
    }    
}
	