using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANLITONGZHIHUIFUDAN 
    /// </summary>
    [Serializable()]
    public class PB_JIANLITONGZHIHUIFUDAN : IEntity
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
		/// String:项目监理机构
		/// </summary>                       
		public String PB_XMJLJG { get;set;}         
		/// <summary>
		/// String:收到编号
		/// </summary>                       
		public String PB_SDBIANHAO { get;set;}         
		/// <summary>
		/// String:说明情况
		/// </summary>                       
		public String PB_SMQK { get;set;}         
		/// <summary>
		/// String:项目经理
		/// </summary>                       
		public String PB_XMJL { get;set;}         
		/// <summary>
		/// DateTime:项目监理签字日期
		/// </summary>                       
		public DateTime PB_XMJLQZRQ { get;set;}         
		/// <summary>
		/// String:复查意见
		/// </summary>                       
		public String PB_FCYJ { get;set;}         
		/// <summary>
		/// String:总监理工程师
		/// </summary>                       
		public String PB_ZJLGCS { get;set;}         
		/// <summary>
		/// DateTime:总监理工程师签字日期
		/// </summary>                       
		public DateTime PB_ZJLQZRQ { get;set;}         
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
	