using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_KAIGONGFUGONGJUNGONG_BAOGAODAN 
    /// </summary>
    [Serializable()]
    public class PB_KAIGONGFUGONGJUNGONG_BAOGAODAN : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:承办单位
		/// </summary>                       
		public String PB_CHENGBANDANWEIID { get;set;}         
		/// <summary>
		/// String:预算编号
		/// </summary>                       
		public String PB_YUSUANBIANHAO { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// DateTime:计划开工日期
		/// </summary>                       
		public DateTime PB_JIHUAKAIGONGRIQI { get;set;}         
		/// <summary>
		/// String:工程地点
		/// </summary>                       
		public String PB_GONGCHENGDIDIAN { get;set;}         
		/// <summary>
		/// DateTime:计划竣工日期
		/// </summary>                       
		public DateTime PB_JIHUAJUNGONGRIQI { get;set;}         
		/// <summary>
		/// String:工作内容
		/// </summary>                       
		public String PB_GONGZUONEIRONG { get;set;}         
		/// <summary>
		/// String:项目总工
		/// </summary>                       
		public String PB_XIANGMUZONGGONG { get;set;}         
		/// <summary>
		/// String:项目经理
		/// </summary>                       
		public String PB_XIANGMUJINGLI { get;set;}         
		/// <summary>
		/// String:监理单位
		/// </summary>                       
		public String PB_JIANLIDANWEIID { get;set;}         
		/// <summary>
		/// String:建设单位
		/// </summary>                       
		public String PB_JIANSHEDANWEIID { get;set;}         
		/// <summary>
		/// String:附注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:类别
		/// </summary>                       
		public String PB_LEIBIE { get;set;}         
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
	