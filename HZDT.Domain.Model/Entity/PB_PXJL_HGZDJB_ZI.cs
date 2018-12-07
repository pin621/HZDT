using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PXJL_HGZDJB_ZI 
    /// </summary>
    [Serializable()]
    public class PB_PXJL_HGZDJB_ZI : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:主表id
		/// </summary>                       
		public String PB_ZHU_ID { get;set;}         
		/// <summary>
		/// String:岗位名称
		/// </summary>                       
		public String PB_GWMC { get;set;}         
		/// <summary>
		/// String:姓名
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:培训合格证编号
		/// </summary>                       
		public String PB_HGZBH { get;set;}         
		/// <summary>
		/// String:发证单位或培训单位
		/// </summary>                       
		public String PB_FZDW { get;set;}         
		/// <summary>
		/// String:发证时间/有效期
		/// </summary>                       
		public String PB_FZSJYXQ { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:人员类别（xmzyry:项目主要人员   syyz:四员一长）
		/// </summary>                       
		public String PB_RYLB { get;set;}         
		/// <summary>
		/// Int32:岗位排序
		/// </summary>                       
		public Int32 PB_GWPX { get;set;}   
    }    
}
	