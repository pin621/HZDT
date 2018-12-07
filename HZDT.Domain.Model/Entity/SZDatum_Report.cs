using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：SZDatum_Report 
    /// </summary>
    [Serializable()]
    public class SZDatum_Report : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 SQLID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String DatumID { get;set;}         
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
		public Int32 RepID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String BH { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String RepName { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PrjBW { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String RepExt { get;set;}         
		/// <summary>
		/// Byte[]:
		/// </summary>                       
		public Byte[] RepLIL { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String WGRQ { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String SendDT { get;set;}         
		/// <summary>
		/// Double:
		/// </summary>                       
		public Double OverHour { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String JLCheckDT { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String CheckYH { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 CheckPass { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String CreateDT { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String EDitDT { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 OrderNo { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Remark { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String SendRY { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String SignUser { get;set;}   
    }    
}
	