using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_CYRYAQJYPXZHU 
    /// </summary>
    [Serializable()]
    public class PB_CYRYAQJYPXZHU : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:工程名称
		/// </summary>                       
		public String PB_PROJECT_NAME { get;set;}         
		/// <summary>
		/// String:表类别
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// String:工程地点
		/// </summary>                       
		public String PB_GONGCHENGDIDIAN { get;set;}         
		/// <summary>
		/// String:单位名称
		/// </summary>                       
		public String PB_DANWEI_NAME { get;set;}         
		/// <summary>
		/// String:负责人
		/// </summary>                       
		public String PB_FUZEREN { get;set;}         
		/// <summary>
		/// String:监理
		/// </summary>                       
		public String PB_JIANLI { get;set;}         
		/// <summary>
		/// String:项目主管
		/// </summary>                       
		public String PB_XIANGMUZHUGUAN { get;set;}         
		/// <summary>
		/// String:日期
		/// </summary>                       
		public String PB_RIQI { get;set;}         
		/// <summary>
		/// String:建表人（登录人id）
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:创建时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:项目部还是监理部的（预留的）项目部：xiangmubu，监理部：jianlibu
		/// </summary>                       
		public String PB_SHIGONGJIANLILEIBIE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEI_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_IS_SIGNATRUE { get;set;}   
    }    
}
	