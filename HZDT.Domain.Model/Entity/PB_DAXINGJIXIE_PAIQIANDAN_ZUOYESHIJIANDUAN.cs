using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_DAXINGJIXIE_PAIQIANDAN_ZUOYESHIJIANDUAN 
    /// </summary>
    [Serializable()]
    public class PB_DAXINGJIXIE_PAIQIANDAN_ZUOYESHIJIANDUAN : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:PB_DAXINGJIXIE_PAIQIANDAN表主键
		/// </summary>                       
		public String PB_DAXINGJIXIE_PAIQIANDAN_ID { get;set;}         
		/// <summary>
		/// DateTime:计划作业开始日期
		/// </summary>                       
		public DateTime PB_JIHUAZUOYEKAISHIRIQI { get;set;}         
		/// <summary>
		/// String:开始时间
		/// </summary>                       
		public String PB_KAISHISHIJIAN { get;set;}         
		/// <summary>
		/// DateTime:计划作业结束日期
		/// </summary>                       
		public DateTime PB_JIHUAZUOYEJIESHURIQI { get;set;}         
		/// <summary>
		/// String:结束时间
		/// </summary>                       
		public String PB_JIESHUSHIJIAN { get;set;}   
    }    
}
	