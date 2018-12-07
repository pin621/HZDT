using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_KAKONGDENGJIJIANCHABIAO 
    /// </summary>
    [Serializable()]
    public class PB_KAKONGDENGJIJIANCHABIAO : IEntity
    {    
		         
		/// <summary>
		/// String:卡控登记检查ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程项目ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:年
		/// </summary>                       
		public String PB_NIAN { get;set;}         
		/// <summary>
		/// DateTime:检查日期
		/// </summary>                       
		public DateTime PB_JIANCHARIQI { get;set;}         
		/// <summary>
		/// String:字段1
		/// </summary>                       
		public String PB_FIELD1 { get;set;}         
		/// <summary>
		/// String:字段2
		/// </summary>                       
		public String PB_FIELD2 { get;set;}         
		/// <summary>
		/// String:字段3
		/// </summary>                       
		public String PB_FIELD3 { get;set;}         
		/// <summary>
		/// String:字段4
		/// </summary>                       
		public String PB_FIELD4 { get;set;}         
		/// <summary>
		/// String:检查人
		/// </summary>                       
		public String PB_JIANCHAREN { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:类别
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}   
    }    
}
	