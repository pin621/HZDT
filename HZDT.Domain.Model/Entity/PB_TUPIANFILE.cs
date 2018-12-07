using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_TUPIANFILE 
    /// </summary>
    [Serializable()]
    public class PB_TUPIANFILE : IEntity
    {    
		         
		/// <summary>
		/// String:文件ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:标题
		/// </summary>                       
		public String PB_TITLE { get;set;}         
		/// <summary>
		/// String:图号
		/// </summary>                       
		public String PB_TUHAO { get;set;}         
		/// <summary>
		/// String:工程项目ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:内容
		/// </summary>                       
		public String PB_CONTENT { get;set;}         
		/// <summary>
		/// String: 图片类别
		/// </summary>                       
		public String PB_KINDSID { get;set;}         
		/// <summary>
		/// String:审核
		/// </summary>                       
		public String PB_SHENHE { get;set;}         
		/// <summary>
		/// String:部门ID
		/// </summary>                       
		public String PB_DEPARTMENT_ID { get;set;}         
		/// <summary>
		/// Int32:已禁用
		/// </summary>                       
		public Int32 PB_DISABLED { get;set;}         
		/// <summary>
		/// Int32:排序ID
		/// </summary>                       
		public Int32 PB_ORDER_ID { get;set;}         
		/// <summary>
		/// String:图片附件
		/// </summary>                       
		public String PB_FUJIAN { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_QDRQ { get;set;}   
    }    
}
	