using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_JIANCEBAOBIAO_XUNSHIJIANCHARIBAO 
    /// </summary>
    [Serializable()]
    public class PB_JIANCEBAOBIAO_XUNSHIJIANCHARIBAO : IEntity
    {    
		         
		/// <summary>
		/// Int32:自增Id，主键
		/// </summary>                       
		public Int32 PB_ID { get;set;}         
		/// <summary>
		/// Int32:
		/// </summary>                       
		public Int32 PB_ZHUBIAOID { get;set;}         
		/// <summary>
		/// String:自然条件-气温-巡视检查结果
		/// </summary>                       
		public String PB_ZRTJ_QIWEN_JG { get;set;}         
		/// <summary>
		/// String:自然条件-气温-备注
		/// </summary>                       
		public String PB_ZRTJ_QIWEN_BZ { get;set;}         
		/// <summary>
		/// String:自然条件-雨量-巡视检查结果
		/// </summary>                       
		public String PB_ZRTJ_YULIANG_JG { get;set;}         
		/// <summary>
		/// String:自然条件-雨量-备注
		/// </summary>                       
		public String PB_ZRTJ_YULIANG_BZ { get;set;}         
		/// <summary>
		/// String:自然条件-风级-巡视检查结果
		/// </summary>                       
		public String PB_ZRTJ_FENGJI_JG { get;set;}         
		/// <summary>
		/// String:自然条件-风级-备注
		/// </summary>                       
		public String PB_ZRTJ_FENGJI_BZ { get;set;}         
		/// <summary>
		/// String:自然条件-水位-巡视检查结果
		/// </summary>                       
		public String PB_ZRTJ_SHUIWEI_JG { get;set;}         
		/// <summary>
		/// String:自然条件-水位-备注
		/// </summary>                       
		public String PB_ZRTJ_SHUIWEI_BZ { get;set;}         
		/// <summary>
		/// String:支护结构-支护结构成型质量-巡视检查结果
		/// </summary>                       
		public String PB_ZHJG_ZHJGCXZL_JG { get;set;}         
		/// <summary>
		/// String:支护结构-支护结构成型质量-备注
		/// </summary>                       
		public String PB_ZHJG_ZHJGCXZL_BZ { get;set;}         
		/// <summary>
		/// String:支护结构-冠梁、支撑、围檩裂缝-巡视检查结果
		/// </summary>                       
		public String PB_ZHJG_GLZCWLLF_JG { get;set;}         
		/// <summary>
		/// String:支护结构-冠梁、支撑、围檩裂缝-备注
		/// </summary>                       
		public String PB_ZHJG_GLZCWLLF_BZ { get;set;}         
		/// <summary>
		/// String:支护结构-支撑、立柱变形-巡视检查结果
		/// </summary>                       
		public String PB_ZHJG_ZCLZBX_JG { get;set;}         
		/// <summary>
		/// String:支护结构-支撑、立柱变形备注
		/// </summary>                       
		public String PB_ZHJG_ZCLZBX_BZ { get;set;}         
		/// <summary>
		/// String:支护结构-止水帷幕开裂、渗漏-巡视检查结果
		/// </summary>                       
		public String PB_ZHJG_ZSWMKLSL_JG { get;set;}         
		/// <summary>
		/// String:支护结构-止水帷幕开裂、渗漏-备注
		/// </summary>                       
		public String PB_ZHJG_ZSWMKLSL_BZ { get;set;}         
		/// <summary>
		/// String:支护结构-墙后土体沉陷、裂缝及滑移-巡视检查结果
		/// </summary>                       
		public String PB_ZHJG_QHTTCXLFJHY_JG { get;set;}         
		/// <summary>
		/// String:支护结构-墙后土体沉陷、裂缝及滑移-备注
		/// </summary>                       
		public String PB_ZHJG_QHTTCXLFJHY_BZ { get;set;}         
		/// <summary>
		/// String:支护结构-基坑涌土、流砂、管涌-巡视检查结果
		/// </summary>                       
		public String PB_ZHJG_JKYTLSGY_JG { get;set;}         
		/// <summary>
		/// String:支护结构-基坑涌土、流砂、管涌-备注
		/// </summary>                       
		public String PB_ZHJG_JKYTLSGY_BZ { get;set;}         
		/// <summary>
		/// String:支护结构-其他-巡视检查结果
		/// </summary>                       
		public String PB_ZHJG_QITA_JG { get;set;}         
		/// <summary>
		/// String:支护结构-其他-备注
		/// </summary>                       
		public String PB_ZHJG_QITA_BZ { get;set;}         
		/// <summary>
		/// String:施工工况-土质情况-巡视检查结果
		/// </summary>                       
		public String PB_SGGK_TZQK_JG { get;set;}         
		/// <summary>
		/// String:施工工况-土质情况-备注
		/// </summary>                       
		public String PB_SGGK_TZQK_BZ { get;set;}         
		/// <summary>
		/// String:施工工况-基坑开挖分段长度及分层厚度-巡视检查结果
		/// </summary>                       
		public String PB_SGGK_JKKWFDCDJFCHD_JG { get;set;}         
		/// <summary>
		/// String:施工工况-基坑开挖分段长度及分层厚度-备注
		/// </summary>                       
		public String PB_SGGK_JKKWFDCDJFCHD_BZ { get;set;}         
		/// <summary>
		/// String:施工工况-地表水、地下水状况-巡视检查结果
		/// </summary>                       
		public String PB_SGGK_DBSDXSZK_JG { get;set;}         
		/// <summary>
		/// String:施工工况-地表水、地下水状况-备注
		/// </summary>                       
		public String PB_SGGK_DBSDXSZK_BZ { get;set;}         
		/// <summary>
		/// String:施工工况-基坑降水、回灌设施运转情况-巡视检查结果
		/// </summary>                       
		public String PB_SGGK_JKJSHGYSYZQK_JG { get;set;}         
		/// <summary>
		/// String:施工工况-基坑降水、回灌设施运转情况-备注
		/// </summary>                       
		public String PB_SGGK_JKJSHGYSYZQK_BZ { get;set;}         
		/// <summary>
		/// String:施工工况-基坑周边地面堆载情况-巡视检查结果
		/// </summary>                       
		public String PB_SGGK_JKZBDMDZQK_JG { get;set;}         
		/// <summary>
		/// String:施工工况-基坑周边地面堆载情况-备注
		/// </summary>                       
		public String PB_SGGK_JKZBDMDZQK_BZ { get;set;}         
		/// <summary>
		/// String:施工工况-其他-巡视检查结果
		/// </summary>                       
		public String PB_SGGK_QITA_JG { get;set;}         
		/// <summary>
		/// String:施工工况-其他-备注
		/// </summary>                       
		public String PB_SGGK_QITA_BZ { get;set;}         
		/// <summary>
		/// String:周边环境-管道破损、泄漏情况-巡视检查结果
		/// </summary>                       
		public String PB_ZBHJ_GDPSXLQK_JG { get;set;}         
		/// <summary>
		/// String:周边环境-管道破损、泄漏情况-备注
		/// </summary>                       
		public String PB_ZBHJ_GDPSXLQK_BZ { get;set;}         
		/// <summary>
		/// String:周过环境-周边建筑裂缝-巡视检查结果
		/// </summary>                       
		public String PB_ZBHJ_ZBJZLF_JG { get;set;}         
		/// <summary>
		/// String:周过环境-周边建筑裂缝-备注
		/// </summary>                       
		public String PB_ZBHJ_ZBJZLF_BZ { get;set;}         
		/// <summary>
		/// String:周过环境-周边道路（地面）裂缝、沉陷-巡视检查结果
		/// </summary>                       
		public String PB_ZBHJ_ZBDLDMLFCX_JG { get;set;}         
		/// <summary>
		/// String:周过环境-周边道路（地面）裂缝、沉陷-备注
		/// </summary>                       
		public String PB_ZBHJ_ZBDLDMLFCX_BZ { get;set;}         
		/// <summary>
		/// String:周过环境-邻近施工情况-巡视检查结果
		/// </summary>                       
		public String PB_ZBHJ_LJSGQK_JG { get;set;}         
		/// <summary>
		/// String:周过环境-邻近施工情况-备注
		/// </summary>                       
		public String PB_ZBHJ_LJSGQK_BZ { get;set;}         
		/// <summary>
		/// String:周过环境-其他-巡视检查结果
		/// </summary>                       
		public String PB_ZBHJ_QITA_JG { get;set;}         
		/// <summary>
		/// String:周过环境-其他-备注
		/// </summary>                       
		public String PB_ZBHJ_QITA_BZ { get;set;}         
		/// <summary>
		/// String:监测设施-基准点、测点完好状况-巡视检查结果
		/// </summary>                       
		public String PB_JCSS_JZDCDWHZK_JG { get;set;}         
		/// <summary>
		/// String:监测设施-基准点、测点完好状况-备注
		/// </summary>                       
		public String PB_JCSS_JZDCDWHZK_BZ { get;set;}         
		/// <summary>
		/// String:监测设施-监测元件完好情况-巡视检查结果
		/// </summary>                       
		public String PB_JCSS_JCYJWHQK_JG { get;set;}         
		/// <summary>
		/// String:监测设施-监测元件完好情况-备注
		/// </summary>                       
		public String PB_JCSS_JCYJWHQK_BZ { get;set;}         
		/// <summary>
		/// String:监测设施-观测工作条件-巡视检查结果
		/// </summary>                       
		public String PB_JCSS_GCGZTJ_JG { get;set;}         
		/// <summary>
		/// String:监测设施-观测工作条件-备注
		/// </summary>                       
		public String PB_JCSS_GCGZTJ_BZ { get;set;}   
    }    
}
	