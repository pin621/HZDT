using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_CX_SETTING 
    /// </summary>
    [Serializable()]
    public class HC_CX_SETTING : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String sn { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String stnumber { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Lvalue { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String xInitValue { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String yInitValue { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 Cpoint { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Kx1 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Kx2 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Kx3 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ex1 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ex2 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ex3 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Bx0 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ex0 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ky1 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ky2 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ky3 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ey1 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ey2 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ey3 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String By0 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Ey0 { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String xones { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String xonex { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String xtwos { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String xtwox { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String xthrees { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String xthreex { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String yones { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String yonex { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ytwos { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ytwox { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ythrees { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ythreex { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String konghao { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PID { get;set;}         
		/// <summary>
		/// Int32:设备是否使用中1代表使用的，0代表停用的
		/// </summary>                       
		public Int32 sfsy { get;set;}         
		/// <summary>
		/// Int32:连续超过报警值次数（用来卡控是否显示报警）
		/// </summary>                       
		public Int32 lxbjzsz { get;set;}   
    }    
}
	