using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_CZSGJCB_FANGHUYUAN 
    /// </summary>
    [Serializable()]
    public class PB_CZSGJCB_FANGHUYUAN : IEntity
    {    
		         
		/// <summary>
		/// String:编号
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:主表ID
		/// </summary>                       
		public String PB_ZHU_ID { get;set;}         
		/// <summary>
		/// String:防护员姓名
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:营业线施工安全培训合格证编号
		/// </summary>                       
		public String PB_HEGEZHENGHAO { get;set;}         
		/// <summary>
		/// String:发证单位或培训单位
		/// </summary>                       
		public String PB_FAZHENGDANWEI { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}   
    }    
}
	