using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：SZDatum_Catalog 
    /// </summary>
    [Serializable()]
    public class SZDatum_Catalog : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 SQLID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ParentID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PrjID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String GUID { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 LevelID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PrjName { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String VolumnNo { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String QZLC { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String SysID { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 CheckPass { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String SendDT { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 OrderNo { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Remark { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 DatumType { get;set;}   
    }    
}
	