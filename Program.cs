using System;

namespace SistemaDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

                //Declaração de variaveis
        
            string[] descricao = new string[10];
            float[] preco = new float[10];
            
        
            Console.WriteLine("-------------------------");
            Console.WriteLine("---Sistema de Produtos/ Atividade 26-11-20---");
            Console.WriteLine("-------------------------");

            bool[] promocao = new bool[10];
            
            int contador = 0;
            int escolha;

            do
            {
             
                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("[1] - Cadastrar produtos");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[3] - Sair");
                escolha = int.Parse(Console.ReadLine());
                     
                
                 bool promocaoValida;
              
                switch(escolha)
                {
                    case 1 : 
                        string resposta;
                        do
                        {
                            if(contador < 5)
                            {
                                Console.WriteLine($"Digite o {contador+1}° produto");
                                descricao[contador] = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"Digite o preço do {contador+1}° produto");
                                preco[contador] = float.Parse(Console.ReadLine());
                                Console.WriteLine($"O {contador+1}° produto está em promoção ? Sim ou Não");
                                string promocao1 = Console.ReadLine();
                                promocaoValida = Promocao(promocao1);
                                contador++;
                            }else{
                                Console.WriteLine("fim do cadastro!");
                                break;
                            }

                            
                            Console.WriteLine("Gostaria de cadastrar um novo produto? S/N");
                            resposta = Console.ReadLine();

                        }while(resposta == "s");
                        break; 

                    

                    case 2: 

                        for (var i = 0; i <5; i++)
                        {
                        
                            Console.WriteLine($"Produto: {descricao[i]}");
                            Console.WriteLine($"Preço: {preco[i]}");
                            
                        }
                             break;
                                 case 0: 

                    break;

                    case 3: 
                        Console.WriteLine("---Saiu do sistema---");
                    break;

                    default:
                        Console.WriteLine("Opção inválida");
                    break;

                }   
                
            }while(escolha !=3);

            bool Promocao (string promocao){
                if (promocao == "Não"){
                    Console.WriteLine("não está em promoção");
                    return true;
                    }else{
                        Console.WriteLine("Está em promoção");
                        return false;
                    }
                }
            
        

                        


        }
    }
} 
