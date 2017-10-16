using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using TI_Arquitetura45;
using System.Drawing;

/// <summary>
/// Main do programa. Parte principal com todos os componentes
/// </summary>
namespace TI_Arquitetura
{

    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        #region VARIABLES
        private static PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public PerformanceCounter myCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
        private static PerformanceCounter ramCounter;
        private static List<PerformanceCounter> cpuCounters = new List<PerformanceCounter>();
        private ulong memorybyts;
        private ulong size = 0;
        private ulong freespace = 0;
        private ManagementObjectSearcher Catcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"); // Pesquisa no Win32 sobre todas as informações nesse quesito sobre o processador
        private ManagementObjectSearcher CatcherHD = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk "); // Pesquisa no Win32 sobre todas as informações nesse quesito sobre o Disco Rígido
        private ManagementObjectSearcher Cache = new ManagementObjectSearcher("SELECT * FROM Win32_CacheMemory");
        private ListViewItem item;
        #endregion

        #region SYSTEM METHODS AND IMPLEMENTATION

        private void SendMessage(IntPtr handle, int v, IntPtr state, IntPtr zero)
        {
            throw new NotImplementedException();
        }

        private void ShowGeneralWin32(string type, ManagementObject obj, string text) // Insere um item no ListView possuindo o ManagementObject de algum obj como parâmetro
        {
            item = new ListViewItem();
            item.SubItems.Add(obj[type].ToString());
            item.Text = text;
            listgeneral.Items.Add(item);
        }
        private void ShowGeneralWin32(string type, ManagementObject obj, string text, ListViewGroup gr) // Insere um item no ListView possuindo o ManagementObject de algum obj como parâmetro
        {
            item = new ListViewItem();
            item.SubItems.Add(obj[type].ToString());
            item.Text = text;
            item.Group = gr;
            listgeneral.Items.Add(item);
        }
        private void ShowCacheMemory(string type, ManagementObject obj, string text) // Insere um item no ListView possuindo o ManagementObject de algum obj como parâmetro
        {
            ListViewItem item = new ListViewItem();
            try
            {
                item.SubItems.Add(obj[type].ToString());
                item.Text = text;
                listcache.Items.Add(item);
            }
            catch
            {
                item.SubItems.Add("0");
                item.Text = text;
                listcache.Items.Add(item);
            }
        }

        private void ShowGeneralWin32(string Name, string Value) // Insere um item no ListView
        {
            item = new ListViewItem();
            item.SubItems.Add(Name);
            item.Text = Value;
            listgeneral.Items.Add(item);
        }
        private void ShowGeneralWin32(string Name, string Value, ListViewGroup grp) // Insere um item no ListView
        {
            item = new ListViewItem();
            item.SubItems.Add(Name);
            item.Text = Value;
            item.Group = grp;
            listgeneral.Items.Add(item);
        }
        private void ShowGeneralVisualBasic() // Método usado para coletar o total de memmória RAM presente no computador
        {
            memorybyts = new ComputerInfo().TotalPhysicalMemory;
            int full = Convert.ToInt32(BytesToDouble(memorybyts));
            string MemoryUse = string.Format("Memória: {0:n1} GB (utilizável: {1:n1})", full, ToFileSize(memorybyts));
            ListViewItem items = new ListViewItem();
            items.SubItems.Add(MemoryUse);
            items.Text = "Memória RAM instalada";
            items.Group = listgeneral.Groups[0];
            listgeneral.Items.Add(items);
        }
        #endregion
        private int CalcPercentage(int val100, int valX)
        {
            return (val100 * valX) / 100;
        }
        private long CalcPercentage(long val100, long valX)
        {
            return (val100 * valX) / 100;
        }
        private int CalcPercentage(double val100, double valX)
        {
            return Convert.ToInt32((val100 * valX) / 100);
        }
        private int CalcPercentage(long val100, int valX)
        {
            return Convert.ToInt32(val100 * valX / 100);
        }
        private void ForeachSpecificAdd(Process[] block)
        {
            foreach (Process proc in block)
            {
                PerformanceCounter counter = new PerformanceCounter("Process", "% Processor Time", proc.ProcessName);
                PerformanceCounter counterRAM = new PerformanceCounter("Process", "Working Set - Private", proc.ProcessName);
                int cpuUseage = (int)counter.NextValue();
                item = new ListViewItem();
                item.Text = proc.ProcessName;
                item.SubItems.Add(cpuUseage.ToString());
                item.SubItems.Add((((double)counterRAM.NextValue() / 1024) / 1000) + " MB");
                item.SubItems.Add((((double)proc.PagedMemorySize64 / 1024) / 1000) + " MB");
                listspecific.Items.Add(item);
            }
        }
        #region LOCAL CONVERSOR VARIABLE
        public static string ToFileSize(ulong source)
        {
            const int byteConversion = 1024;
            double bytes = Convert.ToDouble(source);

            if (bytes >= Math.Pow(byteConversion, 3)) //GB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 3), 2), " GB");
            }
            else if (bytes >= Math.Pow(byteConversion, 2)) //MB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 2), 2), " MB");
            }
            else if (bytes >= byteConversion) //KB Range
            {
                return string.Concat(Math.Round(bytes / byteConversion, 2), " KB");
            }
            else //Bytes
            {
                return string.Concat(bytes, " Bytes");
            }
        } // Converte byte para double e acrescenta o tamanho string correspondente(KB, MB, GB...) e retorna a string
          /// <summary>
          /// Retrieving Motherboard Manufacturer.
          /// </summary>
          /// <returns></returns>
        public static string GetBoardMaker()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();
                }
                catch { }
            }
            return "Board Maker: Unknown";
        }
        /// <summary>
        /// Retrieving Motherboard Product Id.
        /// </summary>
        /// <returns></returns>
        public static string GetBoardProductId()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Product").ToString();
                }
                catch { }
            }
            return "Product: Unknown";
        }
        public static double BytesToDouble(ulong source)
        {
            const int byteConversion = 1024;
            double bytes = Convert.ToDouble(source);

            if (bytes >= Math.Pow(byteConversion, 3)) //GB Range
            {
                return Math.Round(bytes / Math.Pow(byteConversion, 3), 2);
            }
            else if (bytes >= Math.Pow(byteConversion, 2)) //MB Range
            {
                return Math.Round(bytes / Math.Pow(byteConversion, 2), 2);
            }
            else if (bytes >= byteConversion) //KB Range
            {
                return (Math.Round(bytes / byteConversion, 2));
            }
            else //Bytes
            {
                return bytes;
            }
        } //Converte byte para o valor correspondente(KB, MB, GB...) e torna tal valor em double.
        #endregion
        private void frmmain_Load(object sender, EventArgs e)
        {
            Services.Load();

            #region PERFORMANCE DATA

            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            int procCount = System.Environment.ProcessorCount;
            for (int i = 0; i < procCount; i++)
            {
                System.Diagnostics.PerformanceCounter pc = new System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", i.ToString());
                cpuCounters.Add(pc);
            }
            timer_performance.Enabled = true;
            #endregion

            #region General Information
            //Tab 1 - General Informations, informações gerais sobre o Windows vinculado ao Hardware
            foreach (ManagementObject seacher in Catcher.Get())
            {
                foreach (ManagementObject seacher2 in CatcherHD.Get())
                {
                    foreach (PropertyData data in seacher2.Properties)
                    {
                        if (seacher2["DriveType"].ToString() == "3")
                        {
                            if (data.Name == "Size") size += Convert.ToUInt64(data.Value);
                            if (data.Name == "FreeSpace") freespace += Convert.ToUInt64(data.Value);
                        }
                    }
                }
                listgeneral.Groups.Add("Sitema", "Sitema");
                ShowGeneralWin32(OSVersionInfo.GetOSVersionInfo().FullName, "Windows Edition", listgeneral.Groups[0]);
                ShowGeneralWin32("Name", seacher, "Processador: ", listgeneral.Groups[0]);

                ShowGeneralVisualBasic();
                ShowGeneralWin32("SystemName", seacher, "Nome do computador", listgeneral.Groups[0]);

                listgeneral.Groups.Add("Sitema", "Placa mãe");

                ShowGeneralWin32(GetBoardMaker(), "Fornecedor", listgeneral.Groups[1]);
                ShowGeneralWin32(GetBoardProductId(), "Modelo", listgeneral.Groups[1]);
                listgeneral.Groups.Add("Sitema", "Hard Disk");
                ShowGeneralWin32(ToFileSize(freespace), "HD Free Space", listgeneral.Groups[2]);
                ShowGeneralWin32(ToFileSize(size), "HD Total Space", listgeneral.Groups[2]);
                progressBar1.Maximum = 100;
                int percent = Convert.ToInt32(100 - ((freespace * 100) / size));
                progressBar1.Value = percent;
                label11.Text = percent + "%";
                #endregion

                #region Processor
                //Tab 3 - Processor Informations
                foreach (PropertyData data in seacher.Properties)
                {
                    if (data.Value != null && data.ToString() != "")
                    {
                        item = new ListViewItem();
                        item.Text = data.Name;
                        item.SubItems.Add(data.Value.ToString());
                        listProcessor.Items.Add(item);
                    }
                }
            }
            #endregion

            #region Cache
            //Tab 3 - Cache
            foreach (ManagementObject seacher3 in Cache.Get())
            {
                ShowCacheMemory("Purpose", seacher3, "Purpose");
                ShowCacheMemory("CacheSpeed", seacher3, "CacheSpeed");
                ShowCacheMemory("BlockSize", seacher3, "BlockSize");
                ShowCacheMemory("DeviceID", seacher3, "DeviceID");
                ShowCacheMemory("InstalledSize", seacher3, "InstalledSize");
                ShowCacheMemory("MaxCacheSize", seacher3, "MaxCacheSize");
                ShowCacheMemory("NumberOfBlocks", seacher3, "NumberOfBlocks");
            }

            #endregion

            #region HD
            //Tab 4 - Disk Informations
            foreach (ManagementObject seacher2 in CatcherHD.Get())
            {
                foreach (PropertyData data in seacher2.Properties)
                {
                    if (data.Value != null && data.ToString() != "")
                    {
                        ListViewItem i = new ListViewItem();
                        i.Text = data.Name;
                        try
                        {
                            if (data.Name != "StartingOffset" && data.Name != "NumberOfBlocks") // Informações referentes ao espaço são coletadas e ajustadas 
                            {
                                ulong value = Convert.ToUInt64(data.Value);
                                if (value >= 100000) i.SubItems.Add(ToFileSize(value));
                                else i.SubItems.Add(data.Value.ToString());
                            }
                            else i.SubItems.Add(data.Value.ToString());
                        }
                        catch
                        {
                            i.SubItems.Add(data.Value.ToString());
                        }

                        listHD.Items.Add(i);
                    }
                }
            }
            #endregion

            #region Processes

            listProcessosRunning.Columns.Add("name", "Nome", 120);
            listProcessosRunning.Columns.Add("ID", "ID", 80);
            listProcessosRunning.Columns.Add("Threads", "Threads", 100);
            listProcessosRunning.Columns.Add("R", "RAM", 90);
            listProcessosRunning.Columns.Add("R", "CPU", 80);
            Process[] proc = Process.GetProcesses();
            foreach (Process pro in proc)
            {
                PerformanceCounter counter = new PerformanceCounter("Process", "% Processor Time", pro.ProcessName);
                PerformanceCounter counterRAM = new PerformanceCounter("Process", "Working Set - Private", pro.ProcessName);
                counter.NextValue();
                int cpuUseage = (int)counter.NextValue();
                ListViewItem it = new ListViewItem();
                it.Text = pro.ProcessName;
                it.SubItems.Add(pro.Id.ToString());
                it.SubItems.Add(pro.Threads.Count.ToString());
                item.Text = pro.ProcessName;
                it.SubItems.Add((((double)counterRAM.NextValue() / 1024) / 1000) + " MB");
                it.SubItems.Add(cpuUseage + "%");
                listProcessosRunning.Items.Add(it);
            }
            #endregion

            #region SpecificPrograms

            Process[] pro_gt = Process.GetProcessesByName("Taskmgr");

            #region OFFICE
            Process[] pro_moW = Process.GetProcessesByName("WINWORD");
            ForeachSpecificAdd(pro_moW);
            Process[] pro_moE = Process.GetProcessesByName("EXCEL");
            ForeachSpecificAdd(pro_moE);
            Process[] pro_moA = Process.GetProcessesByName("MSACCESS");
            ForeachSpecificAdd(pro_moA);
            Process[] pro_moOne = Process.GetProcessesByName("ONENOTE");
            ForeachSpecificAdd(pro_moOne);
            Process[] pro_moOUT = Process.GetProcessesByName("OUTLOOK");
            ForeachSpecificAdd(pro_moOUT);
            Process[] pro_moOneTEM = Process.GetProcessesByName("ONENOTEM");
            ForeachSpecificAdd(pro_moOneTEM);
            Process[] pro_moPOWER = Process.GetProcessesByName("POWERPNT");
            ForeachSpecificAdd(pro_moPOWER);
            Process[] pro_moPUB = Process.GetProcessesByName("MSPUB");
            ForeachSpecificAdd(pro_moPUB);
            #endregion

            Process[] pro_libof = Process.GetProcessesByName("LibreOffice");
            ForeachSpecificAdd(pro_libof);
            Process[] pro_vs = Process.GetProcessesByName("devenv");
            ForeachSpecificAdd(pro_vs);
            Process[] pro_IE = Process.GetProcessesByName("iexplore");
            ForeachSpecificAdd(pro_IE);
            Process[] pr_gooc = Process.GetProcessesByName("chrome");
            ForeachSpecificAdd(pr_gooc);

            #region EDGE
            Process[] proc_ME = Process.GetProcessesByName("MicrosoftEdge");
            ForeachSpecificAdd(proc_ME);
            Process[] proc_MECP = Process.GetProcessesByName("MicrosoftEdgeCP");
            ForeachSpecificAdd(proc_MECP);
            #endregion

            Process[] pro_fire = Process.GetProcessesByName("Firefox");
            ForeachSpecificAdd(pro_fire);
            Process[] pro_we = Process.GetProcessesByName("explorer");
            ForeachSpecificAdd(pro_we);
            #endregion

            #region Services
            listservices.Columns.Add("Nome", 150);
            listservices.Columns.Add("Nome de exibição", 150);
            listservices.Columns.Add("Status", 90);
            listservices.Columns.Add("Descrição", 90);
            foreach (ServiceDados service in Services.AllServices)
            {
                item = new ListViewItem();
                item.Text = service.Nome;
                item.SubItems.Add(service.Display_nome);
                item.SubItems.Add(service.Status);
                item.SubItems.Add(service.Descrição);
                listservices.Items.Add(item);
            }
            #endregion
        }

        private void timer_performance_Tick(object sender, EventArgs e)
        {
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            decimal percentOccupied = 100 - percentFree;
            int hd = Convert.ToInt32(myCounter.NextValue());
            long ram = Convert.ToInt64(percentOccupied);
            lblcpu.Text = Convert.ToInt32(cpuCounter.NextValue()) + "%";
            lblram.Text = Convert.ToInt64(percentOccupied) + "%";
            lbldisk.Text = hd + "%";
        }
    }
}
