using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Nuget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime horasAtuias = DateTime.Now; //No json vai estar em formato padrão de horário das linguagens

            List<Dados> colecao = new List<Dados>();

            Dados dados = new Dados(150, "lápis", 2.50M, horasAtuias);
            Dados dados2 = new Dados(2, "Notebook", 2000.00M, horasAtuias);

            colecao.Add(dados);
            colecao.Add(dados2);

            string serializacaoLista = JsonConvert.SerializeObject(colecao, Formatting.Indented);

            File.WriteAllText("ListaDeDados.json", serializacaoLista);

            /*
            //VOU USAR O JSON AQUI OIA
            string serializacao = JsonConvert.SerializeObject(dados); //Serializei dados

            File.WriteAllText("teste.json", serializacao); //Ele já sabe em qual pasta criar só coloca o nome entre""
            
            Console.WriteLine(serializacao); //vai aparecer como foi escrito serializado 

            Console.ReadLine(); */
        }

        public class Dados
        {
            public Dados(int pessoas, string produto, decimal preco, DateTime horario)
            {
                QuantPessoas = pessoas;
                Produto = produto;
                Preco = preco;
                Horario = horario;
            }

            public  int QuantPessoas { get; set; }

            public string Produto { get; set; }

            public decimal Preco { get; set; }

            public DateTime Horario { get; set; }
        }
    }
}
