using System;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using AutoCRM;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace Bloqueados_Auto
{
    class Program
    {
        #region VARIABLES
        private static List<string> Codigo = new List<string>();
        private static List<string> Nome = new List<string>();
        private static List<string> Quant = new List<string>();
        private static DateTime time;
        private static string ActualMinTime;
        private static string ActualMaxHour;
        private static string MinDayMinHour;
        private static string MinDayMaxHour;
        public static string PDFNomefile = "PDFs\\Bloqueados " + DateTime.Now.ToString("dd") + " - " + DateTime.Now.ToString("MM") + " Nome.pdf";
        public static string PDFQuantFile = "PDFs\\Bloqueados " + DateTime.Now.ToString("dd") + " - " + DateTime.Now.ToString("MM") + " Numérico.pdf";
        public static string Eto;
        public static string Efrom;
        public static string Etitle;
        public static string Emsg;
        public static string Esmtp;
        public static string Eport;
        public static string Epass;
        #endregion
        /// <summary>
        /// Coleta as informações do select
        /// </summary>
        /// <param name="typ">1 para OrderByName // 2 para OrderByNumeric</param>
        private static string GetList(int typ)
        {
            ActualMinTime = DateTime.Now.Year + "0201000000";
            time = DateTime.Now;
            ActualMaxHour = time.AddDays(-1).ToString("yyyyMMdd") + "000000";
            time = DateTime.Today.AddMonths(-6);
            MinDayMinHour = time.ToString("yyyyMMdd") + "000000";
            MinDayMaxHour = time.ToString("yyyyMMdd") + "235959";
            int ano = DateTime.Now.Year - 1;

            MySqlCommand getall;
            try
            {
                if (typ == 1)
                {
                    getall = new MySqlCommand("SELECT _cl11.cod_cl1 C01_t01, MAX(_cl11.nom_cl1) N01_t01, COUNT(DISTINCT _cr1.cod_cr1) Contador1, SUM(ROUND(_cr1.val_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) val_cr1, SUM(ROUND(_cr1.vee_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) vee_cr1, SUM(ROUND(_cr1.vec_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) vec_cr1, SUM(ROUND(_cr1.var_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) var_cr1, SUM(ROUND(_cr1.des_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) des_cr1, SUM(ROUND(_cr1.oud_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) oud_cr1, SUM(ROUND(_cr1.mem_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) mem_cr1, SUM(ROUND(_cr1.mov_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) mov_cr1, SUM(ROUND(_cr1.svt_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) svt_cr1 FROM v11_mafra.OpLancamentosContasReceber _CR1 LEFT JOIN v11_mafra.CadastrosClientesFornecedoresRepresentadasTransportadoras _CL11 ON _cl11.id__cl1 = _cr1.cl1_cr1  WHERE (_cr1.ven_cr1 BETWEEN '" + ActualMinTime + "' AND '" + ActualMaxHour + "') AND (_cr1.agr_cr1 = 1 OR _cr1.agr_cr1 = 2) AND (_cr1.exc_cr1 = 1) AND (1=1) AND (_cr1.dcs_cr1 = 2) AND (_cr1.emp_cr1 = 2) AND (_cr1.cod_cr1 IN (SELECT _cr1.cod_cr1 FROM v11_mafra.OpLancamentosContasReceber _cr1 LEFT JOIN v11_mafra.CadastrosLancamentosAutomaticos _LA11 ON _la11.id__la1 = _cr1.laa_cr1 LEFT JOIN v11_mafra.CadastrosContratos _CN11 ON _cn11.id__cn1 = _cr1.cnn_cr1 LEFT JOIN v11_mafra.CadastrosCentrosDeCustos _TI11 ON _ti11.id__ti1 = _cr1.tip_cr1 LEFT JOIN v11_mafra.CadastrosClientesFornecedoresRepresentadasTransportadoras _CL11 ON _cl11.id__cl1 = _cr1.cl1_cr1 LEFT JOIN v11_mafra.CadastrosClientesFornecedoresRepresentadasTransportadoras _CL12 ON _cl12.id__cl1 = _cr1.cl2_cr1 LEFT JOIN v11_mafra.CadastrosClientesFornecedoresRepresentadasTransportadoras _CL13 ON _cl13.id__cl1 = _cr1.ctr_cr1 LEFT JOIN v11_mafra.CadastrosFuncionarios _FU11 ON _fu11.id__fu1 = _cr1.fu1_cr1 LEFT JOIN v11_mafra.CadastrosFuncionarios _FU12 ON _fu12.id__fu1 = _cr1.fu2_cr1 LEFT JOIN v11_mafra.CadastrosPlanoContas _PC11 ON _pc11.id__pc1 = _cr1.ccr_cr1 LEFT JOIN v11_mafra.CadastrosPlanoContas _PC12 ON _pc12.id__pc1 = _cr1.ccc_cr1 LEFT JOIN v11_mafra.CadastrosFiliais _FI11 ON _fi11.cod_fi1 = _cr1.fio_cr1 LEFT JOIN v11_mafra.CadastrosFiliais _FI12 ON _fi12.cod_fi1 = _cr1.fid_cr1 LEFT JOIN v11_mafra.CadastrosCartoesCredito _CA11 ON _ca11.id__ca1 = _cr1.car_cr1 LEFT JOIN v11_mafra.CadastrosStatusOperacoes _ST11 ON _st11.id__st1 = _cr1.stc_cr1 LEFT JOIN v11_mafra.CadastrosPromocoesKitsCabecalhos _PM11 ON _pm11.id__pm1 = _cr1.spm_cr1 LEFT JOIN v11_mafra.CadastrosContasCaixas _CX11 ON _cx11.cod_cx1 = _cr1.cxe_cr1 LEFT JOIN v11_mafra.CadastrosContasCaixas _CX12 ON _cx12.cod_cx1 = _cr1.cxq_cr1 LEFT JOIN v11_mafra.CadastrosContasCaixas _CX13 ON _cx13.cod_cx1 = _cr1.cxa_cr1  WHERE ( (_cr1.ccr_cr1=0  OR   _cr1.ccr_cr1=206  OR   _cr1.ccr_cr1=207  OR   _cr1.ccr_cr1=209  OR   _cr1.ccr_cr1=179  OR   _cr1.ccr_cr1=198  OR   _cr1.ccr_cr1=204  OR   _cr1.ccr_cr1=203  OR   _cr1.ccr_cr1=225  OR   _cr1.ccr_cr1=227  OR   _cr1.ccr_cr1=228  OR   _cr1.ccr_cr1=224  OR   _cr1.ccr_cr1=226) AND   _cr1.dem_cr1 < '" + ano +"111900000' OR _cr1.dem_cr1 > '" + ano + "1119235959' ) AND (_cr1.emp_cr1 IN (2)))) AND (_cr1.emp_cr1 IN (2)) GROUP BY _cl11.cod_cl1 ORDER BY N01_T01 ASC", Conection.Connection);
                }
                else
                {
                    Conection.Open();
                    getall = new MySqlCommand("SELECT _cl11.cod_cl1 C01_t01, MAX(_cl11.nom_cl1) N01_t01, COUNT(DISTINCT _cr1.cod_cr1) Contador1, SUM(ROUND(_cr1.val_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) val_cr1, SUM(ROUND(_cr1.vee_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) vee_cr1, SUM(ROUND(_cr1.vec_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) vec_cr1, SUM(ROUND(_cr1.var_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) var_cr1, SUM(ROUND(_cr1.des_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) des_cr1, SUM(ROUND(_cr1.oud_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) oud_cr1, SUM(ROUND(_cr1.mem_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) mem_cr1, SUM(ROUND(_cr1.mov_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) mov_cr1, SUM(ROUND(_cr1.svt_cr1 * CASE WHEN _cr1.moe_cr1 = 2 OR _cr1.moe_cr1 BETWEEN 0 AND 2 THEN 1 WHEN _cr1.moe_cr1 = 3 THEN _cr1.mo1_cr1 WHEN _cr1.moe_cr1 = 4 THEN _cr1.mo2_cr1 END / CASE WHEN _cr1.moe_cr1 = 2 THEN 1 ELSE 1 END, 2)) svt_cr1 FROM v11_mafra.OpLancamentosContasReceber _CR1 LEFT JOIN v11_mafra.CadastrosClientesFornecedoresRepresentadasTransportadoras _CL11 ON _cl11.id__cl1 = _cr1.cl1_cr1  WHERE (_cr1.ven_cr1 BETWEEN '" + ActualMinTime + "' AND '" + ActualMaxHour + "') AND (_cr1.agr_cr1 = 1 OR _cr1.agr_cr1 = 2) AND (_cr1.exc_cr1 = 1) AND (1=1) AND (_cr1.dcs_cr1 = 2) AND (_cr1.emp_cr1 = 2) AND (_cr1.cod_cr1 IN (SELECT _cr1.cod_cr1 FROM v11_mafra.OpLancamentosContasReceber _cr1 LEFT JOIN v11_mafra.CadastrosLancamentosAutomaticos _LA11 ON _la11.id__la1 = _cr1.laa_cr1 LEFT JOIN v11_mafra.CadastrosContratos _CN11 ON _cn11.id__cn1 = _cr1.cnn_cr1 LEFT JOIN v11_mafra.CadastrosCentrosDeCustos _TI11 ON _ti11.id__ti1 = _cr1.tip_cr1 LEFT JOIN v11_mafra.CadastrosClientesFornecedoresRepresentadasTransportadoras _CL11 ON _cl11.id__cl1 = _cr1.cl1_cr1 LEFT JOIN v11_mafra.CadastrosClientesFornecedoresRepresentadasTransportadoras _CL12 ON _cl12.id__cl1 = _cr1.cl2_cr1 LEFT JOIN v11_mafra.CadastrosClientesFornecedoresRepresentadasTransportadoras _CL13 ON _cl13.id__cl1 = _cr1.ctr_cr1 LEFT JOIN v11_mafra.CadastrosFuncionarios _FU11 ON _fu11.id__fu1 = _cr1.fu1_cr1 LEFT JOIN v11_mafra.CadastrosFuncionarios _FU12 ON _fu12.id__fu1 = _cr1.fu2_cr1 LEFT JOIN v11_mafra.CadastrosPlanoContas _PC11 ON _pc11.id__pc1 = _cr1.ccr_cr1 LEFT JOIN v11_mafra.CadastrosPlanoContas _PC12 ON _pc12.id__pc1 = _cr1.ccc_cr1 LEFT JOIN v11_mafra.CadastrosFiliais _FI11 ON _fi11.cod_fi1 = _cr1.fio_cr1 LEFT JOIN v11_mafra.CadastrosFiliais _FI12 ON _fi12.cod_fi1 = _cr1.fid_cr1 LEFT JOIN v11_mafra.CadastrosCartoesCredito _CA11 ON _ca11.id__ca1 = _cr1.car_cr1 LEFT JOIN v11_mafra.CadastrosStatusOperacoes _ST11 ON _st11.id__st1 = _cr1.stc_cr1 LEFT JOIN v11_mafra.CadastrosPromocoesKitsCabecalhos _PM11 ON _pm11.id__pm1 = _cr1.spm_cr1 LEFT JOIN v11_mafra.CadastrosContasCaixas _CX11 ON _cx11.cod_cx1 = _cr1.cxe_cr1 LEFT JOIN v11_mafra.CadastrosContasCaixas _CX12 ON _cx12.cod_cx1 = _cr1.cxq_cr1 LEFT JOIN v11_mafra.CadastrosContasCaixas _CX13 ON _cx13.cod_cx1 = _cr1.cxa_cr1  WHERE ( (_cr1.ccr_cr1=0  OR   _cr1.ccr_cr1=206  OR   _cr1.ccr_cr1=207  OR   _cr1.ccr_cr1=209  OR   _cr1.ccr_cr1=179  OR   _cr1.ccr_cr1=198  OR   _cr1.ccr_cr1=204  OR   _cr1.ccr_cr1=203  OR   _cr1.ccr_cr1=225  OR   _cr1.ccr_cr1=227  OR   _cr1.ccr_cr1=228  OR   _cr1.ccr_cr1=224  OR   _cr1.ccr_cr1=226) AND   _cr1.dem_cr1 < '" + ano + "111900000' OR _cr1.dem_cr1 > '" + ano + "1119235959' ) AND (_cr1.emp_cr1 IN (2)))) AND (_cr1.emp_cr1 IN (2)) GROUP BY _cl11.cod_cl1 ORDER BY Contador1 DESC", Conection.Connection);
                }

                using (MySqlDataReader reader = getall.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Codigo.Add(reader["C01_t01"].ToString());
                        Nome.Add(reader["N01_t01"].ToString());
                        Quant.Add(reader["Contador1"].ToString());
                    }
                }
                Conection.Close();
                return "0";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        /// <summary>
        /// Cria o PDF com as inforamções do select
        /// </summary>
        /// <param name="ty"></param>
        private static string CreateList(int ty)
        {
            if (!Directory.Exists("PDFs"))
            {
                Directory.CreateDirectory("PDFs");
            }

            try
            {
                Document doc = new Document(PageSize.A4, 1, 1, 5, 5);
                PdfWriter wri;
                if (ty == 1) wri = PdfWriter.GetInstance(doc, new FileStream(PDFNomefile, FileMode.Create));
                else wri = PdfWriter.GetInstance(doc, new FileStream(PDFQuantFile, FileMode.Create));
                doc.Open();
                float[] wid = new float[] { 20, 150, 30 };
                PdfPTable table = new PdfPTable(3);
                table.SetWidths(wid);
                PdfPCell cell = new PdfPCell(new Phrase("Lista de bloqueados - Mafra informática"));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                table.AddCell("Código");
                table.AddCell("Cliente");
                table.AddCell("Números");

                for (int i = 0; i < Codigo.Count; i++)
                {
                    table.AddCell(Codigo[i]);
                    table.AddCell(Nome[i]);
                    table.AddCell(Quant[i]);
                }

                doc.Add(table);
                doc.Close();
                return "0";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        /// <summary>
        /// Coleta as informações do arquivo 'DataSettings' gerado pelo projeto 'Bloqueados Auto' e seta os valores 
        /// em suas respectivas variaveis
        /// </summary>
        private static void InformationFileRead()
        {
            try
            {
                using (StreamReader Ler = new StreamReader("DataSettings"))
                {
                    Efrom = Encription.Decription(Ler.ReadLine());
                    Epass = Encription.Decription(Ler.ReadLine());
                    Esmtp = Encription.Decription(Ler.ReadLine());
                    Eport = Encription.Decription(Ler.ReadLine());
                    Eto = Encription.Decription(Ler.ReadLine());
                    Etitle = Encription.Decription(Ler.ReadLine());
                    Emsg = Encription.Decription(Ler.ReadLine());
                    Emsg = Emsg.Replace("\\n", "<br>");
                    Ler.Close();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Falha na leitura do arquivo com dados. ERRO: " + err.Message);
            }
        }
        /// <summary>
        /// Tenta a conexão com o banco
        /// </summary>
        private static void TryConect()
        {
            try
            {
                if (Conection.Open())
                {
                    Console.WriteLine("Conexão estabelecida.");
                }
                else
                {
                    Console.WriteLine("Falha na conexão com o banco.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Limpa as informações contidas nos List<>
        /// </summary>
        private static void CleanList()
        {
            Codigo.Clear();
            Nome.Clear();
            Quant.Clear();
        }
        static void Main(string[] args)
        {
            Console.Title = "Envio Automático de PDF Bloqueados - LGSM";
            Console.WriteLine("LSGM AutoBloqueados [2.5.0]");
            Console.WriteLine("<----Gerador Automático de lista de bloqueados - Mafra informática---->");
            Console.WriteLine("Iniciando conexão com o banco de dados...");
            TryConect();

            Console.WriteLine("Coletando informações para a tabela ordenada por Nome...");
            if (GetList(1) == "0")
            {
                Console.WriteLine("Criando PDF de relatorio ordenado por nome...");
                if (CreateList(1) != "0")
                {
                    Console.WriteLine(CreateList(1));
                }
            }
            else
            {
                Console.WriteLine(GetList(1));
            }

            CleanList();

            Console.WriteLine("Coletando informações para a tabela ordenada por Quantidade...");
            if (GetList(2) == "0")
            {
                Console.WriteLine("Criando PDF de relatorio ordenado por Quantidade...");
                if (CreateList(2) != "0")
                {
                    Console.WriteLine(CreateList(2));
                }
            }
            else
            {
                Console.WriteLine(GetList(2));
            }
            Console.WriteLine("Preparando arquivo(s) para envio...");

            Console.WriteLine("Estabelecendo conexão com a internet...");
            Email.NetTest();

            Console.WriteLine("Lendo arquivo com dados STMP e cliente...");
            InformationFileRead();

            Email.Send(Efrom, Eto, Epass, Etitle, Emsg);
        }
    }
}
