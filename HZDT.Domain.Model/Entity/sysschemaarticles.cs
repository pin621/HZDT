using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：sysschemaarticles 
    /// </summary>
    [Serializable()]
    public class sysschemaarticles : IEntity
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
		public String description { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String dest_object { get;set;}         
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
		/// Int32:
		/// </summary>                       
		public Int32 status { get;set;}         
		/// <summary>
		/// Byte:
		/// </summary>                       
		public Byte type { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] schema_option { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String dest_owner { get;set;}   
    }    
}
	