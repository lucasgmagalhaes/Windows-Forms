using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace BulletWorld.Class
{
    /// <summary>
    /// A primeira variável que compões esta classe é a de users. no primeiro load, ela carrega todas as informações sobre 
    /// usuários do XML, criando objs para a classe Player consequentimente. 
    /// Em uma segunda chamada do método LoadUsersData por ex, a classe não precisará carregar novamente do XML, em função da varíável
    /// estática 'users'. Porém, ela só não irá carregar novamente, SE não foi adicionado, removido ou alterado algum dado de usuário
    /// ou ele próprio.
    /// 
    /// A ultilização da variável 'reload' serve justamente para realizar o acompanhamento dos eventos q causam o recarregamento do XML
    /// Como é de se supor, quando 'reload' é atribuita como true, é necessário recarregar todos os dados do XML, quando false, é retor
    /// nado os dados do 'users' ou algo mais filtrado. Tal questão vai depender do método chamado
    /// 
    /// O motivo pelo qual o a linha 'file = XDocument.Load("Data.xml");' é constantemente chamada em todos os métodos é o de que, 
    /// ao ser carregado quando a classe é solicitada pela primeira vez, o XDocument.Load() pega o arquivo XML completo e envia-o 
    /// para a memória. Considere isso como um Ctrl+c Ctrl+v. Dessa forma, se um usuário é adicionado, por exemplo, quando o 
    /// LoadUsersData() ler novamente o arquivo xml, ele não está realmente lendo o arquivo XML que vc vê na sua pasta, ou seja:
    /// o arquivo que está na pasta ao contrário, ele recarrega o arquivo ja salvo na memória, e este não possui o novo usuário 
    /// cadastrado. Concluindo, o arquivo XML deve sempre ser recarregado, quando ouver alguma alteração
    /// </summary>
    public static class DataBase
    {
        private static List<Player> users = new List<Player>(); //Lista geral de jogadores
        private static List<Player> bullet = new List<Player>(); // Lista com os usuários que jogaram com o bulletbill
        private static List<Player> cheep = new List<Player>(); // Lista com os usuários que jogaram com o cheepcheep
        private static List<Player> crazy = new List<Player>(); // Lista com os usuários que jogaram com o crazyblooper
        private static List<Player> mario = new List<Player>(); // Lista com os usuários que jogaram com o LeftMario
        private static XDocument file;
        private static bool reload = true;
        private static string backupusername;
        /// <summary>
        /// Caso o arquivo contendo as informações dos usuários seja deletado, o sistema gera um arquivo novo em branco.
        /// </summary>
        public static void CreateXML()
        {
            using (StreamWriter xmlpad = new StreamWriter("Data.xml", true, Encoding.UTF8))
            {
                string text = (@"<?xml version=""1.0"" encoding=""utf-8""?> \n" +
                                " <World>\n" +
                                 "  <!--CADASTRO DOS JOGADORES E REGISTRO DE PONTUAÇÃO-->\n" +
                                 "  <!--Cada player tem um nome e uma pontuação.-->\n" +
                                 "  <!--O personagem com quem esse player jogou não é relevante nessa Coluna-->\n" +
                                 "  <users>\n" +
                                 @"   <PlayerInfo name = ""Guest"" points = ""0""/>\n" +
                                 "  </users>\n" +
                                 "  <!--RANKING DEFINIDO POR CADA PERSONAGEM-->\n" +
                                 "  <!--Assim que cada personagem for jogado por um player, seu nome será salvo junto com a sua pontuação-->\n" +
                                 "  <!--na Coluna referente ao personagem-->\n" +
                                 "  <Characters>\n" +
                                 "  <BulletBill>\n" +
                                 @"   <player  name = """" points = "" ""/>\n" +
                                 "  </BulletBill>\n" +
                                 "  <CheepCheep>\n" +
                                 @"   <player  name = """" points = "" ""/>\n" +
                                 "  </CheepCheep>\n" +
                                 "  <CrazyBlooper>\n" +
                                 @"   <player  name = """" points = "" ""/>\n" +
                                 "  </CrazyBlooper>\n" +
                                 "  <LeftMario>\n" +
                                 @"   <player  name = """" points = "" ""/>\n" +
                                 "  </LeftMario>\n" +
                                 "  </Characters>\n" +
                                 "</World>");
                text = text.Replace(@"\n", Environment.NewLine);
                xmlpad.Write(text);
                xmlpad.Close();
            }
        }
        #region LOADS
        /// <summary>
        /// Carrega todas as informações do arquivo retornando um List de players
        /// </summary>
        /// <returns></returns>
        public static List<Player> LoadUsersData()
        {
            try
            {
                if (reload == true)
                {
                    file = XDocument.Load("Data.xml");
                    users = new List<Player>();
                    foreach (var results in file.Descendants("PlayerInfo"))
                    {
                        users.Add(new Player(results.Attribute("name").Value, Convert.ToInt32(results.Attribute("points").Value)));
                    }
                    reload = false;
                }
                users = users.OrderByDescending(i => i.Points).ToList();
            }
            catch
            {
                CreateXML();
                LoadUsersData();
            }
            return users;
        }
        /// <summary>
        /// Carrega os jogadores e suas respectivas pontuações com o BulletBill
        /// </summary>
        /// <returns></returns>
        public static List<Player> LoadBulletBillData()
        {
            if (reload == true)
            {
                file = XDocument.Load("Data.xml");

                foreach (var results in file.Descendants("BulletBill"))
                {
                    bullet.Add(new Player(results.Element("player").Attribute("name").Value,
                    Convert.ToInt32(results.Element("player").Attribute("points").Value)));
                }
                reload = false;
            }
            return bullet;
        }
        /// <summary>
        /// Carrega os jogadores e suas respectivas pontuações com o CheepCheep
        /// </summary>
        /// <returns></returns>
        public static List<Player> LoadChepData()
        {
            if (reload == true)
            {
                file = XDocument.Load("Data.xml");

                foreach (var results in file.Descendants("CheepCheep"))
                {
                    cheep.Add(new Player(results.Element("player").Attribute("name").Value,
                    Convert.ToInt32(results.Element("player").Attribute("points").Value)));
                }
                reload = false;
            }
            return bullet;
        }
        /// <summary>
        /// Carrega os jogadores e suas respectivas pontuações com o CrazyBlooper
        /// </summary>
        /// <returns></returns>
        public static List<Player> LoadCrazyData()
        {
            if (reload == true)
            {
                file = XDocument.Load("Data.xml");

                foreach (var results in file.Descendants("CrazyBlooper"))
                {
                    crazy.Add(new Player(results.Element("player").Attribute("name").Value,
                    Convert.ToInt32(results.Element("player").Attribute("points").Value)));
                }
                reload = false;
            }
            return bullet;
        }
        /// <summary>
        /// Carrega os jogadores e suas respectivas pontuações com o LeftMario
        /// </summary>
        /// <returns></returns>
        public static List<Player> LoadLeftData()
        {
            if (reload == true)
            {
                file = XDocument.Load("Data.xml");

                foreach (var results in file.Descendants("LeftMario"))
                {
                    mario.Add(new Player(results.Element("player").Attribute("name").Value,
                    Convert.ToInt32(results.Element("player").Attribute("points").Value)));
                }
                reload = false;
            }
            return bullet;
        }
        /// <summary>
        /// Carrega apenas o nome dos jogadores, e retorna um List disso
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadUsersName()
        {
            List<string> playersname = new List<string>();
            try
            {
                if (reload == true)
                {
                    file = XDocument.Load("Data.xml");

                    foreach (var results in file.Descendants("PlayerInfo"))
                    {
                        playersname.Add(results.Attribute("name").Value);
                    }
                    reload = false;
                }
                else
                {
                    foreach (var pessoas in users)
                    {
                        playersname.Add(pessoas.Name);
                    }
                }
                return playersname;
            }
            catch
            {
                CreateXML();
                return LoadUsersName();
            }
        }
        #endregion
        /// <summary>
        /// Verifica se já existe um jogador com o nome fornecido
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool CheckUserExists(string name)
        {
            if (users.Count() == 0)
            {
                file = XDocument.Load("Data.xml");

                foreach (var infos in file.Descendants("PlayerInfo"))
                {
                    if (name == infos.Attribute("name").Value) return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Insere um novo usuário no arquivo, não é necessário criar um novo obj dele, em vista de que, assim que esse usuário é ca-
        /// dastrado, o LoadUsers() irá recarregar o arquivo.
        /// </summary>
        /// <param name="nome"></param>
        public static void AddUser(string nome)
        {
            backupusername = nome; // Caso haja algum problema no arquivo, é feito um "backup" do nome do usuario, criado um novo arquivo e o sistema tenta novamente criar o arquivo;
            try
            {
                XDocument xml = XDocument.Load("Data.xml");
                xml.Root.Element("users").Add(new XElement("PlayerInfo",
                     new XAttribute("name", nome),
                     new XAttribute("points", 0)));
                xml.Save("Data.xml");
                reload = true;
            }
            catch
            {
                CreateXML();
                AddUser(backupusername);
            }
        }
        /// <summary>
        /// Remove o usuário do arquivo XML
        /// </summary>
        /// <param name="name"></param>
        public static void Remove(string name)
        {
            try // Neste caso, se houver qualquer problema no arquivo de dados dos usuários, o sistema apenas cria um novo arquivo
            {
                file = XDocument.Load("Data.xml");
                //remove o jogador da lista local
                if (users.Count > 1)
                {
                    foreach (Player pl in users)
                    {
                        if (pl.Name == name)
                        {
                            users.Remove(pl);
                            break;
                        }
                    }
                    //remove o jogador do XML
                    foreach (var results in file.Descendants("PlayerInfo"))
                    {
                        if (results.Attribute("name").Value == name)
                        {
                            results.Remove();
                            break;
                        }
                    }
                }
                reload = true;
                file.Save("Data.xml");
            }
            catch
            {
                CreateXML();
            }
        }
        /// <summary>
        /// Salva a pontuação do jogador
        /// </summary>
        /// <param name="pl"></param>
        public static void SaveChanges(Player pl)
        {
            //será preenchida
        }
    }
}
