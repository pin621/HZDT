using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SHANGJIJIANCHA_JILU 
    /// </summary>
    [Serializable()]
    public class PB_SHANGJIJIANCHA_JILU : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:施工单位
		/// </summary>                       
		public String PB_DEPARTMENT_ID { get;set;}         
		/// <summary>
		/// String:工程项目
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:存在问题及时整改要求
		/// </summary>                       
		public String PB_CUNZAIWENTIJISHIZHENGGAIYAOQIU { get;set;}         
		/// <summary>
		/// String:检查签字
		/// </summary>                       
		public String PB_JIANCHAQIANZI { get;set;}         
		/// <summary>
		/// DateTime:检查日期
		/// </summary>                       
		public DateTime PB_JIANCHARIQI { get;set;}         
		/// <summary>
		/// String:整改落实情况
		/// </summary>                       
		public String PB_ZHENGGAILUOSHIQINGKUANG { get;set;}         
		/// <summary>
		/// String:项目部签字
		/// </summary>                       
		public String PB_XIANGMUBUQIANZI { get;set;}         
		/// <summary>
		/// DateTime:整改日期
		/// </summary>                       
		public DateTime PB_ZHENGGAIRIQI { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// Int32:是否是新数据（为空时为旧数据）
		/// </summary>                       
		public Int32 PB_SFXSJ { get;set;}         
		/// <summary>
		/// String:职务
		/// </summary>                       
		public String PB_ZHIFU { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_JIANCHADANWEI { get;set;}         
		/// <summary>
		/// String:是否电子签名
		/// </summary>                       
		public String PB_IS_SIGNATRUE { get;set;}   
    }    
}
	