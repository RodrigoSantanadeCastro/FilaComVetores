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

        protected string[] prioritario = new string[11];
        public string[] Prioritario
        {
            get { return prioritario; }
            set { prioritario = value; }
        }


        public void CadastrarFila()
        {

            
                for (int i = 0; i <= 10; i++)
                {
                    if (this.Nome[i] == null && this.Idade[i] == 0)
                    {
                        Console.WriteLine("Digite  o nome do paciente ");
                        string name = Console.ReadLine();

                        this.Nome[i] = name;

                        Console.WriteLine("Qual é a idade do paciente ?");
                        int idade = int.Parse(Console.ReadLine());

                        this.Idade[i] = idade;


                        Console.WriteLine("O paciente :" + this.Nome[i] + " de " + this.Idade[i] + " anos, foi cadastrado com sucesso");
                        break;

                    }else { }
                }
            

        }


        public void colocarFila()
        {

            Console.WriteLine("Qual o nome do paciente que você deseja colocar na fila de atendimento ?");
            string nomefila = Console.ReadLine();

            Console.WriteLine("Paciente é prioritario ?");
            Console.WriteLine("s-Para sim ?");
            Console.WriteLine("n-Para não ?");
            string prio = Console.ReadLine();

            if (prio == "s") {
                for (int j = 0; j <= 10; j++)
                {
                    if (this.Prioritario[j] == null)
                    {
                        this.Prioritario[j] = nomefila;
                        break;
                    }
                    else { }
                }
            }
            else
            {
                for (int k = 0; k <= 10; k++)
                {
                    if (this.Posicao[k] == null)
                    {
                        this.Posicao[k] = nomefila;
                        break;
                    }
                    else { }
                }

            }

        }

        public void mostrarFila()
        {
            
                
                    for(int y = 0; y <= 10; y++) 
                    {
                        if (this.Prioritario[y] == null)
                        {
                            Console.WriteLine("Paciente numero " + y + this.Posicao[y]);
                        }else 
                        {
                            Console.WriteLine("Paciente numero " + y + this.Prioritario[y] + " Da fila prioritaria");
                        }
                    }
                    
                
               

            
        }

        public void atenderFila() 
        {
            if (this.Prioritario[0] == null)
            {
                Console.WriteLine("Paciente "+ this.Posicao[0] +" será atendido agora.");
                Console.WriteLine("Paciente " + this.Posicao[0] + " atendido.");

                this.Posicao[0] = "";
                
                for (int y = 0;y <= 9;y++)
                {
                    int m = y + 1;
                    this.Posicao[y] = this.Posicao[m];
                    this.Posicao[m] = "";
                    
                }
            }
            else {
                Console.WriteLine("Paciente " + this.Prioritario[0] + " será atendido agora.");
                Console.WriteLine("Paciente " + this.Prioritario[0] + " atendido.");

                this.Prioritario[0] = "";

                for (int y = 0; y <= 9; y++)
                {
                    int m = y + 1;
                    this.Prioritario[y] = this.Prioritario[m];
                    this.Prioritario[m] = "";

                }
            }
        }

        
    }
}
