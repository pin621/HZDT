using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：GNSSStation 
    /// </summary>
    [Serializable()]
    public class GNSSStation : IEntity
    {    
		         
		/// <summary>
		/// Int32:自增 主键
		/// </summary>                       
		public Int32 Stationid { get;set;}         
		/// <summary>
		/// String:对应工程id(不能为空)
		/// </summary>                       
		public String Projectid { get;set;}         
		/// <summary>
		/// String:站名
		/// </summary>                       
		public String StationName { get;set;}         
		/// <summary>
		/// String:站类型
		/// </summary>                       
		public String StationType { get;set;}         
		/// <summary>
		/// String:监测点名称（不含基准站）
		/// </summary>                       
		public String MonitorPoint { get;set;}         
		/// <summary>
		/// Int32:是否在线
		/// </summary>                       
		public Int32 IsOnLine { get;set;}         
		/// <summary>
		/// Int32:用来判断在该工程中是否在使用，1代表使用，0代表不使用了
		/// </summary>                       
		public Int32 sfsy { get;set;}         
		/// <summary>
		/// Decimal:水平位移1级预警
		/// </summary>                       
		public Decimal shuipingyiji { get;set;}         
		/// <summary>
		/// Decimal:水平位移2级预警
		/// </summary>                       
		public Decimal shuipingerji { get;set;}         
		/// <summary>
		/// Decimal:垂直位移1级预警
		/// </summary>                       
		public Decimal chuizhiyiji { get;set;}         
		/// <summary>
		/// Decimal:垂直位移2级预警
		/// </summary>                       
		public Decimal chuizhierji { get;set;}         
		/// <summary>
		/// String:监测点类型(线\背\上\下\)
		/// </summary>                       
		public String Jiancedianleixing { get;set;}         
		/// <summary>
		/// Decimal:计算水平位移角度（S北*cos（α-90）+S东*cos α)
		/// </summary>                       
		public Decimal Jiaodu { get;set;}         
		/// <summary>
		/// String:监测点的类型（来自字典维护中）
		/// </summary>                       
		public String jcdlx { get;set;}         
		/// <summary>
		/// Int32:连续超过报警值次数（用来卡控是否显示报警）
		/// </summary>                       
		public Int32 lxbjzsz { get;set;}   
    }    
}
	