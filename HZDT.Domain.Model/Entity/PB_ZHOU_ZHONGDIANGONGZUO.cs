using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ZHOU_ZHONGDIANGONGZUO 
    /// </summary>
    [Serializable()]
    public class PB_ZHOU_ZHONGDIANGONGZUO : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ZHOU_ANQUANTISHIBIAO_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_NAME { get;set;}         
		/// <summary>
		/// String:下周开始日期
		/// </summary>                       
		public String PB_KSRIQI { get;set;}         
		/// <summary>
		/// String:下周的结束日期
		/// </summary>                       
		public String PB_JSRIQI { get;set;}         
		/// <summary>
		/// String:线别
		/// </summary>                       
		public String PB_XIANBIE { get;set;}         
		/// <summary>
		/// String:区间
		/// </summary>                       
		public String PB_QUJIAN { get;set;}         
		/// <summary>
		/// String:行别
		/// </summary>                       
		public String PB_XINGBIE { get;set;}         
		/// <summary>
		/// Int32:是否慢性
		/// </summary>                       
		public Int32 PB_BZSFMX { get;set;}         
		/// <summary>
		/// String:施工内容
		/// </summary>                       
		public String PB_SGNR { get;set;}         
		/// <summary>
		/// String:封锁级别（来源于syscode）
		/// </summary>                       
		public String PB_FSJB { get;set;}         
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
		public String PB_DANWEI_ID { get;set;}   
    }    
}
	