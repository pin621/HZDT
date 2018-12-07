using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：MSpeer_request 
    /// </summary>
    [Serializable()]
    public class MSpeer_request : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String publication { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime sent_date { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String description { get;set;}   
    }    
}
	