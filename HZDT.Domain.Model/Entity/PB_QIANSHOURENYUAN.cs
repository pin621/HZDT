using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_QIANSHOURENYUAN 
    /// </summary>
    [Serializable()]
    public class PB_QIANSHOURENYUAN : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_QIANSHOU_ID { get;set;}   
    }    
}
	