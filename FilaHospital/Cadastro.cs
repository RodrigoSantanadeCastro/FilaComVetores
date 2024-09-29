using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaHospital
{
    internal class Cadastro
    {

        protected string[] nome = new string[11]; 
        public string [] Nome 
        {
            get { return nome; }
            set { nome = value; }
        }
        protected int[] idade = new int[11];
        public int [] Idade
        { 
            get { return idade; }
            set {  idade = value; } 
        }

        protected string[] posicao = new string[11];
        public string[] Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        protected string[] estado = new string[11];
        public string[] Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public void CadastrarFila()
        {
            
            
            for (int i=0 ; i <= 10; i++)
            {
                Console.WriteLine("Digite  o nome do pasciente ");
                string name = Console.ReadLine();

                this.Nome[i] = name;

                Console.WriteLine("Qual é a idade do pasciente ?");
                int idade = int.Parse(Console.ReadLine());

                this.Idade[i] = idade;


                Console.WriteLine("O pasciente :"+ this.Nome[i] + " de " + this.Idade[i]+" anos, foi cadastrado com sucesso");
                

            }

        }


        public void colocarFila()
        {

            Console.WriteLine("Qual o nome do pasciente que você deseja colocar na fila de atendimento ?");
            string nomefila = Console.ReadLine();

           for (int j=0 ;j <= 10; j++)
            {
                if (this.Posicao[j] == null)
                {
                    this.Posicao[j] = nomefila;
                    break;
                }
                else { }
            }

        }

        public void mostrarFila()
        {
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine("Pasciente numero "+x + this.Posicao[x]);

            }
        }
    }
}
