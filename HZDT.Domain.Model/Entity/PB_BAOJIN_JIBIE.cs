using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_BAOJIN_JIBIE 
    /// </summary>
    [Serializable()]
    public class PB_BAOJIN_JIBIE : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ROLE_ID { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_BJJB { get;set;}   
    }    
}
	