using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PROJECT_LAYOUT 
    /// </summary>
    [Serializable()]
    public class PB_PROJECT_LAYOUT : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:图片文件
		/// </summary>                       
		public String PB_IMAGES { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_IMAGES_Description { get;set;}   
    }    
}
	