using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：syssubscriptions 
    /// </summary>
    [Serializable()]
    public class syssubscriptions : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 artid { get;set;}         
		/// <summary>
		/// Int16:
		/// </summary>                       
		public Int16 srvid { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String dest_db { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte status { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte sync_type { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String login_name { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 subscription_type { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] distribution_jobid { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] timestamp { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte update_mode { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean loopback_detection { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean queued_reinit { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte nosync_type { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String srvname { get;set;}   
    }    
}
	