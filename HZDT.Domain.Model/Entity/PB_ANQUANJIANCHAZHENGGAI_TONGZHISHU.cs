using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_ANQUANJIANCHAZHENGGAI_TONGZHISHU 
    /// </summary>
    [Serializable()]
    public class PB_ANQUANJIANCHAZHENGGAI_TONGZHISHU : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:工程项目
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:编号
		/// </summary>                       
		public String PB_BIANHAO { get;set;}         
		/// <summary>
		/// String:年
		/// </summary>                       
		public String PB_NIAN { get;set;}         
		/// <summary>
		/// String:号
		/// </summary>                       
		public String PB_HAO { get;set;}         
		/// <summary>
		/// String:收公司单位
		/// </summary>                       
		public String PB_SHOUDEPARTMENTID { get;set;}         
		/// <summary>
		/// String:月
		/// </summary>                       
		public String PB_YUE { get;set;}         
		/// <summary>
		/// String:日
		/// </summary>                       
		public String PB_RI { get;set;}         
		/// <summary>
		/// String:报单位
		/// </summary>                       
		public String PB_BAODEPARTMENTID { get;set;}         
		/// <summary>
		/// String:发现问题
		/// </summary>                       
		public String PB_FAXIANWENTI { get;set;}         
		/// <summary>
		/// String:改进意见
		/// </summary>                       
		public String PB_GAIJINYIJIAN { get;set;}         
		/// <summary>
		/// String:填发单位
		/// </summary>                       
		public String PB_TIANFADANWEI { get;set;}         
		/// <summary>
		/// String:填发人
		/// </summary>                       
		public String PB_TIANFAREN { get;set;}         
		/// <summary>
		/// DateTime:填发日期
		/// </summary>                       
		public DateTime PB_TIANFARIQI { get;set;}         
		/// <summary>
		/// String:整改情况
		/// </summary>                       
		public String PB_ZHENGGAIQINGKUANG { get;set;}         
		/// <summary>
		/// String:单位负责人
		/// </summary>                       
		public String PB_DANWEIFUZEREN { get;set;}         
		/// <summary>
		/// DateTime:整改日期
		/// </summary>                       
		public DateTime PB_ZHENGGAIRIQI { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ZDBH { get;set;}         
		/// <summary>
		/// String:是否电子签名
		/// </summary>                       
		public String PB_IS_SIGNATRUE { get;set;}   
    }    
}
	