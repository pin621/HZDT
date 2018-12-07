using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：sysarticleupdates 
    /// </summary>
    [Serializable()]
    public class sysarticleupdates : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 artid { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 pubid { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 sync_ins_proc { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 sync_upd_proc { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 sync_del_proc { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean autogen { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 sync_upd_trig { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 conflict_tableid { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 ins_conflict_proc { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean identity_support { get;set;}   
    }    
}
	