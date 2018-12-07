using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANCEBAOBIAO_SHUIWEI 
    /// </summary>
    [Serializable()]
    public class PB_JIANCEBAOBIAO_SHUIWEI : IEntity
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
		/// Decimal:初始高程
		/// </summary>                       
		public Decimal PB_CSGC { get;set;}         
		/// <summary>
		/// Decimal:本次高程
		/// </summary>                       
		public Decimal PB_BCGC { get;set;}         
		/// <summary>
		/// Decimal:上次高程
		/// </summary>                       
		public Decimal PB_SCGC { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_KONGHAO { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ZUHAO { get;set;}         
		/// <summary>
		/// Decimal:本次变化量
		/// </summary>                       
		public Decimal PB_BCBHL { get;set;}         
		/// <summary>
		/// Decimal:累计变化量
		/// </summary>                       
		public Decimal PB_LJBHL { get;set;}         
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
	