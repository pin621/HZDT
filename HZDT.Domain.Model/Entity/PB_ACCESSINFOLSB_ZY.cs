using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ACCESSINFOLSB_ZY 
    /// </summary>
    [Serializable()]
    public class PB_ACCESSINFOLSB_ZY : IEntity
    {    
		         
		/// <summary>
		/// Int64:进出记录自增ID
		/// </summary>                       
		public Int64 PB_ID { get;set;}         
		/// <summary>
		/// String:卡号
		/// </summary>                       
		public String PB_CODE { get;set;}         
		/// <summary>
		/// String:进入门号
		/// </summary>                       
		public String PB_DOORINTO { get;set;}         
		/// <summary>
		/// String:出去门号
		/// </summary>                       
		public String PB_DOOROUT { get;set;}         
		/// <summary>
		/// String:进入时的截图
		/// </summary>                       
		public String PB_IMAGEINTO { get;set;}         
		/// <summary>
		/// String:出去时的截图
		/// </summary>                       
		public String PB_IMAGEOUT { get;set;}         
		/// <summary>
		/// DateTime:进入时间
		/// </summary>                       
		public DateTime PB_ACCESSDATEINTO { get;set;}         
		/// <summary>
		/// DateTime:出去时间
		/// </summary>                       
		public DateTime PB_ACCESSDATEOUT { get;set;}         
		/// <summary>
		/// String:工程项目编号
		/// </summary>                       
		public String PB_PROJECTID { get;set;}         
		/// <summary>
		/// String:进入区域
		/// </summary>                       
		public String PB_AREAINTO { get;set;}         
		/// <summary>
		/// String:出去区域
		/// </summary>                       
		public String PB_AREAOUT { get;set;}         
		/// <summary>
		/// String:卡对应的人员姓名(如果是报警记录就没有姓名)
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:该条卡记录的类别(人员:personnel,设备:equipment)
		/// </summary>                       
		public String PB_TYPE { get;set;}         
		/// <summary>
		/// String:卡对应的人员职位
		/// </summary>                       
		public String PB_ZHIWU { get;set;}         
		/// <summary>
		/// String:登录查询的用户ID
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}   
    }    
}
	