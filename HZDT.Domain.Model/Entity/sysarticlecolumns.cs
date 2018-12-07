using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：sysarticlecolumns 
    /// </summary>
    [Serializable()]
    public class sysarticlecolumns : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 artid { get;set;}         
		/// <summary>
		/// Int16:
		/// </summary>                       
		public Int16 colid { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean is_udt { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean is_xml { get;set;}         
		/// <summary>
		/// Boolean:
		/// </summary>                       
		public Boolean is_max { get;set;}   
    }    
}
	