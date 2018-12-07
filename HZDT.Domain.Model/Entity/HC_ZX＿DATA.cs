using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_ZX＿DATA 
    /// </summary>
    [Serializable()]
    public class HC_ZX＿DATA : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 编号 { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 ModuleNum { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 channel { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String selfNum { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime DataTime { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal Fre { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal Temp { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal wll { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String konghao { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Zuhao { get;set;}         
		/// <summary>
		/// Decimal:本次变化量
		/// </summary>                       
		public Decimal bencibianhualiang { get;set;}         
		/// <summary>
		/// Decimal:变化速率
		/// </summary>                       
		public Decimal bianhuasulv { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal ShuiWeiGaoCheng { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String LeiJiBianHuaLiang { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PID { get;set;}         
		/// <summary>
		/// Int32:是否是报警的记录,0:不报警,1:报警
		/// </summary>                       
		public Int32 sfbj { get;set;}   
    }    
}
	