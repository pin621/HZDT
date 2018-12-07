using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：sysreplservers 
    /// </summary>
    [Serializable()]
    public class sysreplservers : IEntity
    {    
		         
		/// <summary>
		/// String:
		/// </summary>                       
		public String srvname { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 srvid { get;set;}   
    }    
}
	