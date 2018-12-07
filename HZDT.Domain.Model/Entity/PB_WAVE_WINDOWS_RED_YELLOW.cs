using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_WAVE_WINDOWS_RED_YELLOW 
    /// </summary>
    [Serializable()]
    public class PB_WAVE_WINDOWS_RED_YELLOW : IEntity
    {    
		         
		/// <summary>
		/// String:主键
		/// </summary>                       
		public String PB_WAVE_ID { get;set;}         
		/// <summary>
		/// String:单位id
		/// </summary>                       
		public String PB_DANWEI_ID { get;set;}         
		/// <summary>
		/// String:标题
		/// </summary>                       
		public String PB_TIELT { get;set;}         
		/// <summary>
		/// String:内容
		/// </summary>                       
		public String PB_CONTENT { get;set;}         
		/// <summary>
		/// String:详细信息地址
		/// </summary>                       
		public String PB_URL { get;set;}         
		/// <summary>
		/// String:操作人员用户ID
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// Int32:是否显示这条记录到飘窗列表中：1显示0不显示
		/// </summary>                       
		public Int32 PB_ISDISPLAY { get;set;}         
		/// <summary>
		/// String:R:红色警告   Y:黄色警告
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// DateTime:有效时间
		/// </summary>                       
		public DateTime PB_EFFECTIVE_TIME { get;set;}   
    }    
}
	