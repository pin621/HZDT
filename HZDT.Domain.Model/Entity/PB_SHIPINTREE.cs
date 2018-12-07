using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SHIPINTREE 
    /// </summary>
    [Serializable()]
    public class PB_SHIPINTREE : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_PARENTID { get;set;}   
    }    
}
	