using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANCEBAOBIAO_CEXIE 
    /// </summary>
    [Serializable()]
    public class PB_JIANCEBAOBIAO_CEXIE : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// Int32:外键主表ID
		/// </summary>                       
		public Int32 PB_ZHUBIAOID { get;set;}         
		/// <summary>
		/// Int32:监测的数据id
		/// </summary>                       
		public Int32 PB_JIANCEID { get;set;}         
		/// <summary>
		/// String:监测点ID
		/// </summary>                       
		public String PB_JIANCEDAINID { get;set;}         
		/// <summary>
		/// String:监测点名称
		/// </summary>                       
		public String PB_JIANCEDAINNAME { get;set;}         
		/// <summary>
		/// Decimal:深度
		/// </summary>                       
		public Decimal PB_SD { get;set;}         
		/// <summary>
		/// Decimal:本次位移增量
		/// </summary>                       
		public Decimal PB_BCWYZL { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_KONGHAO { get;set;}         
		/// <summary>
		/// Decimal:累计位移
		/// </summary>                       
		public Decimal PB_LJWY { get;set;}         
		/// <summary>
		/// Decimal:变化速率
		/// </summary>                       
		public Decimal PB_BHSL { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}   
    }    
}
	