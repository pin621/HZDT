using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ZHUZHAUNGTUNEIRONG 
    /// </summary>
    [Serializable()]
    public class PB_ZHUZHAUNGTUNEIRONG : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_XIANGMU { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal PB_JIHUAWANCHENG { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal PB_SHIJIWANCHENG { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}   
    }    
}
	