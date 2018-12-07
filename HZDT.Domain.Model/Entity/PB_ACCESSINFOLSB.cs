using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ACCESSINFOLSB 
    /// </summary>
    [Serializable()]
    public class PB_ACCESSINFOLSB : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// String:卡号
		/// </summary>                       
		public String PB_CODE { get;set;}         
		/// <summary>
		/// String:进出门号
		/// </summary>                       
		public String PB_DOORINTO { get;set;}         
		/// <summary>
		/// String:进出门号
		/// </summary>                       
		public String PB_DOOROUT { get;set;}         
		/// <summary>
		/// String:进出时的截图
		/// </summary>                       
		public String PB_IMAGEINTO { get;set;}         
		/// <summary>
		/// String:进出时的截图
		/// </summary>                       
		public String PB_IMAGEOUT { get;set;}         
		/// <summary>
		/// DateTime:进出标志
		/// </summary>                       
		public DateTime PB_ACCESSDATEINTO { get;set;}         
		/// <summary>
		/// DateTime:进出标志
		/// </summary>                       
		public DateTime PB_ACCESSDATEOUT { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECTID { get;set;}         
		/// <summary>
		/// String:进出门号
		/// </summary>                       
		public String PB_AREAINTO { get;set;}         
		/// <summary>
		/// String:进出门号
		/// </summary>                       
		public String PB_AREAOUT { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_TYPE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ZHIWU { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}   
    }    
}
	