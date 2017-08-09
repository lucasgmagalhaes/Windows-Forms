using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace BirdCopy
{
    class Program
    {
        static FbConnection fbcon;

        /// <summary>
        /// Start Firebird conection
        /// </summary>
        /// <param name="bdpath">path of the database</param>
        /// <returns></returns>
        static string StartConection(string bdpath)
        {
            try
            {
                string conn;
                conn = @"User=SYSDBA;Password=masterkey;Database=" + bdpath + ";Port=3050;Dialet=3;Charset=NONE;"
                 + "Role=;Conection lifetime=0;Conection timeout=7;Pooling=True;Packet Size=8192;Server Type=0";
                fbcon = new FbConnection(conn);
                fbcon.Open();
                return "Conection sucessfull.";
            }
            catch (Exception e)
            {
                return "Falha na conexão com o banco. Exceção: " + e.Message;
            }
        }

        static List<List<string>> GET_TABLEROWS(FbDataReader brill)
        {
            List<List<string>> returnned = new List<List<string>>();
            while (brill.Read())
            {
                List<string> colums = new List<string>();
                for (int index = 0; index < brill.VisibleFieldCount; index++)
                {
                    colums.Add(brill[index].ToString());
                }
                returnned.Add(colums);
            }
            return returnned;
        }
        /// <summary>
        /// GET All column name of a table and return it in a vector
        /// </summary>
        /// <param name="brill2"></param>
        /// <returns></returns>
        static List<string> GET_TABLECOLUMNSNAME(FbDataReader brill2)
        {
            List<string> ret = new List<string>();
            for (int i = 0; i < brill2.VisibleFieldCount; i++)
            {
                ret.Add(brill2.GetName(i));
            }
            return ret;
        }

        static void SQLCrazyInsert(List<List<string>> Rows, List<string> colums_name, FbCommand fbgo, string tableto)
        {
            foreach (List<string> r in Rows)
            {
                string command = "INSERT INTO " + tableto + "(";
                for (int ind = 0; ind < colums_name.Count; ind++) // SETTING COLUMNS NAMES
                {
                    if (ind == colums_name.Count - 1)
                    {
                        command += colums_name[ind] + ")";
                    }
                    else
                    {
                        command += colums_name[ind] + ", ";
                    }
                }
                command += " VALUES(";
                int number;
                bool isnumeric;

                for (int ind = 0; ind < r.Count; ind++) //SETTING VALUES
                {
                    if (r[ind] == "")
                    {
                        command += "null";
                    }
                    else if ((isnumeric = int.TryParse(r[ind], out number)) == false) //if variable isn't a number
                    {
                        command += "'" + r[ind] + "'";
                    }
                    else
                    {
                        command += r[ind];
                    }

                    if (ind != r.Count - 1)
                    {
                        command += ", ";
                    }
                    else
                    {
                        command += ")";
                    }
                }
                fbgo.CommandText = command;
                try
                {
                    fbgo.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=================Mafra LSGM Firebird Copy Tool v1=================");

            //Console.Write("Caminho do banco Para copiar -> ");
            // string pathfull = Console.ReadLine();
            string pathfull = @"C:\ERP_TRONSOFT\ERP_TRONSOFT.FDB";
            Console.WriteLine(StartConection(pathfull));

            FbCommand com = new FbCommand();
            com.Connection = fbcon;
            com.CommandText = "SELECT * FROM ITEM_CARDAPIO ORDER BY CD_ITEMCARDAPIO ASC";
            FbDataReader getdata1 = com.ExecuteReader();

            //GETTING INFORMATIONS OF DATABASE 1
            Console.Write("Lendo nome das colunas...  ");
            List<string> colums_name = GET_TABLECOLUMNSNAME(getdata1);
            Console.Write(colums_name.Count + " Colunas presente na tabela.\n\n");

            Console.Write("Coletando os valores inseridos...  ");
            List<List<string>> Rows;
            Rows = GET_TABLEROWS(getdata1);

            //GETTING CLASS DATA INFORMATION;
            Console.WriteLine("Coletando informações de CLASSE_ITEMCARDAPIO...");
            com.CommandText = "SELECT * FROM CLASSE_ITEMCARDAPIO";
            getdata1 = com.ExecuteReader();
            List<string> clsinfo = GET_TABLECOLUMNSNAME(getdata1);
            List<List<string>> clsinforows = GET_TABLEROWS(getdata1);
            fbcon.Close();
            Console.Write(Rows.Count + " linhas salvas.\n\n");

            //COLUMN THAT WILL BE IGNORED
            colums_name.Remove("CEST");
            foreach (List<string> secondlist in Rows)
            {
                secondlist.RemoveAt(secondlist.Count - 1);
            }

            //GETTING DATA FROM ITEM_CARDAPIOXEMPRESA
            Console.WriteLine("Coletando informações da tabela ITEM_CARDAPIOXEMPRESA");

            Console.WriteLine("Conectando ao segundo banco...");
            //INSERTING INFORMATIONS COLETED INTO DATABASE 2
            Console.WriteLine(StartConection(@"C:\ERP_TRONSOFT\ERP_TRONSOFT4.FDB"));
            FbCommand com2 = new FbCommand();
            com2.Connection = fbcon;
            Console.WriteLine("Inserindo CLASSE_ITEMCARDAPIO...");

            Int32 count;
            //COMPARE CLASS_ITEMCARDAPIO BETWEEN TWO TABLES
            foreach (List<string> row in clsinforows)
            {
                com2.CommandText = "SELECT * FROM CLASSE_ITEMCARDAPIO WHERE CD_CLASSEITEMCARDAPIO = " + row[0];
                count = Convert.ToInt32(com2.ExecuteScalar());
                if (count == 0)
                {
                    com2.CommandText = "INSERT INTO CLASSE_ITEMCARDAPIO (CD_CLASSEITEMCARDAPIO, DS_CLASSEITEMCARDAPIO, CD_EMPRESA) VALUES(" + row[0] + ", '" + row[1] + "', " + row[2] + ")";
                    com2.ExecuteNonQuery();
                }
            }

            //INSERT TO ITEM_CARDAPIO
            SQLCrazyInsert(Rows, colums_name, com2, "ITEM_CARDAPIO");

            Console.ReadKey();
        }
    }
}
