using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PROJECT_JIANCEDIAN 
    /// </summary>
    [Serializable()]
    public class PB_PROJECT_JIANCEDIAN : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:监测点代码
		/// </summary>                       
		public String PB_JIANCEDIANDAIMA { get;set;}         
		/// <summary>
		/// String:工程项目监测点名称
		/// </summary>                       
		public String PB_JIANCEDIANMINGCHENG { get;set;}         
		/// <summary>
		/// String:描述
		/// </summary>                       
		public String PB_DESCRIPTION { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:监测点类型(Cexie:测斜 Shuiwei:水位 Xingbian:形变 )
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// String:孔号
		/// </summary>                       
		public String PB_KONGHAO { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_STNUMBER { get;set;}         
		/// <summary>
		/// Int32:监测点是否启用（0：停用1：启用）
		/// </summary>                       
		public Int32 PB_SFQY { get;set;}   
    }    
}
	