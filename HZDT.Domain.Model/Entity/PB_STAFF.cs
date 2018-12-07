using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_STAFF 
    /// </summary>
    [Serializable()]
    public class PB_STAFF : IEntity
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
		/// String:部门ID
		/// </summary>                       
		public String PB_DEPARTMENT_ID { get;set;}         
		/// <summary>
		/// String:编号
		/// </summary>                       
		public String PB_CODE { get;set;}         
		/// <summary>
		/// String:姓名
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// Int32:性别
		/// </summary>                       
		public Int32 PB_SEX { get;set;}         
		/// <summary>
		/// Int32:婚否
		/// </summary>                       
		public Int32 PB_MARRIED { get;set;}         
		/// <summary>
		/// String:身份证号
		/// </summary>                       
		public String PB_ID_CARD { get;set;}         
		/// <summary>
		/// String:国籍
		/// </summary>                       
		public String PB_COUNTRY_TAG { get;set;}         
		/// <summary>
		/// String:民族
		/// </summary>                       
		public String PB_NATION_TAG { get;set;}         
		/// <summary>
		/// String:职位
		/// </summary>                       
		public String PB_POSITION_TAG { get;set;}         
		/// <summary>
		/// String:职称
		/// </summary>                       
		public String PB_TITLE_TAG { get;set;}         
		/// <summary>
		/// String:政治面貌
		/// </summary>                       
		public String PB_POLITICAL_APPEARANCE_TAG { get;set;}         
		/// <summary>
		/// String:最高学历
		/// </summary>                       
		public String PB_DEGREE_TAG { get;set;}         
		/// <summary>
		/// DateTime:出生日期
		/// </summary>                       
		public DateTime PB_BIRTHDAY { get;set;}         
		/// <summary>
		/// DateTime:入职日期
		/// </summary>                       
		public DateTime PB_ENTERS_DAY { get;set;}         
		/// <summary>
		/// DateTime:离职日期
		/// </summary>                       
		public DateTime PB_LEAVES_DAY { get;set;}         
		/// <summary>
		/// String:办公电话
		/// </summary>                       
		public String PB_OFFICE_PHONE { get;set;}         
		/// <summary>
		/// String:分机号码
		/// </summary>                       
		public String PB_EXT_NUMBER { get;set;}         
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
		/// Int32:
		/// </summary>                       
		public Int32 PB_IS_ADMIN { get;set;}         
		/// <summary>
		/// Int32:已禁用
		/// </summary>                       
		public Int32 PB_DISABLED { get;set;}         
		/// <summary>
		/// Int32:排序ID
		/// </summary>                       
		public Int32 PB_ORDER_ID { get;set;}         
		/// <summary>
		/// Int32:视频用户的类型
		/// </summary>                       
		public Int32 PB_USERTYPE { get;set;}         
		/// <summary>
		/// Int32:视频用户的帐号区域
		/// </summary>                       
		public Int32 PB_SELECTNODEID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_SELECTNODENAME { get;set;}         
		/// <summary>
		/// DateTime:视频用户的有效期限
		/// </summary>                       
		public DateTime PB_EXPIREDATE { get;set;}         
		/// <summary>
		/// Decimal:
		/// </summary>                       
		public Decimal PB_DLCS { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ZHDLRQ { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_YHJB { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DYSZ { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEIID_ARR { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEIIDS { get;set;}   
    }    
}
	