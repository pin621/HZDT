using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PERSONNEL 
    /// </summary>
    [Serializable()]
    public class PB_PERSONNEL : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_CODE { get;set;}         
		/// <summary>
		/// String:登录ID
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PASSWORD { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_UNITS_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PHOTO { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_SEX { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_MARRIED { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID_CARD { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_CATEGORY_TAG { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_COUNTRY_TAG { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_NATION_TAG { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_POSITION_TAG { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_TITLE_TAG { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_POLITICAL_APPEARANCE_TAG { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DEGREE_TAG { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_BIRTHDAY { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_ENTERS_DAY { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_LEAVES_DAY { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_OFFICE_PHONE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_EXT_NUMBER { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_FAMILY_PHONE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_CELL_PHONE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_EMAIL { get;set;}         
		/// <summary>
		/// String:家庭住址
		/// </summary>                       
		public String PB_ADDRESS { get;set;}         
		/// <summary>
		/// String:邮编
		/// </summary>                       
		public String PB_ZIP_CODE { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_REMARK { get;set;}         
		/// <summary>
		/// Int32:是否内置用户
		/// </summary>                       
		public Int32 PB_IS_INNER_USER { get;set;}         
		/// <summary>
		/// Int32:已禁用
		/// </summary>                       
		public Int32 PB_DISABLED { get;set;}         
		/// <summary>
		/// Int32:排序ID
		/// </summary>                       
		public Int32 PB_ORDER_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_TYPE { get;set;}   
    }    
}
	