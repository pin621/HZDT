using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_DEVICEONLINELOG 
    /// </summary>
    [Serializable()]
    public class PB_DEVICEONLINELOG : IEntity
    {    
		         
		/// <summary>
		/// Int64:
		/// </summary>                       
		public Int64 PB_ID { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_DEVICEID { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal PB_ACTION { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_DATE { get;set;}   
    }    
}
	