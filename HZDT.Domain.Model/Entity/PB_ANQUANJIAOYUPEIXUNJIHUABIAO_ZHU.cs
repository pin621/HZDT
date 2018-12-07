using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ANQUANJIAOYUPEIXUNJIHUABIAO_ZHU 
    /// </summary>
    [Serializable()]
    public class PB_ANQUANJIAOYUPEIXUNJIHUABIAO_ZHU : IEntity
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
		/// String:表类别
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// String:项目部还是监理部的（预留的）项目部：xiangmubu，监理部：jianlibu
		/// </summary>                       
		public String PB_SHIGONGJIANLILEIBIE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEI_ID { get;set;}         
		/// <summary>
		/// String:编制单位
		/// </summary>                       
		public String PB_BIANZHIDANWEI { get;set;}         
		/// <summary>
		/// String:编制人（签字）
		/// </summary>                       
		public String PB_BIANZHIRENQIANZI { get;set;}         
		/// <summary>
		/// DateTime:编制人签字日期
		/// </summary>                       
		public DateTime PB_BIANZHIRENQIANZIRIQI { get;set;}         
		/// <summary>
		/// String:项目经理（签字）
		/// </summary>                       
		public String PB_XIANGMUJINGLIQIANZI { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_XIANGMUJINGLIQIANZIRIQI { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_SHENPIYIJIAN { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_SHENPIRIQI { get;set;}         
		/// <summary>
		/// String:建表人（登录人id）
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:创建时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_IS_SIGNATRUE { get;set;}   
    }    
}
	