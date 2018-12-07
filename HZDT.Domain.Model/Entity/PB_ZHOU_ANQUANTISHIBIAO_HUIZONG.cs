using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ZHOU_ANQUANTISHIBIAO_HUIZONG 
    /// </summary>
    [Serializable()]
    public class PB_ZHOU_ANQUANTISHIBIAO_HUIZONG : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_OLDID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_NAME { get;set;}         
		/// <summary>
		/// String:年份
		/// </summary>                       
		public String PB_NF { get;set;}         
		/// <summary>
		/// String:第几周
		/// </summary>                       
		public String PB_DIJIZHOU { get;set;}         
		/// <summary>
		/// DateTime:本周开始日期
		/// </summary>                       
		public DateTime PB_BZKSRQ { get;set;}         
		/// <summary>
		/// DateTime:本周结束日期
		/// </summary>                       
		public DateTime PB_BZJSRQ { get;set;}         
		/// <summary>
		/// Int32:本周是否慢行
		/// </summary>                       
		public Int32 PB_BZSFMX { get;set;}         
		/// <summary>
		/// Int32:本周慢行几处
		/// </summary>                       
		public Int32 PB_BZMXJC { get;set;}         
		/// <summary>
		/// String:本周主要工作内容
		/// </summary>                       
		public String PB_BZZYGZNR { get;set;}         
		/// <summary>
		/// String:本周安全揭示
		/// </summary>                       
		public String PB_BZAQJS { get;set;}         
		/// <summary>
		/// String:本周各级检查情况
		/// </summary>                       
		public String PB_BZGJJCQK { get;set;}         
		/// <summary>
		/// String:本周重要安全情况
		/// </summary>                       
		public String PB_BZZYAQQK { get;set;}         
		/// <summary>
		/// String:下周安全预警提示
		/// </summary>                       
		public String PB_XZANYJTS { get;set;}         
		/// <summary>
		/// DateTime:下周开始日期
		/// </summary>                       
		public DateTime PB_XZKSRQ { get;set;}         
		/// <summary>
		/// DateTime:下周结束日期
		/// </summary>                       
		public DateTime PB_XZJSRQ { get;set;}         
		/// <summary>
		/// Int32:下周是否慢行
		/// </summary>                       
		public Int32 PB_XZSFMX { get;set;}         
		/// <summary>
		/// Int32:下周慢行几处
		/// </summary>                       
		public Int32 PB_XZMXJC { get;set;}         
		/// <summary>
		/// String:下周主要工作
		/// </summary>                       
		public String PB_XZZYGZ { get;set;}         
		/// <summary>
		/// String:下周安全揭示
		/// </summary>                       
		public String PB_XZAQJS { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_TIANBAOREN { get;set;}         
		/// <summary>
		/// DateTime:填表时间
		/// </summary>                       
		public DateTime PB_TIANBIAOSHIJIAN { get;set;}         
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
	