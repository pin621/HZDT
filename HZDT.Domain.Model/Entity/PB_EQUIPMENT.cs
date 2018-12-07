using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_EQUIPMENT 
    /// </summary>
    [Serializable()]
    public class PB_EQUIPMENT : IEntity
    {    
		         
		/// <summary>
		/// String:设备机工具卡号
		/// </summary>                       
		public String PB_CODE { get;set;}         
		/// <summary>
		/// String:单位ID
		/// </summary>                       
		public String PB_UNITS_ID { get;set;}         
		/// <summary>
		/// String:设备机工具名称
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:设备机工具照片
		/// </summary>                       
		public String PB_PHOTO { get;set;}         
		/// <summary>
		/// String:规格
		/// </summary>                       
		public String PB_STANDARD { get;set;}         
		/// <summary>
		/// String:生产厂家
		/// </summary>                       
		public String PB_FACTORY { get;set;}         
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
		/// String:备注
		/// </summary>                       
		public String PB_REMARK { get;set;}         
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
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}   
    }    
}
	