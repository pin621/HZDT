using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_MODULE_RIGHT 
    /// </summary>
    [Serializable()]
    public class PB_MODULE_RIGHT : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_MODULE_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_RIGHT_TAG { get;set;}   
    }    
}
	