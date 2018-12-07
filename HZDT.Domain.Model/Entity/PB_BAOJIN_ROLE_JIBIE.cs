using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_BAOJIN_ROLE_JIBIE 
    /// </summary>
    [Serializable()]
    public class PB_BAOJIN_ROLE_JIBIE : IEntity
    {    
		         
		/// <summary>
		/// String:对应的角色id
		/// </summary>                       
		public String PB_ROLE_ID { get;set;}         
		/// <summary>
		/// Int32:报警级别，2代表黄色报警，1代表红色报警
		/// </summary>                       
		public Int32 PB_BJJB { get;set;}   
    }    
}
	