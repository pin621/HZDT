using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：GNSSResoveData_SJBHL 
    /// </summary>
    [Serializable()]
    public class GNSSResoveData_SJBHL : IEntity
    {    
		         
		/// <summary>
		/// Int32:自增主键
		/// </summary>                       
		public Int32 Resoveid { get;set;}         
		/// <summary>
		/// Decimal:东方向变化量
		/// </summary>                       
		public Decimal LE { get;set;}         
		/// <summary>
		/// Decimal:北方向变化量
		/// </summary>                       
		public Decimal LN { get;set;}         
		/// <summary>
		/// Decimal:高方向
		/// </summary>                       
		public Decimal DH { get;set;}         
		/// <summary>
		/// Decimal:基线长
		/// </summary>                       
		public Decimal BaseLength { get;set;}         
		/// <summary>
		/// DateTime:时间
		/// </summary>                       
		public DateTime RWriteTime { get;set;}         
		/// <summary>
		/// String:监测点
		/// </summary>                       
		public String MonitorPoint { get;set;}         
		/// <summary>
		/// String:表内标记站名
		/// </summary>                       
		public String StationName { get;set;}         
		/// <summary>
		/// String:对应工程的id(不能为空)
		/// </summary>                       
		public String Projectid { get;set;}   
    }    
}
	