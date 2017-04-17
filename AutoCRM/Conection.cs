using System;
using MySql.Data.MySqlClient;
using System.IO;
namespace AutoCRM
{
    public class Conection
    {
        private static MySqlConnection connection;
        public static MySqlConnection Connection { get => connection; set => connection = value; }
        public static string ServerN { get => serverN; set => serverN = value; }
        public static string Port1 { get => port; set => port = value; }
        public static string DatabaseN { get => databaseN; set => databaseN = value; }
        public static string UidN { get => uidN; set => uidN = value; }
        public static string PwdN { get => pwdN; set => pwdN = value; }

        private static string serverN;
        private static string port;
        private static string databaseN;
        private static string uidN;
        private static string pwdN;

        private static string connectionString;
        public static string sqlerromsg = null;

        /// <summary>
        /// Nome do Servidor Pad = "Servidor"
        /// </summary>
        /// <param name="name"></param>
        public static void ServerName(string name)
        {
            ServerN = name;
        }

        /// <summary>
        /// Porta usada Pad = "3306"
        /// </summary>
        /// <param name="porta"></param>
        public static void Port(string porta)
        {
            Port1 = porta;
        }

        /// <summary>
        /// Nome do banco de dados Pad="V11_Mafra"
        /// </summary>
        /// <param name="name"></param>
        public static void DataBaseName(string name)
        {
            DatabaseN = name;
        }

        /// <summary>
        /// Usuário para realizar o login Pad="root"
        /// </summary>
        /// <param name="user"></param>
        public static void User(string user)
        {
            UidN = user;
        }

        /// <summary>
        /// Senha para realizar o login="mafra1045@"
        /// </summary>
        /// <param name="pass"></param>
        public static void Password(string pass)
        {
            PwdN = pass;
        }

        /// <summary>
        /// Abrir conexão da aplicação com o banco de dados V11
        /// </summary>
        /// <returns></returns>
        public static bool Open()
        {
            connectionString = "SERVER=" + ServerN + ";Port=" + Port1 + ";DATABASE=" + DatabaseN + ";UID=" + UidN + ";Pwd=" + PwdN + "";

            if (ServerN != "" && DatabaseN != "" && UidN != "" && PwdN != "")
            {
                try
                {
                    Connection = new MySqlConnection(connectionString);
                    Connection.Open();
                    return true;
                }
                catch (MySqlException error)
                {
                    switch (error.Number)
                    {
                        case 0:
                            sqlerromsg = "Não foi possível conectar ao servidor";
                            break;
                        case 1:
                            sqlerromsg = "Usuário ou senha inválidos";
                            break;
                    }
                }
                catch (Exception)
                {
                    sqlerromsg = "Servidor Offiline";
                }
                return false;
            }
            else return false;
        }

        public static void LoadConfigs()
        {
            Encription.LerChave();

            if (File.Exists("Configuracoes"))
            {
                using (StreamReader Lerconfigs = new StreamReader("Configuracoes"))
                {
                    for (int x = 1; x <= 5; x++)
                    {
                        if (x == 1) ServerN = Encription.Decription(Lerconfigs.ReadLine());
                        else if (x == 2) DatabaseN = Encription.Decription(Lerconfigs.ReadLine());
                        else if (x == 3) PwdN = Encription.Decription(Lerconfigs.ReadLine());
                        else if (x == 4) UidN = Encription.Decription(Lerconfigs.ReadLine());
                        else Port1 = Encription.Decription(Lerconfigs.ReadLine());
                    }
                    Lerconfigs.Close();
                }
            }
        }

        public static void Close()
        {
            connection.Close();
        }
    }
}
