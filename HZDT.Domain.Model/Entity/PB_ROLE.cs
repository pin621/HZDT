using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ROLE 
    /// </summary>
    [Serializable()]
    public class PB_ROLE : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PARENT_ID { get;set;}         
		/// <summary>
		/// String:角色分类ID
		/// </summary>                       
		public String PB_ROLE_TYPE_ID { get;set;}         
		/// <summary>
		/// String:名称
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_REMARK { get;set;}         
		/// <summary>
		/// Int32:排序ID
		/// </summary>                       
		public Int32 PB_ORDER_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEIID_ARR { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_IS_ADMIN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_JIBIE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEIID { get;set;}   
    }    
}
	