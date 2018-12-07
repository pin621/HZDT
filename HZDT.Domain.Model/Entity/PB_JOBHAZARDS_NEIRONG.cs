using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JOBHAZARDS_NEIRONG 
    /// </summary>
    [Serializable()]
    public class PB_JOBHAZARDS_NEIRONG : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// DateTime:当日作业危险源提示ID
		/// </summary>                       
		public DateTime PB_RIQI { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:内容
		/// </summary>                       
		public String PB_NEIRONG { get;set;}         
		/// <summary>
		/// String:危险源分析
		/// </summary>                       
		public String PB_WEIXIANGYUANFENXI { get;set;}         
		/// <summary>
		/// String:应对措施
		/// </summary>                       
		public String PB_YINGDUICUOSHI { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_FUZEREN { get;set;}   
    }    
}
	