using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SIGNATURE 
    /// </summary>
    [Serializable()]
    public class PB_SIGNATURE : IEntity
    {    
		         
		/// <summary>
		/// String:唯一标识符号
		/// </summary>                       
		public String PB_GUIID { get;set;}         
		/// <summary>
		/// String:表记录ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:类别【对应模块名】
		/// </summary>                       
		public String PB_TYPE { get;set;}   
    }    
}
	