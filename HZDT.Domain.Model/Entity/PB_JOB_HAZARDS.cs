using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JOB_HAZARDS 
    /// </summary>
    [Serializable()]
    public class PB_JOB_HAZARDS : IEntity
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
		public String PB_QUJIAN { get;set;}         
		/// <summary>
		/// String:里程
		/// </summary>                       
		public String PB_LICHENG { get;set;}         
		/// <summary>
		/// String:工程规模
		/// </summary>                       
		public String PB_GUIMO { get;set;}         
		/// <summary>
		/// String:项目负责人
		/// </summary>                       
		public String PB_XIANGMUFUZEREN { get;set;}         
		/// <summary>
		/// String:安全员
		/// </summary>                       
		public String PB_ANQUANYUAN { get;set;}         
		/// <summary>
		/// String:作业内容
		/// </summary>                       
		public String PB_NEIRONG { get;set;}         
		/// <summary>
		/// String:危险源分析
		/// </summary>                       
		public String PB_WEIXIANGYUANFENXI { get;set;}         
		/// <summary>
		/// String:应对措施
		/// </summary>                       
		public String PB_YINGDUICUOSHI { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_FUZEREN { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}   
    }    
}
	