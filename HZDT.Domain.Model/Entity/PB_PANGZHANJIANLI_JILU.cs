using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PANGZHANJIANLI_JILU 
    /// </summary>
    [Serializable()]
    public class PB_PANGZHANJIANLI_JILU : IEntity
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
		/// String:施工合同段
		/// </summary>                       
		public String PB_SHIGONGHETONGDUAN { get;set;}         
		/// <summary>
		/// String:编号
		/// </summary>                       
		public String PB_BIANHAO { get;set;}         
		/// <summary>
		/// DateTime:日期
		/// </summary>                       
		public DateTime PB_RIQI { get;set;}         
		/// <summary>
		/// String:气候
		/// </summary>                       
		public String PB_QIHOU { get;set;}         
		/// <summary>
		/// String:工程地点
		/// </summary>                       
		public String PB_GONGCHENGDIDIAN { get;set;}         
		/// <summary>
		/// String:旁站监理部位或工序
		/// </summary>                       
		public String PB_JIANLIBUWEIHUOGONGXU { get;set;}         
		/// <summary>
		/// DateTime:旁站监理开始日期
		/// </summary>                       
		public DateTime PB_JIANLIKAISHIRIQI { get;set;}         
		/// <summary>
		/// String:旁站监理开始时间
		/// </summary>                       
		public String PB_JIANLIKAISHISHIJIAN { get;set;}         
		/// <summary>
		/// DateTime:旁站监理结束日期
		/// </summary>                       
		public DateTime PB_JIANLIJIESHURIQI { get;set;}         
		/// <summary>
		/// String:旁站监理结束时间
		/// </summary>                       
		public String PB_JIANLIJIESHUSHIJIAN { get;set;}         
		/// <summary>
		/// String:施工情况
		/// </summary>                       
		public String PB_SHIGONGQINGKUANG { get;set;}         
		/// <summary>
		/// String:监理情况
		/// </summary>                       
		public String PB_JIANLIQINGKUANG { get;set;}         
		/// <summary>
		/// String:发现问题
		/// </summary>                       
		public String PB_FAXIANWENTI { get;set;}         
		/// <summary>
		/// String:处理意见
		/// </summary>                       
		public String PB_CHULIYIJIAN { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:旁站监理人员（签字）
		/// </summary>                       
		public String PB_JIANLIRENYUAN { get;set;}         
		/// <summary>
		/// DateTime:日期
		/// </summary>                       
		public DateTime PB_JIANLIRIQI { get;set;}         
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
	