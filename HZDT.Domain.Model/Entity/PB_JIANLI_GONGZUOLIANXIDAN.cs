using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANLI_GONGZUOLIANXIDAN 
    /// </summary>
    [Serializable()]
    public class PB_JIANLI_GONGZUOLIANXIDAN : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程编号
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:工程名称
		/// </summary>                       
		public String PB_PROJECT_NAME { get;set;}         
		/// <summary>
		/// String:施工合同段
		/// </summary>                       
		public String PB_SHIGONGHETONGDUAN { get;set;}         
		/// <summary>
		/// String:编号
		/// </summary>                       
		public String PB_BIANHAO { get;set;}         
		/// <summary>
		/// String:事由
		/// </summary>                       
		public String PB_SHIYOU { get;set;}         
		/// <summary>
		/// String:内容
		/// </summary>                       
		public String PB_NEIRONG { get;set;}         
		/// <summary>
		/// String:负责人
		/// </summary>                       
		public String PB_FUZEREN { get;set;}         
		/// <summary>
		/// String:填表日期
		/// </summary>                       
		public String PB_RIQI { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATE_DATE { get;set;}         
		/// <summary>
		/// Int32:最大编号
		/// </summary>                       
		public Int32 PB_ZDBH { get;set;}         
		/// <summary>
		/// String:填表人
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_IS_SIGNATRUE { get;set;}   
    }    
}
	