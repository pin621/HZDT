using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_QIANSHOU_BIAO 
    /// </summary>
    [Serializable()]
    public class PB_QIANSHOU_BIAO : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_WENJIAN_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:签收描述
		/// </summary>                       
		public String PB_DESCRIPTION { get;set;}         
		/// <summary>
		/// String:签收人
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:签收时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}   
    }    
}
	