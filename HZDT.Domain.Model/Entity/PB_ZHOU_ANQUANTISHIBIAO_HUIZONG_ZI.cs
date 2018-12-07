using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ZHOU_ANQUANTISHIBIAO_HUIZONG_ZI 
    /// </summary>
    [Serializable()]
    public class PB_ZHOU_ANQUANTISHIBIAO_HUIZONG_ZI : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:工程名称
		/// </summary>                       
		public String PB_PROJECT_NAME { get;set;}         
		/// <summary>
		/// String:年份
		/// </summary>                       
		public String PB_NF { get;set;}         
		/// <summary>
		/// String:第几周
		/// </summary>                       
		public String PB_DIJIZHOU { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEI_ID { get;set;}         
		/// <summary>
		/// String:类别 ：2各级检查情况 3本周主要安全情况分析 4下周安全预警提示
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// String:详细内容
		/// </summary>                       
		public String PB_XXNR { get;set;}   
    }    
}
	