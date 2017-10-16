using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Arquitetura45
{
    class ServiceDados
    {
        string nome;
        string display_nome;
        string status;
        string descrição;

        public string Nome { get => nome; }
        public string Display_nome { get => display_nome; }
        public string Status { get => status;  }
        public string Descrição { get => descrição; }

        public ServiceDados(string n, string d, string s, string des)
        {
            this.nome = n;
            this.display_nome = d;
            this.status = s;
            this.descrição = des;
        }


    }
}
