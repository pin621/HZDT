using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ROLE_JIBIE_JIANCE 
    /// </summary>
    [Serializable()]
    public class PB_ROLE_JIBIE_JIANCE : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// String:角色id
		/// </summary>                       
		public String PB_ROLE_ID { get;set;}         
		/// <summary>
		/// Int32:报警级别：1代表红色报警，2代表黄色报警
		/// </summary>                       
		public Int32 PB_JIBIE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEIID { get;set;}   
    }    
}
	