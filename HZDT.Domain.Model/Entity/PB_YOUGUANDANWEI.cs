using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_YOUGUANDANWEI 
    /// </summary>
    [Serializable()]
    public class PB_YOUGUANDANWEI : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程项目ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:单位名称
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:联系人
		/// </summary>                       
		public String PB_LIANXIREN { get;set;}         
		/// <summary>
		/// String:联系人职务
		/// </summary>                       
		public String PB_LIANXIRENZHIWU { get;set;}         
		/// <summary>
		/// String:单位类别
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
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
		/// String:备注
		/// </summary>                       
		public String PB_REMARK { get;set;}         
		/// <summary>
		/// Int32:排序ID
		/// </summary>                       
		public Int32 PB_ORDER_ID { get;set;}   
    }    
}
	