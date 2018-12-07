using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：SysConfig 
    /// </summary>
    [Serializable()]
    public class SysConfig : IEntity
    {    
		         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 SendVer { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 ClientVer { get;set;}   
    }    
}
	