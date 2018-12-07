using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：swz_url_str 
    /// </summary>
    [Serializable()]
    public class swz_url_str : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String url_string { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime url_date { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String flag { get;set;}   
    }    
}
	