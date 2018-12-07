using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANCEBAOBIAO_XINGBIAN 
    /// </summary>
    [Serializable()]
    public class PB_JIANCEBAOBIAO_XINGBIAN : IEntity
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
		/// String:监测点id
		/// </summary>                       
		public String PB_JIANCEDAINID { get;set;}         
		/// <summary>
		/// String:监测点名称
		/// </summary>                       
		public String PB_JIANCEDAINNAME { get;set;}         
		/// <summary>
		/// Decimal:水平本次测试值
		/// </summary>                       
		public Decimal PB_SPBCCSZ { get;set;}         
		/// <summary>
		/// Decimal:水平单次变化
		/// </summary>                       
		public Decimal PB_SPDCBH { get;set;}         
		/// <summary>
		/// Decimal:水平累计变化量
		/// </summary>                       
		public Decimal PB_SPLJBHL { get;set;}         
		/// <summary>
		/// Decimal:水平变化速率
		/// </summary>                       
		public Decimal PB_SPBHSL { get;set;}         
		/// <summary>
		/// Decimal:垂直本次测试值
		/// </summary>                       
		public Decimal PB_CZBCCSZ { get;set;}         
		/// <summary>
		/// Decimal:垂直单次变化
		/// </summary>                       
		public Decimal PB_CZDCBH { get;set;}         
		/// <summary>
		/// Decimal:垂直累计变换量
		/// </summary>                       
		public Decimal PB_CZLJBHL { get;set;}         
		/// <summary>
		/// Decimal:垂直变化速率
		/// </summary>                       
		public Decimal PB_CZBHSL { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}   
    }    
}
	