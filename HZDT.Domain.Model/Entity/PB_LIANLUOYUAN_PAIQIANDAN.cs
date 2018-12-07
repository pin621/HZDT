using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_LIANLUOYUAN_PAIQIANDAN 
    /// </summary>
    [Serializable()]
    public class PB_LIANLUOYUAN_PAIQIANDAN : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_BIANHAO { get;set;}         
		/// <summary>
		/// String:单位
		/// </summary>                       
		public String PB_DEPARTMENT_ID { get;set;}         
		/// <summary>
		/// String:车间（施工队）
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:作业项目内容
		/// </summary>                       
		public String PB_ZUOYEXIANGMUNEIRONG { get;set;}         
		/// <summary>
		/// String:段调度命令号
		/// </summary>                       
		public String PB_DUANDIAODUMINGLINGHAO { get;set;}         
		/// <summary>
		/// String:作业地点
		/// </summary>                       
		public String PB_ZUOYEDIDIAN { get;set;}         
		/// <summary>
		/// DateTime:计划作业开始日期
		/// </summary>                       
		public DateTime PB_JIHUAZUOYEKAISHIRIQI { get;set;}         
		/// <summary>
		/// String:开始时间
		/// </summary>                       
		public String PB_KAISHISHIJIAN { get;set;}         
		/// <summary>
		/// DateTime:计划作业结束日期
		/// </summary>                       
		public DateTime PB_JIHUAZUOYEJIESHURIQI { get;set;}         
		/// <summary>
		/// String:结束时间
		/// </summary>                       
		public String PB_JIESHUSHIJIAN { get;set;}         
		/// <summary>
		/// String:作业负责人
		/// </summary>                       
		public String PB_ZUOYEFUZEREN { get;set;}         
		/// <summary>
		/// String:驻站联络员
		/// </summary>                       
		public String PB_ZHUZHANLIANLUOYUAN { get;set;}         
		/// <summary>
		/// String:现场防护员
		/// </summary>                       
		public String PB_XIANCHANGFANGHUYUAN { get;set;}         
		/// <summary>
		/// String:有关内容和注意事项
		/// </summary>                       
		public String PB_YOUGUANNEIRONGZHUYISHIXIANG { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_QIANFAREN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_CHEZHANQIANREN { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_QIANFASHIJIAN { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ZDBH { get;set;}   
    }    
}
	