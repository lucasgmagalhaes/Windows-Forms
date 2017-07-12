using System;
using MySql.Data.MySqlClient;

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

        private static string serverN = "Servidor";
        private static string port = "3306";
        private static string databaseN = "V11_Mafra";
        private static string uidN = "root";
        private static string pwdN = "mafra1045@";

        private static string connectionString;
        public static string sqlerromsg = null;

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
        public static void Close()
        {
            connection.Close();
        }
    }
}
