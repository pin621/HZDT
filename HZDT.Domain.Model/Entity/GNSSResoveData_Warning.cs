using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：GNSSResoveData_Warning 
    /// </summary>
    [Serializable()]
    public class GNSSResoveData_Warning : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// Int32:自增主键
		/// </summary>                       
		public Int32 Resoveid { get;set;}         
		/// <summary>
		/// Decimal:报警值
		/// </summary>                       
		public Decimal Bjz { get;set;}         
		/// <summary>
		/// Int32:报警类别1代表水平2代表垂直
		/// </summary>                       
		public Int32 bjlb { get;set;}         
		/// <summary>
		/// Int32:报警级别
		/// </summary>                       
		public Int32 bjjb { get;set;}         
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
		/// <summary>
		/// Int32:是否实时数据，分为月报和实时报
		/// </summary>                       
		public Int32 sfss { get;set;}         
		/// <summary>
		/// Int32:判断短信发送的状态0代表未发，1代表发送成功，2代表发送不成功
		/// </summary>                       
		public Int32 dxfszt { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime createtime { get;set;}   
    }    
}
	