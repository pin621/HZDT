using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：MSpeer_response 
    /// </summary>
    [Serializable()]
    public class MSpeer_response : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 request_id { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String peer { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String peer_db { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime received_date { get;set;}   
    }    
}
	