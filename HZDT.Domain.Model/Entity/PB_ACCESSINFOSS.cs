using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ACCESSINFOSS 
    /// </summary>
    [Serializable()]
    public class PB_ACCESSINFOSS : IEntity
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
		/// DateTime:人员进入时间
		/// </summary>                       
		public DateTime PB_ACCESSDATE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECTID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_AREA { get;set;}         
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
    }    
}
	