using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
namespace AutoCRM
{
    public class CrmFile
    {
        //Variáveis para a construção
        private static int TableRows = 0;
        private static int TableColumns;
        private static string arq;
        private static Excel.Application xlApp = new Excel.Application();
        private static Excel.Workbook xlbook;
        private static Excel._Worksheet xlsheets;
        private static Excel.Range xlrange;
        private static double PROVdata;
        private static double PROVhorai = 0;
        private static double PROVhoraf = 0;
        private static string PROVdatafin;
        private static string PROVdatain;

        private static int aux;
        /// <summary>
        /// Informa o que está sendo lido na linha atual
        /// </summary>
        /// <returns></returns>
        public static string ShowInformations()
        {
            return DateTime.FromOADate(PROVdata).ToShortDateString() + "  " + V11BD.Cliente + "  " + V11BD.Cliente_id + "  " + V11BD.Problema + "  " + V11BD.Solucao + "  " + V11BD.Datainicio + "  " + V11BD.Datafim + " " + V11BD.NumCRM;
        }
        /// <summary>
        /// Carrega o Excel para aumentar o desempenho 
        /// deve ser usado quando sistema estiver inicializando para que o efeito esperado seda realizado
        /// </summary>
        public static void CreateXLSApp()
        {
            xlApp = new Excel.Application();
        }
        /// <summary>
        /// fecha o arquvio excel e salva as alterações
        /// </summary>
        public static string CloseXLS()
        {
            try
            {
                xlbook.Save();
                xlbook.Close(true);
                Marshal.ReleaseComObject(xlApp);
                Marshal.ReleaseComObject(xlbook);
                Marshal.ReleaseComObject(xlsheets);
                Marshal.ReleaseComObject(xlrange);
                GC.Collect();
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        /// <summary>
        /// Cria as instruções necessárias para leitura do arquivo bem como a atribuição no valor
        /// de requeridas variáveis
        /// </summary>
        /// <param name="arquivo"></param>
        public static string SetFile(string arquivo)
        {
            arq = arquivo;
            if (arq != null)
            {
                try
                {
                    xlbook = xlApp.Workbooks.Open(arq, 0, false, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", true, false, 0, false, 1, 0);
                    xlsheets = (Excel.Worksheet)xlbook.Worksheets.get_Item(1);
                    xlrange = xlsheets.UsedRange;

                    TableRows = 0;
                    TableColumns = 0;

                    for (int aux = 1; aux < xlrange.Rows.Count; aux++)
                    {
                        if ((xlrange.Cells[aux, 1] as Excel.Range).Value2 == null)
                        {
                            break;
                        }
                        else TableRows++;

                    }
                    TableColumns = xlrange.Columns.Count;
                    return "";
                }
                catch
                {
                    return "Não foi possível abrir o arquivo selecionado. Verifique se ele está aberto em alguma estação de trabalho.";
                }
            }
            else return " ";
        }
        /// <summary>
        /// Tal método NÃO lê cada linha automaticamente. É preciso criar 2 for: O VALOR INICIAL DO FOR COM ROWS DEVE SER = 4, e o de Columns = 1.
        /// Escrita: for(int r = 4; r (menor que) xlsRowsCount(); r++)  {
        ///  for(int c = 4; c (menor que) xlsColumnsCount(); r++)
        ///   }
        /// 1º for menor que xlsRowsCount()
        /// 2º for menor que xlsColumnsCount().
        /// </summary>
        /// <param name="r">Valor atual de R dentro do for com comparação ao método xlsRowsCount()</param>
        /// <param name="c">Valor atual de C dentro do for com comparação ao método xlsColumnsCount()</param>
        /// <returns></returns>
        public static string LerArquivoESalvarManual(int r)
        {   //Arquivo Vazio 
            if (arq != null || arq != "")
            {
                //Lendo a primeira linha apenas
                if (r == 1)
                {
                    //Verificando nome do funcionário
                    if (Convert.ToString((xlrange.Cells[1, 1] as Excel.Range).Value2) != "")
                    {
                        V11BD.Funcionario = (xlrange.Cells[1, 1] as Excel.Range).Value2;
                        if (V11BD.GetFuncionario() == false) return "Funcionário não encontrado";
                    }
                    else
                    {
                        return "Nome do funcionário não informado";
                    }

                    //Verificando campo processo
                    if (Convert.ToString((xlrange.Cells[1, 10] as Excel.Range).Value2) != "")
                    {
                        try
                        {
                            V11BD.Processo = Convert.ToInt32((xlrange.Cells[1, 10] as Excel.Range).Value2);
                            if (V11BD.Processo != 3 && V11BD.Processo != 14) return "Valores inválidos para Nº do processo";
                        }
                        catch
                        {
                            return "VALOR INVÁLIDO PARA 'PROCESSO' [1,10] ACEITANDO os NÚMEROS 3 OU 8 APENAS";
                        }
                    }
                    else return "Processo não informado.";
                }
                else
                {
                    //verificando se esse CRM já foi preenchido
                    if (Convert.ToString((xlrange.Cells[r, 10] as Excel.Range).Value2) == "" || Convert.ToString((xlrange.Cells[r, 10] as Excel.Range).Value2) == null)
                    {
                        //Verificando se a primeira linha é válida (data)
                        if (Convert.ToString((xlrange.Cells[r, 1] as Excel.Range).Value2) != null || Convert.ToString((xlrange.Cells[r, 1] as Excel.Range).Value2) == "")
                        {
                            //Data
                            try
                            {
                                PROVdata = ((xlrange.Cells[r, 1] as Excel.Range).Value2);
                            }
                            catch
                            {
                                return "VALOR INVÁLIDO PARA A COLUNA DATA NA LINHA " + r;
                            }
                        }
                        else
                        {
                            return "VALOR INVÁLIDO PARA A COLUNA DATA NA LINHA " + r;
                        }
                        //Hora inicial
                        if (Convert.ToString((xlrange.Cells[r, 2] as Excel.Range).Value2) == null || Convert.ToString((xlrange.Cells[r, 2] as Excel.Range).Value2) == "") return "CÉLULA DA COLUNA 'HORA INICIAL' NA LINHA " + r + " NÃO FOI PREENCHIDA.";
                        else
                        {
                            try
                            {
                                PROVhorai = (xlrange.Cells[r, 2] as Excel.Range).Value2;
                            }
                            catch
                            {
                                string aux = (xlrange.Cells[r, 2] as Excel.Range).Value2;
                                PROVdatain = DateTime.FromOADate(PROVdata).ToShortDateString() + " " + aux;
                            }
                        }
                        //Hora final
                        if (Convert.ToString((xlrange.Cells[r, 3] as Excel.Range).Value2) == null || Convert.ToString((xlrange.Cells[r, 3] as Excel.Range).Value2) == "") return "CÉLULA DA COLUNA 'HORA FINAL' NA LINHA " + r + " NÃO FOI PREENCHIDA.";
                        else
                        {
                            try
                            {
                                PROVhoraf = (xlrange.Cells[r, 3] as Excel.Range).Value2;
                            }
                            catch
                            {
                                string aux = (xlrange.Cells[r, 3] as Excel.Range).Value2;
                                PROVdatafin = DateTime.FromOADate(PROVdata).ToShortDateString() + " " + aux;
                            }
                        }
                        //Cliente
                        if ((xlrange.Cells[r, 4] as Excel.Range).Value2 == null || (xlrange.Cells[r, 4] as Excel.Range).Value2 == "") return "CÉLULA DA COLUNA 'CLIENTE' NA LINHA " + r + " NÃO PREENCHIDA";
                        else
                        {
                            V11BD.Cliente = (xlrange.Cells[r, 4] as Excel.Range).Value2;
                        }
                        //Cliente ID
                        if (Convert.ToString((xlrange.Cells[r, 5] as Excel.Range).Value2) == null || Convert.ToString((xlrange.Cells[r, 5] as Excel.Range).Value2) == "") return "CÉLULA DA COLUNA 'CLIENTE ID' NA LINHA " + r + " NÃO PREENCHIDA";
                        else
                        {
                            try
                            {
                                V11BD.Cliente_id = Convert.ToInt32((xlrange.Cells[r, 5] as Excel.Range).Value2);
                            }
                            catch
                            {
                                return "VALOR INVÁLIDO INFORMADO NO CAMPO 'CLIENTE_ID' NA LINHA " + r;
                            }

                        }
                        //Centro de Custo
                        if (Convert.ToString((xlrange.Cells[r, 6] as Excel.Range).Value2) == null || Convert.ToString((xlrange.Cells[r, 6] as Excel.Range).Value2) == "") return "CÉLULA DA COLUNA 'CENTRO.CUSTO' NA LINHA " + r + " NÃO PREENCHIDA";
                        else
                        {
                            try
                            {
                                V11BD.Centrodecusto = Convert.ToInt32((xlrange.Cells[r, 6] as Excel.Range).Value2);
                            }
                            catch
                            {
                                return "VALOR INVÁLIDO INFORMADO NO CAMPO 'CENTRO.CUSTO' NA LINHA " + r;
                            }

                        }
                        //Problema
                        if (Convert.ToString((xlrange.Cells[r, 7] as Excel.Range).Value2) == null || Convert.ToString((xlrange.Cells[r, 7] as Excel.Range).Value2) == "") return " CÉLULA DA COLUNA 'PROBLEMA' NA LINHA " + r + "NÃO FOI PREENCHIDA.";
                        else
                        {
                            V11BD.Problema = (xlrange.Cells[r, 7] as Excel.Range).Value2;
                            V11BD.Problema = V11BD.Problema.ToUpper();
                        }
                        //Solução
                        if (Convert.ToString((xlrange.Cells[r, 8] as Excel.Range).Value2) == null || Convert.ToString((xlrange.Cells[r, 8] as Excel.Range).Value2) == "") return "CÉLULA DA COLUNA 'SOLUÇÃO' NA LINHA " + r + " NÃO FOI PREENCHIDA.";
                        else
                        {
                            V11BD.Solucao = (xlrange.Cells[r, 8] as Excel.Range).Value2;
                            V11BD.Solucao = V11BD.Solucao.ToUpper();
                        }

                        //Tentativa de conversão das datas
                        try
                        {
                            PROVdatain = DateTime.FromOADate(PROVdata).ToShortDateString() + " " + DateTime.FromOADate(PROVhorai).ToShortTimeString();
                            PROVdatafin = DateTime.FromOADate(PROVdata).ToShortDateString() + " " + DateTime.FromOADate(PROVhoraf).ToShortTimeString();
                            V11BD.Datainicio = Convert.ToDateTime(PROVdatain);
                            V11BD.Datafim = Convert.ToDateTime(PROVdatafin);
                        }
                        catch
                        {
                            return "INFORMAÇÕES NA DATA HORA DA LINHA " + r + " NÃO FORAM INFORMADAS CORRETAMENTE";
                        }
                    }
                    else return "skip";
                }
                aux = r;
                return "OK";
            }
            else return "Não há arquivo para leitura";
        }
        /// <summary>
        /// Conta o número de linhas preenchidas com CRM parar lançar 
        /// </summary>
        /// <returns></returns>
        public static int xlsRowsCount()
        {
            return TableRows;
        }
        /// <summary>
        /// fornece o número de CRM que estão no XLS
        /// </summary>
        /// <returns></returns>
        public static int xlColumnsCount()
        {
            return TableColumns;
        }
        public static void InsertValueEXCEL()
        {
            if (aux > 3) xlsheets.Cells[aux, 10] = V11BD.NumCRM;
            xlApp.DisplayAlerts = false;
            xlbook.Save();
        }
        public static string ValidarArquivo()
        {
            //Pegando informações para validade do arquivo padrão
            string n1 = Convert.ToString((xlrange.Cells[3, 1] as Excel.Range).Value2);//DATA
            string n2 = Convert.ToString((xlrange.Cells[3, 2] as Excel.Range).Value2);//INICIO
            string n3 = Convert.ToString((xlrange.Cells[3, 3] as Excel.Range).Value2);//FINAL
            string n4 = Convert.ToString((xlrange.Cells[3, 4] as Excel.Range).Value2);//CLIENTE
            string n5 = Convert.ToString((xlrange.Cells[3, 5] as Excel.Range).Value2);//COD.
            string n6 = Convert.ToString((xlrange.Cells[3, 6] as Excel.Range).Value2);//C. CUSTO
            string n7 = Convert.ToString((xlrange.Cells[3, 7] as Excel.Range).Value2);//PROBLEMA
            string n8 = Convert.ToString((xlrange.Cells[3, 8] as Excel.Range).Value2);//SOLUÇÃO
            string n10 = Convert.ToString((xlrange.Cells[3, 9] as Excel.Range).Value2);//TOTAL MIN
            string n11 = Convert.ToString((xlrange.Cells[3, 10] as Excel.Range).Value2);// N° CRM

            if (n1 == "DATA" && n2 == "INICIO" && n3 == "FINAL" && n4 == "CLIENTE" && n5 == "COD." && n6 == "C. CUSTO" && n7 == "PROBLEMA" && n8 == "SOLUÇÃO" && n10 == "TOTAL MIN" && n11 == "N° CRM") return "";
            else return "Arquivo não compativel com o modelo padrão de cadastro de CRM";
        }
    }
}
