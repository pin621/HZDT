using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：GNSSResoveDatass_js 
    /// </summary>
    [Serializable()]
    public class GNSSResoveDatass_js : IEntity
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
		/// Decimal:水平位移
		/// </summary>                       
		public Decimal Spwy { get;set;}         
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
		/// <summary>
		/// Decimal:水平位移变化速率
		/// </summary>                       
		public Decimal Spwybhsl { get;set;}         
		/// <summary>
		/// Decimal:垂直位移变化速率
		/// </summary>                       
		public Decimal dhbhsl { get;set;}         
		/// <summary>
		/// Int32:是否水平报警标志1代表报警0代表不报警
		/// </summary>                       
		public Int32 sfspbj { get;set;}         
		/// <summary>
		/// Int32:是否垂直报警标志1代表报警0代表不报警
		/// </summary>                       
		public Int32 sfczbj { get;set;}   
    }    
}
	