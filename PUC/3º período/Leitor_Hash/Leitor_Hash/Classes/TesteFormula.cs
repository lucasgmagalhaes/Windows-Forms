using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Hash.Classes
{
    class TesteFormula<T>
    {
        private int colisoes = 0;
        private int sucessos = 0;
        private List<T> dado;
        public void Inserir(T info)
        {
            dado.Add(info);
            if (CheckColision(info)) colisoes++;
            else sucessos++;
        }
        public bool CheckColision(T info)
        {
            foreach (T inf in dado) if (info.Equals(inf)) return true;
            return false;
        }

        public int YourMethod(Func<int,int> function)
        {
            return 1;
        }
    }
}
