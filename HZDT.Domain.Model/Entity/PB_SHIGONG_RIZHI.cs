using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SHIGONG_RIZHI 
    /// </summary>
    [Serializable()]
    public class PB_SHIGONG_RIZHI : IEntity
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
		/// String:
		/// </summary>                       
		public String PB_DEPARTMENT_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:上午天气
		/// </summary>                       
		public String PB_SHANGWUTIANQI { get;set;}         
		/// <summary>
		/// String:下午天气
		/// </summary>                       
		public String PB_XIAWUTIANQI { get;set;}         
		/// <summary>
		/// String:最高气温
		/// </summary>                       
		public String PB_JILUREN { get;set;}         
		/// <summary>
		/// String:最低气温
		/// </summary>                       
		public String PB_SHENHEREN { get;set;}         
		/// <summary>
		/// String:工程部位
		/// </summary>                       
		public String PB_GONGCHENGBUWEI { get;set;}         
		/// <summary>
		/// String:施工队伍
		/// </summary>                       
		public String PB_SHIGONGDUIWU { get;set;}         
		/// <summary>
		/// String:施工活动记载
		/// </summary>                       
		public String PB_SHIGONGHUODONGJIZAI { get;set;}         
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
		public String PB_IS_SIGNATRUE { get;set;}   
    }    
}
	