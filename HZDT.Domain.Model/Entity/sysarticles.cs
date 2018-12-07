using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：sysarticles 
    /// </summary>
    [Serializable()]
    public class sysarticles : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 artid { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String creation_script { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String del_cmd { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String description { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String dest_table { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 filter { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String filter_clause { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ins_cmd { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String name { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 objid { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 pubid { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte pre_creation_cmd { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte status { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 sync_objid { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte type { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String upd_cmd { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] schema_option { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String dest_owner { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 ins_scripting_proc { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 del_scripting_proc { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 upd_scripting_proc { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String custom_script { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean fire_triggers_on_snapshot { get;set;}   
    }    
}
	