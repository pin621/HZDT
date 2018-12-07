using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_USER 
    /// </summary>
    [Serializable()]
    public class PB_USER : IEntity
    {    
		         
		/// <summary>
		/// String:登录ID
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// String:登录密码
		/// </summary>                       
		public String PB_PASSWORD { get;set;}         
		/// <summary>
		/// String:姓名
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// Int32:性别
		/// </summary>                       
		public Int32 PB_SEX { get;set;}         
		/// <summary>
		/// DateTime:出生日期
		/// </summary>                       
		public DateTime PB_BIRTHDAY { get;set;}         
		/// <summary>
		/// String:身份证号
		/// </summary>                       
		public String PB_ID_CARD { get;set;}         
		/// <summary>
		/// String:办公电话
		/// </summary>                       
		public String PB_OFFICE_PHONE { get;set;}         
		/// <summary>
		/// String:家庭电话
		/// </summary>                       
		public String PB_FAMILY_PHONE { get;set;}         
		/// <summary>
		/// String:手机
		/// </summary>                       
		public String PB_CELL_PHONE { get;set;}         
		/// <summary>
		/// String:Email
		/// </summary>                       
		public String PB_EMAIL { get;set;}         
		/// <summary>
		/// String:通讯地址
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
		/// Int32:已禁用
		/// </summary>                       
		public Int32 PB_DISABLED { get;set;}         
		/// <summary>
		/// DateTime:注册时间
		/// </summary>                       
		public DateTime PB_REGISTER_DATE { get;set;}   
    }    
}
	