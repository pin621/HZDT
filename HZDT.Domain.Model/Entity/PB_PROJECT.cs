using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PROJECT 
    /// </summary>
    [Serializable()]
    public class PB_PROJECT : IEntity
    {    
		         
		/// <summary>
		/// String:工程项目ID
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DANWEI_ID { get;set;}         
		/// <summary>
		/// String:工程名称
		/// </summary>                       
		public String PB_NAME { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_ABBREVIATION { get;set;}         
		/// <summary>
		/// String:施工地点
		/// </summary>                       
		public String PB_ADDRESS { get;set;}         
		/// <summary>
		/// String:铁路线路
		/// </summary>                       
		public String PB_RAILWAYLINE { get;set;}         
		/// <summary>
		/// String:工程里程
		/// </summary>                       
		public String PB_MILEAGE { get;set;}         
		/// <summary>
		/// String:工程概况
		/// </summary>                       
		public String PB_OVERVIEW { get;set;}         
		/// <summary>
		/// String:建设规模
		/// </summary>                       
		public String PB_SCALE { get;set;}         
		/// <summary>
		/// String:施工工期
		/// </summary>                       
		public String PB_PERIOD { get;set;}         
		/// <summary>
		/// String:建设要求
		/// </summary>                       
		public String PB_REQUIREMENTS { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_COMPLETELOGO { get;set;}         
		/// <summary>
		/// String:录入人员
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:录入时间
		/// </summary>                       
		public DateTime PB_CREATTIME { get;set;}         
		/// <summary>
		/// String:视频安装情况
		/// </summary>                       
		public String PB_SHIPIN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_BEIJINGTUPIAN { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_SHIFOUSHANGBAO { get;set;}         
		/// <summary>
		/// DateTime:锁定日期
		/// </summary>                       
		public DateTime PB_SDRQ { get;set;}         
		/// <summary>
		/// String:经纬度
		/// </summary>                       
		public String PB_JWD { get;set;}         
		/// <summary>
		/// String:地图备注
		/// </summary>                       
		public String PB_DTBZ { get;set;}         
		/// <summary>
		/// Int32:锁定天数
		/// </summary>                       
		public Int32 PB_SDTS { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_DDDX { get;set;}         
		/// <summary>
		/// String:1代表有形变监测的，0或NULL代表没有形变检测的。
		/// </summary>                       
		public String PB_SFJCXB { get;set;}         
		/// <summary>
		/// String:主管工程师
		/// </summary>                       
		public String PB_ZGGCS { get;set;}         
		/// <summary>
		/// Int32:监测项目是否启用，1启用，0停用
		/// </summary>                       
		public Int32 PB_JCSFQY { get;set;}         
		/// <summary>
		/// String:是否周安全重点提示表
		/// </summary>                       
		public String PB_SFZAQZDFXTSB { get;set;}   
    }    
}
	