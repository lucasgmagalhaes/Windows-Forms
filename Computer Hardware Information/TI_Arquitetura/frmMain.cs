using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using TI_Arquitetura45;
//
//                   PUC Minas - São Gabriel
//  Trabalho de Arquitetura de Computadores - Professor: Paulo Amaral
//  Integrante: Lucas Gomes, Jefferson Camelo, Arthur Vinícius, Thais Munhoz
//

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
        #endregion

        #region SYSTEM METHODS AND IMPLEMENTATION

        private void SendMessage(IntPtr handle, int v, IntPtr state, IntPtr zero)
        {
            throw new NotImplementedException();
        }

        private void ShowGeneralWin32(string type, ManagementObject obj, string text) // Insere um item no ListView possuindo o ManagementObject de algum obj como parâmetro
        {
            ListViewItem items = new ListViewItem();
            items.SubItems.Add(obj[type].ToString());
            items.Text = text;
            listgeneral.Items.Add(items);
        }

        private void ShowCacheMemory(string type, ManagementObject obj, string text) // Insere um item no ListView possuindo o ManagementObject de algum obj como parâmetro
        {
            ListViewItem items = new ListViewItem();
            try
            {
                items.SubItems.Add(obj[type].ToString());
                items.Text = text;
                listcache.Items.Add(items);
            }
            catch
            {
                items.SubItems.Add("0");
                items.Text = text;
                listcache.Items.Add(items);
            }
        }

        private void ShowGeneralWin32(string Name, string Value) // Insere um item no ListView
        {
            ListViewItem items = new ListViewItem();
            items.SubItems.Add(Name);
            items.Text = Value;
            listgeneral.Items.Add(items);
        }

        private void ShowGeneralVisualBasic() // Método usado para coletar o total de memmória RAM presente no computador
        {
            memorybyts = new ComputerInfo().TotalPhysicalMemory;
            int full = Convert.ToInt32(BytesToDouble(memorybyts));
            string MemoryUse = string.Format("Memória: {0:n1} GB (utilizável: {1:n1})", full, ToFileSize(memorybyts));
            ListViewItem items = new ListViewItem();
            items.SubItems.Add(MemoryUse);
            items.Text = "Memória RAM instalada";
            listgeneral.Items.Add(items);
        }
        #endregion

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

                ShowGeneralWin32(OSVersionInfo.GetOSVersionInfo().FullName, "Windows Edition");
                ShowGeneralWin32("Name", seacher, "Processador: ");
                ShowGeneralVisualBasic();
                ShowGeneralWin32("SystemName", seacher, "Nome do computador");
                ShowGeneralWin32(ToFileSize(freespace), "HD Free Space");
                ShowGeneralWin32(ToFileSize(size), "HD Total Space");
                progressBar1.Maximum = 100;
                int percent = Convert.ToInt32( 100 - ((freespace * 100) / size));
                progressBar1.Value = percent;
                label11.Text = percent + "%";
                #endregion

                #region Processor
                //Tab 3 - Processor Informations
                foreach (PropertyData data in seacher.Properties)
                {
                    if (data.Value != null && data.ToString() != "")
                    {
                        ListViewItem i = new ListViewItem();
                        i.Text = data.Name;
                        i.SubItems.Add(data.Value.ToString());
                        listProcessor.Items.Add(i);
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
        }

        private void timer_performance_Tick(object sender, EventArgs e)
        {
            Int64 phav = PerformanceInfo .GetPhysicalAvailableMemoryInMiB();
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
