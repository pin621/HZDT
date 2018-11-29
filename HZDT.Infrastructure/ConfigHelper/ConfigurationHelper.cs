using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace HZDT.Infrastructure.ConfigHelper
{
    public class ConfigurationHelper
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        private static string fileName = "AppSettings.json";
        /// <summary>
        /// 定义一个静态变量来保存类的实例
        /// </summary>
        private static ConfigurationHelper uniqueInstance;
        /// <summary>
        /// 定义一个标识确保线程同步
        /// </summary>
        private static readonly object locker = new object();
        /// <summary>
        /// 声明一个IConfiguration
        /// </summary>
        private static IConfiguration config;

        /// <summary>
        /// 定义私有构造函数，使外界不能创建该类实例
        /// </summary>
        private ConfigurationHelper(string fileName)
        {
            config = Build(fileName);
        }

        /// <summary>
        /// 无参数初始化类
        /// </summary>
        /// <returns></returns>
        public static ConfigurationHelper GetInstance()
        {
            return Instance(fileName);
        }

        /// <summary>
        /// 有参构初始化类
        /// </summary>
        /// <param name="fileName">配置文件名称</param>
        /// <returns></returns>
        public static ConfigurationHelper GetInstance(string fileName)
        {
            return Instance(fileName);
        }

        /// <summary>
        /// 初始化类执行方法
        /// </summary>
        /// <param name="fileName">配置文件名称</param>
        /// <returns></returns>
        private static ConfigurationHelper Instance(string fileName)
        {
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new ConfigurationHelper(fileName);
                    }
                }
            }
            return uniqueInstance;
        }

        /// <summary>
        /// 创建ConfigurationBuilder对象
        /// </summary>
        /// <returns>ConfigurationBuilder对象</returns>
        private IConfiguration Build(string fileName)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .Add(new JsonConfigurationSource { Path = ConfigurationHelper.fileName, Optional = false, ReloadOnChange = true }).Build();
            return config;
        }

        /// <summary>
        /// 根据【节点名称】读取配置
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="key">节点名称</param>
        /// <returns>配置节点的值（T）</returns>
        public T GetConfigurationByKey<T>(string key) where T : class, new()
        {
            //IConfiguration config = Build();
            var appconfig = new ServiceCollection()
                .AddOptions()
                .Configure<T>(config.GetSection(key))
                .BuildServiceProvider()
                .GetService<IOptions<T>>()
                .Value;
            return appconfig;
        }

        /// <summary>
        /// 根据【节点名称】读取配置
        /// </summary>
        /// <param name="key">节点名称</param>
        /// <returns>配置节点的值（string）</returns>
        public string GetConfigurationByKey(string key)
        {
            //IConfiguration config = Build();
            return config.GetSection(key).Value;
        }

        /// <summary>
        /// 根据【节点名称】读取数据库连接字符串
        /// </summary>
        /// <param name="connectionString">数据库连接字符串名称</param>
        /// <returns>数据库连接字符串（string）</returns>
        public string GetConnectionString(string connectionString)
        {     
            //IConfiguration config = Build();       
            return config.GetConnectionString(connectionString);
        }

    }
}
