using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SELECTACCESSINFO 
    /// </summary>
    [Serializable()]
    public class PB_SELECTACCESSINFO : IEntity
    {    
		         
		/// <summary>
		/// String:查询人员的ID
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:卡号
		/// </summary>                       
		public String PB_CODE { get;set;}         
		/// <summary>
		/// String:进门号
		/// </summary>                       
		public String PB_INTODOOR { get;set;}         
		/// <summary>
		/// String:出门号
		/// </summary>                       
		public String PB_OUTDOOR { get;set;}         
		/// <summary>
		/// String:姓名
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:进出类别
		/// </summary>                       
		public String PB_TYPE { get;set;}         
		/// <summary>
		/// String:职务
		/// </summary>                       
		public String PB_ZHIWU { get;set;}         
		/// <summary>
		/// String:进时的截图
		/// </summary>                       
		public String PB_INTOIMAGE { get;set;}         
		/// <summary>
		/// String:出时的截图
		/// </summary>                       
		public String PB_OUTIMAGE { get;set;}         
		/// <summary>
		/// DateTime:进时间
		/// </summary>                       
		public DateTime PB_INTOACCESSDATE { get;set;}         
		/// <summary>
		/// DateTime:出时间
		/// </summary>                       
		public DateTime PB_OUTACCESSDATE { get;set;}   
    }    
}
	