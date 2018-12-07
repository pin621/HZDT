using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JINDUZHUZHUANGTU 
    /// </summary>
    [Serializable()]
    public class PB_JINDUZHUZHUANGTU : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}   
    }    
}
	