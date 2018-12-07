using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：sysdiagrams 
    /// </summary>
    [Serializable()]
    public class sysdiagrams : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String name { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 principal_id { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 diagram_id { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 version { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] definition { get;set;}   
    }    
}
	