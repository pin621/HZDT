using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANLIGONGCHENGSHI_TONGZHIDAN 
    /// </summary>
    [Serializable()]
    public class PB_JIANLIGONGCHENGSHI_TONGZHIDAN : IEntity
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
		/// String:
		/// </summary>                       
		public String PB_NEIRONG { get;set;}         
		/// <summary>
		/// String:专业监理工程师
		/// </summary>                       
		public String PB_ZHUANYEJIANLIGONGCHENGSHI { get;set;}         
		/// <summary>
		/// DateTime:发件日期
		/// </summary>                       
		public DateTime PB_FAJIANRIQI { get;set;}         
		/// <summary>
		/// String:发件时间
		/// </summary>                       
		public String PB_FAJIANSHIJIAN { get;set;}         
		/// <summary>
		/// String:收件人
		/// </summary>                       
		public String PB_SHOUJIANREN { get;set;}         
		/// <summary>
		/// DateTime:收件日期
		/// </summary>                       
		public DateTime PB_SHOUJIANRIQI { get;set;}         
		/// <summary>
		/// String:收件时间
		/// </summary>                       
		public String PB_SHOUJIANSHIJIAN { get;set;}         
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
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_IS_SIGNATRUE { get;set;}   
    }    
}
	