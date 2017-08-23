/// <summary>
/// Para as duas variáveis presentes nesta classe, CUIDADO.O encapsulamento delas foi gerado por um vs17
/// logo, versões anteriores podem apresentar erro quando à linha do encapsulamento.
/// lin 19,20
/// </summary>
namespace BulletWorld.Class
{
    public class Player
    {
        private string name;
        private int points;

        public string Name { get => name; }
        public int Points { get => points; }
        /// <summary>
        /// Construtor para quando o usuário criar um novo player
        /// </summary>
        /// <param name="n"></param>
        public Player(string n)
        {
            if (DataBase.CheckUserExists(n) == false)
            {
                this.name = n;
                this.points = 0;
                NewPlayer(this.name);
            }
            else
            {
                this.name = "";
                this.points = -1;
            }
        }
        /// <summary>
        /// Construtor para quando o xml DataBase for lido
        /// </summary>
        /// <param name="n">Nome do jogador</param>
        /// <param name="p">Pontuação do mesmo</param>
        public Player(string n, int p)
        {
            this.name = n;
            this.points = p;
        }
        /// <summary>
        /// Cria um novo jogador. Se não houver um com o mesmo nome, ele será criado.
        /// </summary>
        /// <param name="nome">Nome do novo jogador</param>
        private void NewPlayer(string nome)
        {
            DataBase.AddUser(nome);
        }
        /// <summary>
        /// Envia a ordem de deletar para o DataBase
        /// </summary>
        /// <param name="name">Nome do usuário a ser deletado</param>
        public static void Delete(string name)
        {
            DataBase.Remove(name);
        }
    }
}
