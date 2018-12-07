using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_SHIGONG_RIBAOHUIZONG 
    /// </summary>
    [Serializable()]
    public class PB_SHIGONG_RIBAOHUIZONG : IEntity
    {    
		         
		/// <summary>
		/// String:ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_SHIGONGRIBAO_OLDID { get;set;}         
		/// <summary>
		/// String:工程ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_PROJECT_NAME { get;set;}         
		/// <summary>
		/// String:线别
		/// </summary>                       
		public String PB_XIANBIE { get;set;}         
		/// <summary>
		/// String:区间
		/// </summary>                       
		public String PB_QUJIAN { get;set;}         
		/// <summary>
		/// String:里程
		/// </summary>                       
		public String PB_LICHENG { get;set;}         
		/// <summary>
		/// String:主要工作量
		/// </summary>                       
		public String PB_ZHUYAOGONGZUOLIANG { get;set;}         
		/// <summary>
		/// DateTime:工程开始时间
		/// </summary>                       
		public DateTime PB_GONGCHENGKAISHISHIJIAN { get;set;}         
		/// <summary>
		/// DateTime:工程结束时间
		/// </summary>                       
		public DateTime PB_GONGCHENGJIESHUSHIJIAN { get;set;}         
		/// <summary>
		/// DateTime:施工日期
		/// </summary>                       
		public DateTime PB_SHIGONGRIQI { get;set;}         
		/// <summary>
		/// String:施工时间
		/// </summary>                       
		public String PB_SHIGONGSHIJIAN { get;set;}         
		/// <summary>
		/// String:施工内容
		/// </summary>                       
		public String PB_SHIGONGNEIRONG { get;set;}         
		/// <summary>
		/// String:施工正、晚点情况
		/// </summary>                       
		public String PB_SHIGONGZHENGWANDIANQIANGKAUNG { get;set;}         
		/// <summary>
		/// String:安全情况
		/// </summary>                       
		public String PB_ANQUANQINGKUANG { get;set;}         
		/// <summary>
		/// String:施工单位
		/// </summary>                       
		public String PB_SHIGONGDANWEIID { get;set;}         
		/// <summary>
		/// String:现场负责人
		/// </summary>                       
		public String PB_XIANCHANGFUZEREN { get;set;}         
		/// <summary>
		/// String:监理单位
		/// </summary>                       
		public String PB_JIANLIDANWEIID { get;set;}         
		/// <summary>
		/// String:项目总监
		/// </summary>                       
		public String PB_XIANGMUZONGJIAN { get;set;}         
		/// <summary>
		/// String:现场把关人员
		/// </summary>                       
		public String PB_XIANCHANGBAGUANRENYUAN { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:工作预报
		/// </summary>                       
		public String PB_GONGZUOYUBAO { get;set;}         
		/// <summary>
		/// String:项目经理
		/// </summary>                       
		public String PB_XIANGMUJINGLI { get;set;}         
		/// <summary>
		/// String:监理
		/// </summary>                       
		public String PB_JIANLI { get;set;}         
		/// <summary>
		/// String:填表人
		/// </summary>                       
		public String PB_TIANBIAOREN { get;set;}         
		/// <summary>
		/// String:电话
		/// </summary>                       
		public String PB_DIANHUA { get;set;}         
		/// <summary>
		/// DateTime:填表时间
		/// </summary>                       
		public DateTime PB_TIANBIAOSHIJIAN { get;set;}         
		/// <summary>
		/// String:操作员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEI_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_SJJCXX { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_SHDHJDWJCXX { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_GONGZUOYUBAOWAI { get;set;}         
		/// <summary>
		/// String:施工时间是否分段：null为老数据不分段（旧数据），1为分段（新数据）
		/// </summary>                       
		public String PB_SHIGONG_SHIJIAN_SFFD { get;set;}         
		/// <summary>
		/// String:提报单位Id数组
		/// </summary>                       
		public String PB_TIBAODANWEI_ID_ARR { get;set;}   
    }    
}
	