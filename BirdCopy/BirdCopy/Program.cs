using System;
using System.Collections.Generic;
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

        static void SQLCrazyInsert(List<List<string>> Rows, List<string> colums_name, string tableto)
        {
            FbCommand fbgo = new FbCommand();
            fbgo.Connection = fbcon;
            int result;
            foreach (List<string> r in Rows)
            {
                fbgo.CommandText = "SELECT * FROM "+ tableto + " WHERE " + colums_name[0] + " = " + r[0];
                result = Convert.ToInt32(fbgo.ExecuteScalar());
                if (result == 0)
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
                    bool isnumeric;
                    double number2;
                    for (int ind = 0; ind < r.Count; ind++) //SETTING VALUES
                    {
                        if (r[ind] == "")
                        {
                            command += "null";
                        }
                        else if ((isnumeric = double.TryParse(r[ind], out number2)) == true) //if variable isn't a number
                        {
                            command += r[ind].Replace(',', '.');
                        }
                        else
                        {

                            command += "'" + r[ind] + "'";
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
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("COD->" + r[0] +" ja inserido no banco.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "BRILL";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=================Mafra LSGM Firebird Copy Tool v1=================");
            Console.WriteLine(@"Caminho do primeiro banco: C:\ERP_TRONSOFT\ERP_TRONSOFT.FDB ");
            string pathfull = @"C:\ERP_TRONSOFT\ERP_TRONSOFT.FDB";
            Console.WriteLine(StartConection(pathfull));

            FbCommand com = new FbCommand();
            com.Connection = fbcon;
            com.CommandText = "SELECT * FROM ITEM_CARDAPIO ORDER BY CD_ITEMCARDAPIO ASC";
            FbDataReader getdata1 = com.ExecuteReader();

            Console.Write("\nColetando os valores inseridos...  ");
            List<List<string>> Rows;
            Rows = GET_TABLEROWS(getdata1);

            //GETTING COMPANY NAME
            Console.WriteLine("Verificando nome do banco...");
            FbCommand empcomm = new FbCommand();
            empcomm.Connection = fbcon;
            empcomm.CommandText = "SELECT * FROM EMPRESA";
            FbDataReader empreturn = empcomm.ExecuteReader();
            List<string> empcol = GET_TABLECOLUMNSNAME(empreturn);
            List<List<string>> emprow = GET_TABLEROWS(empreturn);

            string comp_name = "";
            foreach(List<string> get in emprow)
            {
                comp_name = get[1];
            }

            //GETTING CLASS DATA INFORMATION;
            Console.WriteLine("Coletando informações de CLASSE_ITEMCARDAPIO...");
            com.CommandText = "SELECT * FROM CLASSE_ITEMCARDAPIO";
            getdata1 = com.ExecuteReader();
            List<string> clsinfo = GET_TABLECOLUMNSNAME(getdata1);
            List<List<string>> clsinforows = GET_TABLEROWS(getdata1);
            Console.Write("OK\n");

            //GETTING DATA FROM ITEM_CARDAPIO   
            Console.WriteLine("Coletando informações da tabela ITEM_CARDAPIO");
            FbCommand getall = new FbCommand();
            getall.Connection = fbcon;
            getall.CommandText = "SELECT * FROM ITEM_CARDAPIO";
            FbDataReader cadinfo = getall.ExecuteReader();
            List<string> cardcol = GET_TABLECOLUMNSNAME(cadinfo);
            List<List<string>> cardrow = GET_TABLEROWS(cadinfo);
            Console.Write("OK\n");

            //COLUMN THAT WILL BE IGNORED
            cardcol.Remove("CEST");
            foreach (List<string> secondlist in cardrow)
            {
                secondlist.RemoveAt(secondlist.Count - 1);
            }

            //GETTING DATA FROM UNIDADE   
            Console.WriteLine("Coletando informações da tabela UNIDADE...");
            FbCommand unitall = new FbCommand();
            unitall.Connection = fbcon;
            unitall.CommandText = "SELECT * FROM UNIDADE";
            FbDataReader unitinfo = unitall.ExecuteReader();
            List<string> unitcols = GET_TABLECOLUMNSNAME(unitinfo);
            List<List<string>> unitrows = GET_TABLEROWS(unitinfo);
            Console.Write("OK\n");

            //GETTING DATA FROM SITUAÇÃ0_TRIBUTARIA
            Console.WriteLine("Coletando informações da tabela SITUACAO_TRIBUTARIA...");
            FbCommand xgettribut = new FbCommand();
            xgettribut.Connection = fbcon;
            xgettribut.CommandText = "SELECT * FROM SITUACAO_TRIBUTARIA";
            FbDataReader xtribut = xgettribut.ExecuteReader();
            List<string> xtributcol = GET_TABLECOLUMNSNAME(xtribut);
            List<List<string>> xtributrows = GET_TABLEROWS(xtribut);
            Console.Write("OK\n");

            //GETTING DATA FROM ITEM_CARDAPIOXEMPRESA
            Console.WriteLine("Coletando informações da tabela ITEM_CARDAPIOXEMPRESA...");
            FbCommand xget = new FbCommand();
            xget.Connection = fbcon;
            xget.CommandText = "SELECT * FROM ITEM_CARDAPIOXEMPRESA";
            FbDataReader Xresult = xget.ExecuteReader();
            List<string> xcolums = GET_TABLECOLUMNSNAME(Xresult);
            List<List<string>> xrows = GET_TABLEROWS(Xresult);
            Console.Write("OK\n");

            xtributcol.Remove("CD_NATOP_VENDA_CONSUMIDOR");
            foreach (List<string> secondlist in xtributrows)
            {
                secondlist.RemoveAt(secondlist.Count - 1);
            }

            //GETTING DATA FROM IMPRESSORA_PEDIDOS
            Console.WriteLine("Coletando informações da tabela IMPRESSORA_PEDIDOS...");
            FbCommand impget = new FbCommand();
            impget.Connection = fbcon;
            impget.CommandText = "SELECT * FROM IMPRESSORA_PEDIDOS";
            FbDataReader impresult = impget.ExecuteReader();
            List<string> impcoluns = GET_TABLECOLUMNSNAME(impresult);
            List<List<string>> improws = GET_TABLEROWS(impresult);
            Console.Write("OK\n");
            Console.WriteLine("Fechando conexão com o primeiro banco...");
            fbcon.Close();
            Console.Write("OK\n");

            Console.WriteLine("Conectando ao segundo banco...");

            //INSERTING INFORMATIONS COLETED INTO DATABASE 2
            Console.WriteLine(@"Caminho do segundo banco de dados: C:\ERP_TRONSOFT\ERP_TRONSOFT4.FDB");
            Console.WriteLine(StartConection(@"C:\ERP_TRONSOFT\ERP_TRONSOFT4.FDB"));
            FbCommand com2 = new FbCommand();
            com2.Connection = fbcon;

            Console.WriteLine("Alterando nome do banco...");
            FbCommand update = new FbCommand();
            update.Connection = fbcon;
            update.CommandText = "Update EMPRESA set DS_EMPRESA = '" + comp_name + "' where CD_EMPRESA = 1";
            update.ExecuteNonQuery();
            Console.WriteLine("Nome do banco alterado para: " + comp_name);
            Console.WriteLine("");

            Console.WriteLine("Inserindo IMPRESSORA_PEDIDOS...");
            SQLCrazyInsert(improws, impcoluns, "IMPRESSORA_PEDIDOS");
            Console.WriteLine("");

            Console.WriteLine("Inserindo SITUACAO_TRIBUTARIA...");
            SQLCrazyInsert(xtributrows, xtributcol, "SITUACAO_TRIBUTARIA");
            Console.WriteLine("");

            Console.WriteLine("Inserindo UNIDADE...");
            SQLCrazyInsert(unitrows, unitcols, "UNIDADE");
            Console.WriteLine("");

            Console.WriteLine("Inserindo CLASSE_ITEMCARDAPIO...");
            SQLCrazyInsert(clsinforows, clsinfo, "CLASSE_ITEMCARDAPIO");
            Console.WriteLine("");

            Console.WriteLine("Inserindo ITEM_CARDAPIO...");
            SQLCrazyInsert(cardrow, cardcol, "ITEM_CARDAPIO");
            Console.WriteLine("");

            Console.WriteLine("\nInserindo ITEM_CARDAPIOXEMRPESA...");
            SQLCrazyInsert(xrows, xcolums, "ITEM_CARDAPIOXEMPRESA");
            Console.WriteLine("");
            Console.WriteLine("Processo finalizado. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
