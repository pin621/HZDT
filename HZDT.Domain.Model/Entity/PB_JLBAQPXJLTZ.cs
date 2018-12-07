using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JLBAQPXJLTZ 
    /// </summary>
    [Serializable()]
    public class PB_JLBAQPXJLTZ : IEntity
    {    
		         
		/// <summary>
		/// String:主键
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程项目id
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:工程项目名称
		/// </summary>                       
		public String PB_PROJECT_NAME { get;set;}         
		/// <summary>
		/// String:单位id
		/// </summary>                       
		public String PB_DANWEI_ID { get;set;}         
		/// <summary>
		/// String:培训日期
		/// </summary>                       
		public String PB_RIQI { get;set;}         
		/// <summary>
		/// String:编号
		/// </summary>                       
		public String PB_BIANHAO { get;set;}         
		/// <summary>
		/// String:主题
		/// </summary>                       
		public String PB_ZHUTI { get;set;}         
		/// <summary>
		/// String:主要内容
		/// </summary>                       
		public String PB_ZHUYAONEIRONG { get;set;}         
		/// <summary>
		/// String:主持人
		/// </summary>                       
		public String PB_ZHUCHIREN { get;set;}         
		/// <summary>
		/// String:人数
		/// </summary>                       
		public String PB_RENSHU { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:录入人
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:录入日期
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:参会人签到
		/// </summary>                       
		public String PB_QIANDAO { get;set;}   
    }    
}
	