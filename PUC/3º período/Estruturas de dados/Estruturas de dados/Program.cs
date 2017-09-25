using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estruturas_de_dados.Estrutura_Base;
using Estruturas_de_dados.Lista_Tipos;
namespace Estruturas_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testando Lista Encadeada.
            Lista simples = new Encadeada();
            simples.Add(new Generico("teste1"));
            simples.Add(new Generico("teste2"));
            simples.Add(new Generico("teste3"));
            simples.Add(new Generico("teste4"));
            Dados rem = new Generico("teste3");
            simples.Remover(rem);

            //Testando Lista Circular
            Lista circular = new Circular();
            simples.Add(new Generico("teste1"));
            simples.Add(new Generico("teste2"));
            simples.Add(new Generico("teste3"));
            simples.Add(new Generico("teste4"));
            Dados rem2 = new Generico("teste4");
            simples.Remover(rem);

            //Testando Lista duplamente encadeada
            Lista dupla = new Duplamente_Encadeada();
            dupla.Add(new Generico("teste1"));
            dupla.Add(new Generico("teste2"));
            dupla.Add(new Generico("teste3"));
            dupla.Add(new Generico("teste4"));
            Dados rem3 = new Generico("teste4");
            Console.ReadLine();
        }
    }
}
