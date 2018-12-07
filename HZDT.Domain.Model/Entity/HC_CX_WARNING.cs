using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_CX_WARNING 
    /// </summary>
    [Serializable()]
    public class HC_CX_WARNING : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String 传感器地址 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String 测点 { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime 预警时间 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String 预警级别 { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal 预警数据 { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PID { get;set;}         
		/// <summary>
		/// Int32:判断短信发送的状态0代表未发，1代表发送成功，2代表发送不成功
		/// </summary>                       
		public Int32 dxfszt { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime createtime { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String konghao { get;set;}   
    }    
}
	