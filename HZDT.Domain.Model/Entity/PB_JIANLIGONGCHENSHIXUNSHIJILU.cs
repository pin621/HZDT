using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANLIGONGCHENSHIXUNSHIJILU 
    /// </summary>
    [Serializable()]
    public class PB_JIANLIGONGCHENSHIXUNSHIJILU : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:编号
		/// </summary>                       
		public String PB_BIANHAO { get;set;}         
		/// <summary>
		/// String:工程编号
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// DateTime:巡视日期
		/// </summary>                       
		public DateTime PB_XSRQ { get;set;}         
		/// <summary>
		/// String:时
		/// </summary>                       
		public String PB_SHI { get;set;}         
		/// <summary>
		/// String:分
		/// </summary>                       
		public String PB_FEN { get;set;}         
		/// <summary>
		/// String:巡视地点
		/// </summary>                       
		public String PB_XSDD { get;set;}         
		/// <summary>
		/// String:存在问题
		/// </summary>                       
		public String PB_CZWT { get;set;}         
		/// <summary>
		/// String:处理意见
		/// </summary>                       
		public String PB_CLYJ { get;set;}         
		/// <summary>
		/// String:总监签名
		/// </summary>                       
		public String PB_ZJQM { get;set;}         
		/// <summary>
		/// DateTime:签名日期
		/// </summary>                       
		public DateTime PB_QMRQ { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ZDBH { get;set;}         
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
	