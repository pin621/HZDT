using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_ZX_SETTING 
    /// </summary>
    [Serializable()]
    public class HC_ZX_SETTING : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 ModuleNum { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String stnumber { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 Channel { get;set;}         
		/// <summary>
		/// Single:
		/// </summary>                       
		public Single FKValue { get;set;}         
		/// <summary>
		/// Single:
		/// </summary>                       
		public Single TKValue { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String InitialFre { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String InitialTemp { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Uint { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Type { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String cpoint { get;set;}         
		/// <summary>
		/// Double:
		/// </summary>                       
		public Double WarnValue { get;set;}         
		/// <summary>
		/// Double:
		/// </summary>                       
		public Double WarXValue { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Direction { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String XiuZhengLiang { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String KongHao { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Zuhao { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ChuShiShuiWeiShenDu { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String ChuSHiShuiWeiGaoCheng { get;set;}         
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
	