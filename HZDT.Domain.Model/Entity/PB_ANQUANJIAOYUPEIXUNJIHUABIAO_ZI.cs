using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ANQUANJIAOYUPEIXUNJIHUABIAO_ZI 
    /// </summary>
    [Serializable()]
    public class PB_ANQUANJIAOYUPEIXUNJIHUABIAO_ZI : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:主表ID
		/// </summary>                       
		public String PB_ZHU_ID { get;set;}         
		/// <summary>
		/// String:培训内容
		/// </summary>                       
		public String PB_PEIXUNNEIRONG { get;set;}         
		/// <summary>
		/// String:培训对象
		/// </summary>                       
		public String PB_PEIXUNDUIXIANG { get;set;}         
		/// <summary>
		/// String:培训方式
		/// </summary>                       
		public String PB_PEIXUNFANGSHI { get;set;}         
		/// <summary>
		/// DateTime:培训时间
		/// </summary>                       
		public DateTime PB_PEIXUNSHIJIAN { get;set;}         
		/// <summary>
		/// Int32:计划学时
		/// </summary>                       
		public Int32 PB_JIHUAXUESHI { get;set;}         
		/// <summary>
		/// String:主办部门
		/// </summary>                       
		public String PB_ZHUBANBUMEN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_BEIZHU { get;set;}   
    }    
}
	