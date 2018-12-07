using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_STAFF_MODULE_RIGHT_GRANT 
    /// </summary>
    [Serializable()]
    public class PB_STAFF_MODULE_RIGHT_GRANT : IEntity
    {    
		         
		/// <summary>
		/// String:登录ID
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// String:权限ID
		/// </summary>                       
		public String PB_RIGHT_ID { get;set;}   
    }    
}
	