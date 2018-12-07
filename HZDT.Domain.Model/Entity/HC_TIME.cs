using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：HC_TIME 
    /// </summary>
    [Serializable()]
    public class HC_TIME : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String 上位机自动测量时间列表 { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PID { get;set;}   
    }    
}
	