using System;
using System.IO;

namespace AutoCRM
{
    static class LOG
    {
        private static StreamWriter logfile;
        public static StreamWriter Logfile { get => logfile; set => logfile = value; }
        public static string Logline { get => logline; set => logline = value; }
        private static string logline = "";

        public static void CreateLogFile()
        {

            int dia, mes, ano, hora, min, seg;
            dia = DateTime.Now.Day;
            mes = DateTime.Now.Month;
            ano = DateTime.Now.Year;
            hora = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            seg = DateTime.Now.Second;

            if (dia < 10) Logline += "0" + dia;
            else Logline += dia;
            if (mes < 10) Logline += "0" + mes;
            else Logline += mes;
            Logline += ano;
            if (hora < 10) Logline += "0" + hora;
            else Logline += hora;
            if (min < 10) Logline += "0" + min;
            else Logline += min;
            if (seg < 10) Logline += "0" + seg;
            else Logline += seg;

            try
            {
                Logfile = new StreamWriter(Environment.CurrentDirectory + @"\log\" + Logline + ".txt");
            }
            catch
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\log");
                Logfile = new StreamWriter(Environment.CurrentDirectory + @"\log\" + Logline + ".txt");
            }
        }
    }
}
