using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SEQUENCE 
    /// </summary>
    [Serializable()]
    public class PB_SEQUENCE : IEntity
    {    
		         
		/// <summary>
		/// String:表名
		/// </summary>                       
		public String PB_TABLE_NAME { get;set;}         
		/// <summary>
		/// Int32:下一个序列值
		/// </summary>                       
		public Int32 PB_NEXT_ID { get;set;}   
    }    
}
	