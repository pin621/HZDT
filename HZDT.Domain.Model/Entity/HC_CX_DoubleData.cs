using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_CX_DoubleData 
    /// </summary>
    [Serializable()]
    public class HC_CX_DoubleData : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String SN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Stnumber { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime Cjtime { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Xvalue { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Yvalue { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String Cpoint { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String BenCiWeiYi { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String BianHuaSuLv { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String konghao { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PiCi { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PID { get;set;}         
		/// <summary>
		/// Int32:是否是报警的记录,0:不报警,1:报警
		/// </summary>                       
		public Int32 sfbj { get;set;}   
    }    
}
	