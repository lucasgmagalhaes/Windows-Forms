using System.Collections.Generic;
using System.Management;
using System.ServiceProcess;

namespace TI_Arquitetura45
{
     static class Services
    {
        private static List<ServiceDados> allServices;

        public static List<ServiceDados> AllServices { get => allServices; }

        public static void Load()
        {
            allServices = new List<ServiceDados>();
            ServiceController[] all = ServiceController.GetServices();
            foreach(ServiceController cont in all)
            {
                ManagementObject wmiService;
                wmiService = new ManagementObject("Win32_Service.Name='" + cont.ServiceName + "'"); 
                wmiService.Get();
                string desc;
                if (wmiService["Description"]== null) desc = "";
                else desc = wmiService["Description"].ToString();
                allServices.Add(new ServiceDados(cont.ServiceName, cont.DisplayName, GetStatus(cont), desc));
            }
        }
        private static string GetStatus(ServiceController sc)
        {
            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return "Running";
                case ServiceControllerStatus.Stopped:
                    return "Stopped";
                case ServiceControllerStatus.Paused:
                    return "Paused";
                case ServiceControllerStatus.StopPending:
                    return "Stopping";
                case ServiceControllerStatus.StartPending:
                    return "Starting";
                default:
                    return "Status Changing";
            }
        }
    }
}
