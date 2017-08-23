using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace TI_FSI
{
   static class ExcelFile
    {
        private static Application xlApp = new Application();
        private static Workbook xlbook;
        private static Worksheet xlsheets;
        private static Range xlrange;
        private static string file;

        public static string File { get => file; }
        public static Range Xlrange { get => xlrange; }

        public static void Dispose()
        {
            xlApp = null;
            xlbook = null;
            xlsheets = null;
            xlrange = null;
            file = null;

        }
        /// <summary>
        /// Carrega o Excel para aumentar o desempenho 
        /// deve ser usado quando sistema estiver inicializando para que o efeito esperado seda realizado
        /// </summary>
        public static void CreateXLSApp()
        {
            xlApp = new Application();
        }
        /// <summary>
        /// fecha o arquvio excel e salva as alterações
        /// </summary>
        public static string CloseXLS()
        {
            try
            {
                xlbook.Close(true);
                Marshal.ReleaseComObject(xlApp);
                Marshal.ReleaseComObject(xlbook);
                Marshal.ReleaseComObject(xlsheets);
                Marshal.ReleaseComObject(xlrange);
                MyGC();
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                MyGC();
            }

        }
        //Fecha todos os processos relacionados ao EXCEL
        private static void MyGC()
        {
            foreach (var process in Process.GetProcessesByName("EXCEL"))
            {
                try
                {
                    process.Kill();
                }
                catch
                {
                    continue;
                }
            }
        }
        /// <summary>
        /// Cria as instruções necessárias para leitura do arquivo bem como a atribuição no valor
        /// de requeridas variáveis. Retorna 1 para ok.
        /// </summary>
        /// <param name="arquivo">Nome do arquivo</param>
        /// <returns></returns>
        public static string SetFile(string arquivo, int sheet)
        {
            file = arquivo;
            if (arquivo != null)
            {
                try
                {
                    xlbook = xlApp.Workbooks.Open(arquivo, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, false, 1, 0);
                    xlsheets = (Worksheet)xlbook.Worksheets.get_Item(sheet);
                    xlrange = xlsheets.UsedRange;

                    return "1";
                }
                catch
                {
                    return "Não foi possível abrir o arquivo selecionado. Verifique se ele está aberto em alguma estação de trabalho.";
                }
            }
            else return "Arquivo Nullo";
        }

        /// <summary>
        /// Verifica o sheet informado. Retorna 1 se OK, 
        /// 0 para sheet não encontrado e -1 para erro encontrado
        /// TABELAS
        /// --ROUPAS-- TIPO/QUANTIDADE/DATA DE ENTRADA/DOADOR
        /// --COMIDA-- PRODUTO/QUANTIDADE(UN)/VALIDADE/DOADOR/DATA DE ENTRADA
        /// --BRINQUEDO-- NOME/QUANTIDADE/DOADOR/DATA DE ENTRADA
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int ValidarArquivo()
        {
            for (int i = 1; i <= 3; i++) // for para cada sheet
            {
                xlsheets = (Worksheet)xlbook.Worksheets.get_Item(i);

                //Verificando tabelas
                string n1 = Convert.ToString((xlrange.Cells[1, 1] as Range).Value2);
                string n2 = Convert.ToString((xlrange.Cells[1, 2] as Range).Value2);
                string n3 = Convert.ToString((xlrange.Cells[1, 3] as Range).Value2);
                string n4 = Convert.ToString((xlrange.Cells[1, 4] as Range).Value2);
                string n5 = Convert.ToString((xlrange.Cells[1, 5] as Range).Value2);

                switch (i) //verifica a validade de cada coluna
                {
                    case 1:
                        if (n1.ToUpper() != "TIPO" && n2.ToUpper() != "QUANTIDADE" && n3.ToUpper() != "DATA DE ENTRADA" && n4.ToUpper() != "DOADOR") return -1;
                        break;
                    case 2:
                        if (n1.ToUpper() != "PRODUTO" && n2.ToUpper() != "QUANTIDADE(UN)" && n3.ToUpper() != "VALIDADE" && n4.ToUpper() != "DOADOR" && n4.ToUpper() != "DATA DE ENTRADA") return -1;
                        break;
                    case 3:
                        if (n1.ToUpper() != "NOME" && n2.ToUpper() != "QUANTIDADE" && n3.ToUpper() != "DOADOR" && n4.ToUpper() != "DATA DE ENTRADA") return -1;
                        break;
                }
            }
            return 1; // se tudo ocorreu bem
        }

        public static void SetSheet(int i)
        {
            xlsheets = (Worksheet)xlbook.Worksheets.get_Item(i);
        }
    }
}
