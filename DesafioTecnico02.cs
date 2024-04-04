using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico02
{
    class Program
    {
        static void Main(string[] args){
            while (true)
            {
                Console.WriteLine("digite 1 para breve apresentação do personagem 2 para apresentacao da entidade 3 para entender a interação do personagem com a entidade e 4 para doar");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Arthur Cervero, agente esperiente da Ordem, a caminho de ocupar o cargo senhor verissimo ps: ele adora gatinhos");
                        break;

                    case 2:
                        Console.WriteLine("Ordo Realitas, uma organização que alem de trabalhar arduamente para que a realidade prevaleça, tambem financia ongs que ajudam animais de rua  ");
                        break;

                    case 3:
                        Console.WriteLine("Alem de ser o braço direito do atual senhor Verissimo, Arthur foi quem insentivou essa iniciativa da Ordem e ajuda na gestão desta area ");
                        break;
                    case 4:
                          for (int dia = 0; dia <= 1; dia++)
                            {
                                Console.WriteLine("insira um valor de doacao abaixo ");
                                int doacao = int.Parse(Console.ReadLine());

                                if (doacao <= 50)
                                {
                                    Console.WriteLine("obrigado pela doação");
                                }
                                else
                                {
                                    Console.WriteLine("obrigado pela doação, foi uma otima doação");
                                }
                                int contador;
                                do
                                {
                                 Console.WriteLine("precisamos de mais doações para alcansar a meta");
                                  contador = doacao;
                                } while (contador == 0);

                            }
                        break;
                      }
                
               }       
            }
        }
    }

