using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PRODUCTION 
    /// </summary>
    [Serializable()]
    public class PB_PRODUCTION : IEntity
    {    
		         
		/// <summary>
		/// String:考核序号
		/// </summary>                       
		public String PB_PRODUCTION_ID { get;set;}         
		/// <summary>
		/// String:姓名
		/// </summary>                       
		public String PB_PRODUCTION_NAME { get;set;}         
		/// <summary>
		/// String:职务
		/// </summary>                       
		public String PB_SYSCODE_TYPE_ID { get;set;}         
		/// <summary>
		/// String:基础管理
		/// </summary>                       
		public String PB_PRODUCTION_JCGL { get;set;}         
		/// <summary>
		/// String:信息处理
		/// </summary>                       
		public String PB_PRODUCTION_XXCL { get;set;}         
		/// <summary>
		/// String:过程控制
		/// </summary>                       
		public String PB_PRODUCTION_GCKZ { get;set;}         
		/// <summary>
		/// String:量化任务
		/// </summary>                       
		public String PB_PRODUCTION_LHRW { get;set;}         
		/// <summary>
		/// String:管理绩效考核小计
		/// </summary>                       
		public String PB_PRODUCTION_GLJXKH { get;set;}         
		/// <summary>
		/// String:考核得分
		/// </summary>                       
		public String PB_PRODUCTION_KHDF { get;set;}         
		/// <summary>
		/// String:评定等级
		/// </summary>                       
		public String PB_PRODUCTION_PDDJ { get;set;}         
		/// <summary>
		/// DateTime:录入日期
		/// </summary>                       
		public DateTime PB_PRODUCTION_DATE { get;set;}   
    }    
}
	