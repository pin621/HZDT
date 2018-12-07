using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_UNITS 
    /// </summary>
    [Serializable()]
    public class PB_UNITS : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:上级部门ID
		/// </summary>                       
		public String PB_PARENT_ID { get;set;}         
		/// <summary>
		/// String:名称
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:电话
		/// </summary>                       
		public String PB_PHONE { get;set;}         
		/// <summary>
		/// String:分机号码
		/// </summary>                       
		public String PB_EXT_NUMBER { get;set;}         
		/// <summary>
		/// String:传真
		/// </summary>                       
		public String PB_FAX { get;set;}         
		/// <summary>
		/// String:卡信息的类别
		/// </summary>                       
		public String PB_TYPE { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_REMARK { get;set;}         
		/// <summary>
		/// Int32:排序ID
		/// </summary>                       
		public Int32 PB_ORDER_ID { get;set;}   
    }    
}
	