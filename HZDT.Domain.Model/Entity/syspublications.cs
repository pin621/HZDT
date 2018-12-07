using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：syspublications 
    /// </summary>
    [Serializable()]
    public class syspublications : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String description { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String name { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 pubid { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte repl_freq { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte status { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte sync_method { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] snapshot_jobid { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean independent_agent { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean immediate_sync { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean enabled_for_internet { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean allow_push { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean allow_pull { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean allow_anonymous { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean immediate_sync_ready { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean allow_sync_tran { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean autogen_sync_procs { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 retention { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean allow_queued_tran { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean snapshot_in_defaultfolder { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String alt_snapshot_folder { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String pre_snapshot_script { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String post_snapshot_script { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean compress_snapshot { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ftp_address { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 ftp_port { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ftp_subdirectory { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ftp_login { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ftp_password { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean allow_dts { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean allow_subscription_copy { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean centralized_conflicts { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 conflict_retention { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 conflict_policy { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 queue_type { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ad_guidname { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 backward_comp_level { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean allow_initialize_from_backup { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] min_autonosync_lsn { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 replicate_ddl { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 options { get;set;}   
    }    
}
	