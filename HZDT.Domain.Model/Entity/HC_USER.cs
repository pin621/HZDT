using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_USER 
    /// </summary>
    [Serializable()]
    public class HC_USER : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String name1 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String password1 { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Role { get;set;}   
    }    
}
	