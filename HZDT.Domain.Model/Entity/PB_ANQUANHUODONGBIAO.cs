using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ANQUANHUODONGBIAO 
    /// </summary>
    [Serializable()]
    public class PB_ANQUANHUODONGBIAO : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程项目ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:部门名称
		/// </summary>                       
		public String PB_DEPARTMENT_ID { get;set;}         
		/// <summary>
		/// DateTime:日期
		/// </summary>                       
		public DateTime PB_RIQI { get;set;}         
		/// <summary>
		/// String:地点
		/// </summary>                       
		public String PB_DIDIAN { get;set;}         
		/// <summary>
		/// String:类别
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// String:主持人
		/// </summary>                       
		public String PB_ZHUCHIREN { get;set;}         
		/// <summary>
		/// String:参加人员
		/// </summary>                       
		public String PB_CANJIARENYUAN { get;set;}         
		/// <summary>
		/// String:内容
		/// </summary>                       
		public String PB_NEIRONG { get;set;}         
		/// <summary>
		/// String:记录人
		/// </summary>                       
		public String PB_JILUREN { get;set;}         
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
	