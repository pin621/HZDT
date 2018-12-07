using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ACCESSINFO_ZY 
    /// </summary>
    [Serializable()]
    public class PB_ACCESSINFO_ZY : IEntity
    {    
		         
		/// <summary>
		/// Int64:进出实时记录ID
		/// </summary>                       
		public Int64 PB_ID { get;set;}         
		/// <summary>
		/// String:卡号
		/// </summary>                       
		public String PB_CODE { get;set;}         
		/// <summary>
		/// String:进出标志
		/// </summary>                       
		public String PB_ACCESS { get;set;}         
		/// <summary>
		/// String:进出门号
		/// </summary>                       
		public String PB_DOOR { get;set;}         
		/// <summary>
		/// String:进出时的截图
		/// </summary>                       
		public String PB_IMAGE { get;set;}         
		/// <summary>
		/// DateTime:人员进出时间
		/// </summary>                       
		public DateTime PB_ACCESSDATE { get;set;}         
		/// <summary>
		/// String:进出工程项目的ID
		/// </summary>                       
		public String PB_PROJECTID { get;set;}         
		/// <summary>
		/// String:进出区域
		/// </summary>                       
		public String PB_AREA { get;set;}         
		/// <summary>
		/// String:进出人员姓名(如果是报警记录就没有姓名)
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:类型(人员:personnel,设备:equipment)
		/// </summary>                       
		public String PB_TYPE { get;set;}         
		/// <summary>
		/// String:进出人员职务
		/// </summary>                       
		public String PB_ZHIWU { get;set;}   
    }    
}
	