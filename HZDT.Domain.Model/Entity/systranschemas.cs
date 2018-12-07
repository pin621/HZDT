using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：systranschemas 
    /// </summary>
    [Serializable()]
    public class systranschemas : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 tabid { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] startlsn { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] endlsn { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 typeid { get;set;}   
    }    
}
	