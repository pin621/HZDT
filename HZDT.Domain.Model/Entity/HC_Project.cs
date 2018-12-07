using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_Project 
    /// </summary>
    [Serializable()]
    public class HC_Project : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 id { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PName { get;set;}   
    }    
}
	