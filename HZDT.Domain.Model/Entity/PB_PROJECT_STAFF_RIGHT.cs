using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PROJECT_STAFF_RIGHT 
    /// </summary>
    [Serializable()]
    public class PB_PROJECT_STAFF_RIGHT : IEntity
    {    
		         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:职员ID
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}   
    }    
}
	