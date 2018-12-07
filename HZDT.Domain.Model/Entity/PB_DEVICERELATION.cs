using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_DEVICERELATION 
    /// </summary>
    [Serializable()]
    public class PB_DEVICERELATION : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DOORTYPE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DOORINFO { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECTID { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_CLEARTIME { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal PB_CLEARED { get;set;}   
    }    
}
	