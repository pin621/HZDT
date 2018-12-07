using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：MSpeer_lsns 
    /// </summary>
    [Serializable()]
    public class MSpeer_lsns : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime last_updated { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String originator { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String originator_db { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String originator_publication { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 originator_publication_id { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 originator_db_version { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] originator_lsn { get;set;}   
    }    
}
	