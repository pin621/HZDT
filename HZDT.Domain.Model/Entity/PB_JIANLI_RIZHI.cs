using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANLI_RIZHI 
    /// </summary>
    [Serializable()]
    public class PB_JIANLI_RIZHI : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// DateTime:日期
		/// </summary>                       
		public DateTime PB_RIQI { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:星期
		/// </summary>                       
		public String PB_XINGQI { get;set;}         
		/// <summary>
		/// String:天气
		/// </summary>                       
		public String PB_TIANQI { get;set;}         
		/// <summary>
		/// String:最高与最低气温
		/// </summary>                       
		public String PB_QIWEN { get;set;}         
		/// <summary>
		/// String:材料进场情况
		/// </summary>                       
		public String PB_CIALIAOJINCHANGQIANGKUANG { get;set;}         
		/// <summary>
		/// String:施工活动记载
		/// </summary>                       
		public String PB_SHIGONGHUODONGJIZAI { get;set;}         
		/// <summary>
		/// String:监理工作情况
		/// </summary>                       
		public String PB_JIANLIGONGZUOQINGKUANG { get;set;}         
		/// <summary>
		/// String:其他工程事宜
		/// </summary>                       
		public String PB_QITAGONGZUOSHIYI { get;set;}         
		/// <summary>
		/// String:填表人
		/// </summary>                       
		public String PB_TIANBIAOREN { get;set;}         
		/// <summary>
		/// String:专业/总监理工程师
		/// </summary>                       
		public String PB_JIANLIGONGCHENGSHI { get;set;}         
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
		public String PB_IS_SIGNATRUE { get;set;}   
    }    
}
	