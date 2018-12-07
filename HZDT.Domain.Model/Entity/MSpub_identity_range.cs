using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：MSpub_identity_range 
    /// </summary>
    [Serializable()]
    public class MSpub_identity_range : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 objid { get;set;}         
		/// <summary>
		/// Int64:
		/// </summary>                       
		public Int64 range { get;set;}         
		/// <summary>
		/// Int64:
		/// </summary>                       
		public Int64 pub_range { get;set;}         
		/// <summary>
		/// Int64:
		/// </summary>                       
		public Int64 current_pub_range { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 threshold { get;set;}         
		/// <summary>
		/// Int64:
		/// </summary>                       
		public Int64 last_seed { get;set;}   
    }    
}
	