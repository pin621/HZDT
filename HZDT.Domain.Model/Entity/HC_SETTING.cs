using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_SETTING 
    /// </summary>
    [Serializable()]
    public class HC_SETTING : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ComDtu { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 DTUBaudrate { get;set;}   
    }    
}
	