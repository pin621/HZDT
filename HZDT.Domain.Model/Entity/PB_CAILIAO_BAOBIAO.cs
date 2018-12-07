using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_CAILIAO_BAOBIAO 
    /// </summary>
    [Serializable()]
    public class PB_CAILIAO_BAOBIAO : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// DateTime:
		/// </summary>                       
		public DateTime PB_RIQI { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:材料名称
		/// </summary>                       
		public String PB_CAILIAONAME { get;set;}         
		/// <summary>
		/// String:材料规格
		/// </summary>                       
		public String PB_CAILIAOGUIGE { get;set;}         
		/// <summary>
		/// String:生产厂家（产地）
		/// </summary>                       
		public String PB_SHENGCHANCHANGJIA { get;set;}         
		/// <summary>
		/// String:单位
		/// </summary>                       
		public String PB_DANWEI { get;set;}         
		/// <summary>
		/// String:数量
		/// </summary>                       
		public String PB_SHULIANG { get;set;}         
		/// <summary>
		/// String:单价
		/// </summary>                       
		public String PB_DANJIA { get;set;}         
		/// <summary>
		/// String:合价
		/// </summary>                       
		public String PB_HEJIA { get;set;}         
		/// <summary>
		/// String:送检标记
		/// </summary>                       
		public String PB_SONGJIANBIAOJI { get;set;}         
		/// <summary>
		/// String:合格标记
		/// </summary>                       
		public String PB_HEGEBIAOJI { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:报表类别
		/// </summary>                       
		public String PB_BAOBIAOLEIBIE { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}   
    }    
}
	