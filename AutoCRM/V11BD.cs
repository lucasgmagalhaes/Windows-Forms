using System;
using MySql.Data.MySqlClient;

namespace AutoCRM
{
    public class V11BD
    {
        //variáveis do CRM
        private static int numCRM;
        private static int filial = 2;
        private static int contrato;
        private static string cliente;
        private static int cliente_id;
        private static string contato = "CAIXA";
        private static string funcionario;
        private static int funcionario_id;
        private static int processo = 14;
        private static int centrodecusto;
        private static int centrodecusto_id;
        private static DateTime datainicio;
        private static DateTime datafim;
        private static string problema;
        private static string solucao;

        public static int NumCRM { get => numCRM; set => numCRM = value; }
        public static string Cliente { get => cliente; set => cliente = value; }
        public static int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public static string Contato { get => contato; set => contato = value; }
        public static string Funcionario { get => funcionario; set => funcionario = value; }
        public static int Processo
        {
            get => processo;
            set
            {
                if (value == 8) processo = 14;
                else processo = value;
            }
        }
        public static int Centrodecusto { get => centrodecusto; set => centrodecusto = value; }
        public static DateTime Datainicio { get => datainicio; set => datainicio = value; }
        public static DateTime Datafim { get => datafim; set => datafim = value; }
        public static string Problema { get => problema; set => problema = value; }
        public static string Solucao { get => solucao; set => solucao = value; }

        private static DateTime Atual = DateTime.Now;
        public static bool GetFuncionario()
        {
            Conection.Open();

            MySqlCommand search = new MySqlCommand("select cod_fu1 from(select cod_fu1, `nom_fu1` from nomedatabela" +
                    " where `nom_fu1` like '%" + funcionario + "%') as likeMatches" +
                    " limit 1;", Conection.Connection);
            try
            {
                funcionario_id = Convert.ToInt32(search.ExecuteScalar());

            }
            catch(Exception ex)
            {
                LOG.Logfile.WriteLine("V11BD_GETFUNCIONARIO() RETURNED ->" + ex);
            }

            if (funcionario_id != 0) return true;
            else return false;
        }
        public static bool GetContrato()
        {
            Conection.Open();

            MySqlCommand get = new MySqlCommand("SELECT id__cn1 FROM nomedatabela where cli_cn1 = '" + Cliente_id + "';", Conection.Connection);
            try
            {
                contrato = Convert.ToInt32(get.ExecuteScalar());
                if (contrato != 0) return true;
                else return false;
            }
            catch(Exception ex)
            {
                LOG.Logfile.WriteLine("V11BD_GETCONTRATO() RETURNED -> " + ex);
                return false;
            }
        }
        public static bool GetCentro_Custo()
        {
            Conection.Open();

            MySqlCommand gett2 = new MySqlCommand("SELECT id__ti1 FROM nomedatabela where cod_ti1 =" + centrodecusto, Conection.Connection);
            try
            {
                centrodecusto_id = Convert.ToInt32(gett2.ExecuteScalar());
                if (centrodecusto_id != 0) return true;
                else return false;
            }
            catch(Exception ex)
            {
                LOG.Logfile.WriteLine("V11_GETCENTRO_CUSTO() RETURNED -> " + ex);
                return false;
            }
        }
        public static string InsertIntoBD()
        {
            Conection.Open();

            string IDC;
            if (processo == 3) IDC = "3          1   2   2";
            else IDC = "14         1   3   3";

            // InsertSolicitacaoEtapas();
            //PS: ANALISANDO A CRM 22245
            //Cabeçalho
            //3  -> 00003  = SUPORTE FORA DO HORÁRIO COMERCIAL
            //14 -> 00008 = SUPORTE HORÁRIO COMERCIAL
            //IDC --> PROC = 3, IDC = 3          1   2   2
            //IDC --> PROC = 14, IDC = 14         1   3   3
            try
            {
                MySqlCommand Insert = new MySqlCommand("INSERT INTO nomedatabela(`pro_bm1`,`ccn_bm1`,`tab_bm1`,`id1_bm1`,`cl1_bm1`," +
                         "`con_bm1`,`hum_bm1`,`cl2_bm1`,`fu1_bm1`,`fu2_bm1`,`tas_bm1`,`pda_bm1`,`ida_bm1`,`fda_bm1`,`cda_bm1`,`res_bm1`,`obi_bm1`,`obf_bm1`,`for_bm1`,`fim_bm1`,`idc_bm1`," +
                         "`pos_bm1`,`ito_bm1`,`ica_bm1`,`itd_bm1`,`dmu_bm1`,`stc_bm1`,`sto_bm1`,`std_bm1`,`stu_bm1`,`exc_bm1`,`exu_bm1`,`exd_bm1`,`dur_bm1`,`c01_bm1`,`c02_bm1`,`c03_bm1`," +
                         "`c04_bm1`,`c05_bm1`,`c06_bm1`,`c07_bm1`,`c08_bm1`,`c09_bm1`,`c10_bm1`,`sus_bm1`,`id__bm1`,`atv_bm1`,`usu_bm1`,`usd_bm1`,`upd_bm1`,`emp_bm1`,`uaa_bm1`,`usi_bm1`)" +
                         "VALUES(" + processo + ", " + contrato + ", '', 0, " + cliente_id + ", '" + contato + "', 3, 0, " + funcionario_id + ", 0," + centrodecusto_id + ", '" + Atual.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + datainicio.ToString("yyyy-MM-dd HH:mm:ss") +
                         "', '" + datafim.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                         "" + "null, '', '', '', " + filial + ", 1, " + "'" + IDC + "', 1, 0, 0, 0, '" + datafim.ToString("yyyy-MM-dd HH:mm:ss") +
                         "', 0, '', '" + Atual.ToString("yyyy-MM-dd HH:mm:ss") + "','', 1, '', null, 0, '', '', '', '', 0, 0, 0, 0, null, null, 2, 0, 0, 'Lucas','" + Atual.ToString("yyyy-MM-dd HH:mm:ss") + "', '', 2" +
                         ",null,'" + Atual.ToString("yyyy-MM-dd HH:mm:ss") + "');", Conection.Connection);

                Insert.ExecuteScalar();

                MySqlCommand GetVal = new MySqlCommand("SELECT cod_bm1 FROM nomedatabela order by cod_bm1 desc limit 1;", Conection.Connection);
                numCRM = Convert.ToInt32(GetVal.ExecuteScalar());

                MySqlCommand InsertEt = new MySqlCommand("INSERT INTO v11_mafra.opcrmsolicitacaoetapas(`cod_bm2`, `cl1_bm2`,`con_bm2`,`hum_bm2`,`fu1_bm2`,`ida_bm2`," +
                    "`fda_bm2`,`res_bm2`,`obs_bm2`,`obi_bm2`,`ob2_bm2`,`ck1_bm2`,`ck2_bm2`,`ck3_bm2`,`ck4_bm2`,`ck5_bm2`,`ie1_bm2`,`ie2_bm2`,`ie3_bm2`,`ie4_bm2`,`ie5_bm2`,`stc_bm2`," +
                    "`sto_bm2`,`std_bm2`,`stu_bm2`,`idc_bm2`,`ito_bm2`,`ica_bm2`,`itd_bm2`,`pos_bm2`,`dur_bm2`,`c01_bm2`,`c02_bm2`,`c03_bm2`,`c04_bm2`,`c05_bm2`,`c06_bm2`,`c07_bm2`," +
                    "`c08_bm2`,`c09_bm2`,`c10_bm2`,`atv_bm2`,`usu_bm2`,`usd_bm2`,`upd_bm2`,`emp_bm2`,`uaa_bm2`,`usi_bm2`)" +
                    "VALUES(" + numCRM + ", " + cliente_id + ",'CAIXA', 3, " + funcionario_id + ", '" + datainicio.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + datafim.ToString("yyyy-MM-dd HH:mm:ss") + "', '', '" + problema + "', '" + solucao +
                    "', '', 0, 0, 0, 0, 0, '', '', '', '', '', 0, '', '" + Atual.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    "'', '3          1   2   2', 0, 0, 0, 1, 0, '', '', '', '', 0, 0, 0, 0, null, null, 0, 'Lucas', '" + datafim.ToString("yyyy-MM-dd HH:mm:ss") + "', '', 2, null, '" + datafim.ToString("yyyy-MM-dd HH:mm:ss") + "');", Conection.Connection);

                InsertEt.ExecuteNonQuery();
                CrmFile.InsertValueEXCEL();
                return "";

            }
            catch (Exception ex)
            {
                LOG.Logfile.WriteLine("V11BD_INSERTINTOBD() RETURNED -> " + ex);
                return ex.ToString();
            }
        }
    }
}
