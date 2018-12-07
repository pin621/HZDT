using System;
using HZDT.Domain.Model.BaseEntity;

namespace HZDT.Domain.Model
{
    /// <summary>
    /// 数据表实体类：PB_PXJL_HMC_GWZS_ZI 
    /// </summary>
    [Serializable()]
    public class PB_PXJL_HMC_GWZS_ZI : IEntity
    {    
		         
		/// <summary>
		/// String:子表ID
		/// </summary>                       
		public String PB_ID { get;set;}         
		/// <summary>
		/// String:主表id
		/// </summary>                       
		public String PB_ZHU_ID { get;set;}         
		/// <summary>
		/// String:工程id
		/// </summary>                       
		public String PB_PROJECT_ID { get;set;}         
		/// <summary>
		/// String:培训项目
		/// </summary>                       
		public String PB_PEIXUNXIANGMU { get;set;}         
		/// <summary>
		/// String:姓名
		/// </summary>                       
		public String PB_XINGMING { get;set;}         
		/// <summary>
		/// String:岗位
		/// </summary>                       
		public String PB_GANGWEI { get;set;}         
		/// <summary>
		/// String:时间
		/// </summary>                       
		public String PB_SHIJIAN { get;set;}         
		/// <summary>
		/// String:成绩实考
		/// </summary>                       
		public String PB_CHEGNJISHIKAO { get;set;}         
		/// <summary>
		/// String:成绩修正
		/// </summary>                       
		public String PB_CHEGNJIXIUZHENG { get;set;}         
		/// <summary>
		/// String:电气成绩
		/// </summary>                       
		public String PB_DIANQICHENGJI { get;set;}         
		/// <summary>
		/// String:电气修正
		/// </summary>                       
		public String PB_DIANQIXIUZHENG { get;set;}         
		/// <summary>
		/// String:备注
		/// </summary>                       
		public String PB_BEIZHU { get;set;}         
		/// <summary>
		/// String:性别
		/// </summary>                       
		public String PB_XINGBIE { get;set;}         
		/// <summary>
		/// String:年龄
		/// </summary>                       
		public String PB_NIANLING { get;set;}         
		/// <summary>
		/// String:家庭住址
		/// </summary>                       
		public String PB_JIATINGZHUZHI { get;set;}         
		/// <summary>
		/// String:身份证号
		/// </summary>                       
		public String PB_SHENFENZHENGHAO { get;set;}         
		/// <summary>
		/// String:工作部门
		/// </summary>                       
		public String PB_GOGNZUOBUMEN { get;set;}         
		/// <summary>
		/// String:操作人ID（当前登录人ID）
		/// </summary>                       
		public String PB_LOGIN_ID { get;set;}         
		/// <summary>
		/// DateTime:操作时间
		/// </summary>                       
		public DateTime PB_OPERATION_DATE { get;set;}         
		/// <summary>
		/// String:证照名称
		/// </summary>                       
		public String PB_ZHENGZHAOMINGCHENG { get;set;}         
		/// <summary>
		/// DateTime:初培日期
		/// </summary>                       
		public DateTime PB_CHUPEIRIQI { get;set;}         
		/// <summary>
		/// String:
		/// </summary>                       
		public String PB_FUSHENQINGKUANG { get;set;}         
		/// <summary>
		/// DateTime:离开工地时间
		/// </summary>                       
		public DateTime PB_LIKAIGONGDISHIJIAN { get;set;}   
    }    
}
	