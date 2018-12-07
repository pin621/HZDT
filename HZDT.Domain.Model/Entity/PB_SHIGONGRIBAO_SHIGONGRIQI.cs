using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SHIGONGRIBAO_SHIGONGRIQI 
    /// </summary>
    [Serializable()]
    public class PB_SHIGONGRIBAO_SHIGONGRIQI : IEntity
    {    
		         
		/// <summary>
		/// String:自动增长Id
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:对应施工日报Id
		/// </summary>                       
		public String PB_SHIGONG_RIBAO_ID { get;set;}         
		/// <summary>
		/// DateTime:施工开始时间
		/// </summary>                       
		public DateTime PB_KAISHI_SHIJIAN { get;set;}         
		/// <summary>
		/// DateTime:施工结束时间
		/// </summary>                       
		public DateTime PB_JIESHU_SHIJIAN { get;set;}   
    }    
}
	