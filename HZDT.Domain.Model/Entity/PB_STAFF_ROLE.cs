using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_STAFF_ROLE 
    /// </summary>
    [Serializable()]
    public class PB_STAFF_ROLE : IEntity
    {    
		         
		/// <summary>
		/// String:登录ID
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// String:角色ID
		/// </summary>                       
		public String PB_ROLE_ID { get;set;}   
    }    
}
	