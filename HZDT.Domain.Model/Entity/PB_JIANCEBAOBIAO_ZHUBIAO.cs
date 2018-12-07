using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANCEBAOBIAO_ZHUBIAO 
    /// </summary>
    [Serializable()]
    public class PB_JIANCEBAOBIAO_ZHUBIAO : IEntity
    {    
		         
		/// <summary>
		/// Int32:ID
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_NAME { get;set;}         
		/// <summary>
		/// String:单位ID
		/// </summary>                       
		public String PB_DANWEIID { get;set;}         
		/// <summary>
		/// String:监测的类别，来自PB_SYSCODE_TYPE和PB_SYSCODE
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
		/// <summary>
		/// Int32:上报的次数
		/// </summary>                       
		public Int32 PB_CHISHU { get;set;}         
		/// <summary>
		/// String:报表编号
		/// </summary>                       
		public String PB_BIANHAO { get;set;}         
		/// <summary>
		/// String:天气
		/// </summary>                       
		public String PB_TIANQI { get;set;}         
		/// <summary>
		/// String:观测者
		/// </summary>                       
		public String PB_GUANCEZHE { get;set;}         
		/// <summary>
		/// String:计算者
		/// </summary>                       
		public String PB_JISUANZHE { get;set;}         
		/// <summary>
		/// String:校验者
		/// </summary>                       
		public String PB_JIAOYANZHE { get;set;}         
		/// <summary>
		/// String:测试时间
		/// </summary>                       
		public String PB_CESHISHIJIAN { get;set;}         
		/// <summary>
		/// String:工况
		/// </summary>                       
		public String PB_GONGKUANG { get;set;}         
		/// <summary>
		/// String:当日监测的简要分析及判断性结论
		/// </summary>                       
		public String PB_JIANYAOFENXIJIJIELUN { get;set;}         
		/// <summary>
		/// String:工程负责人
		/// </summary>                       
		public String PB_GONGCHENGFUZEREN { get;set;}         
		/// <summary>
		/// String:监测单位
		/// </summary>                       
		public String PB_JIANCEDANWEI { get;set;}         
		/// <summary>
		/// Int32:上报状态：默认为0，未上报；1，已上报
		/// </summary>                       
		public Int32 PB_SHANGBAOZHUANGTAI { get;set;}         
		/// <summary>
		/// String:只是测斜报表的图形化附件图片路径
		/// </summary>                       
		public String PB_URL { get;set;}   
    }    
}
	