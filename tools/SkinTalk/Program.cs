using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SkinTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(SkinService));
                host.Opened += OnServiceOpened;
                host.Closed += OnServiceClosed;
                host.Faulted += OnServiceFaulted;
                host.Open();

                Console.ReadKey();
            }
            catch (Exception ex)
            { 
            }
        }


        #region WCF 服务事件

        static void OnServiceOpened(object sender, EventArgs e)
        {
            ServiceHost host = sender as ServiceHost;
            if (host == null)
            {
                return;
            }

            if (host.SingletonInstance != null)
            {
                Console.WriteLine("初始化WCF服务:" + host.SingletonInstance.GetType().Name + "成功");
            }
            else
            {
                Console.WriteLine("初始化WCF服务:" + host.Description.ServiceType.Name + "成功");
            }
        }

        static void OnServiceFaulted(object sender, EventArgs e)
        {
            ServiceHost host = sender as ServiceHost;
            if (host == null)
            {
                return;
            }

            if (host.SingletonInstance != null)
            {
                Console.WriteLine("WCF服务:" + host.SingletonInstance.GetType().Name + "出错");
            }
            else
            {
                Console.WriteLine("WCF服务:" + host.Description.ServiceType.Name + "出错");
            }
        }

        static void OnServiceClosed(object sender, EventArgs e)
        {
            ServiceHost host = sender as ServiceHost;
            if (host == null)
            {
                return;
            }

            if (host.SingletonInstance != null)
            {
                Console.WriteLine("WCF服务:" + host.SingletonInstance.GetType().Name + "已关闭");
            }
            else
            {
                Console.WriteLine("WCF服务:" + host.Description.ServiceType.Name + "已关闭");
            }
        }

        #endregion
    }
}
