using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "0";
            Cadastro cadastro = new Cadastro();
            do
                {
                    
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("-----------Aplicativo de fila--------------");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("digite 1- para cadastrar paciente");
                    Console.WriteLine("digite 2- para colocar pacientes na fila");
                    Console.WriteLine("digite 3- para mostrar a atual fila de pacientes");
                    Console.WriteLine("digite 4- para Atender o proximo paciente da fila");
                    Console.WriteLine("digite q- para Sair");


                    op = Console.ReadLine();

                    if(op == "1" || op == "2" || op == "3" || op == "4" )
                    {
                    int opcao = Convert.ToInt32(op);
                    

                    switch (opcao)
                        {
                            case 1:
                                
                                cadastro.CadastrarFila();
                            break;
                            case 2:
                                
                                cadastro.colocarFila();
                                break;
                            case 3:

                                cadastro.mostrarFila();
                                break;
                            case 4:
                                cadastro.atenderFila();
                                break;

                        }
                     }else 
                     {
                    
                
                     }

                    
                } while (op != "q");

            
        }
    }
}
