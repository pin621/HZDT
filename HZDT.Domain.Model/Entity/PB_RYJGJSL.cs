using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_RYJGJSL 
    /// </summary>
    [Serializable()]
    public class PB_RYJGJSL : IEntity
    {    
		         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DOOR { get;set;}         
		/// <summary>
		/// Decimal:施工人员数量
		/// </summary>                       
		public Decimal sgrysl { get;set;}         
		/// <summary>
		/// Decimal:非施工人员数量
		/// </summary>                       
		public Decimal fsgrysl { get;set;}         
		/// <summary>
		/// Decimal:备用数量
		/// </summary>                       
		public Decimal gdsl { get;set;}         
		/// <summary>
		/// Decimal:机工具备用数量
		/// </summary>                       
		public Decimal sdsl { get;set;}   
    }    
}
	