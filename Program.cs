using System;

namespace Sistema_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            float[] preco = new float[10];
            bool[] promo = new bool[10];
            int maximo;

            while(1==1)
            {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("---Sistema-De-Produtos---");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("O que gostaria de fazer? ");
            Console.WriteLine("[0] Cadastrar um produto");
            Console.WriteLine("[1] Listar Produtos");
            Console.WriteLine("[2] Sair");
            int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                    //cadastrar um produto
                    Console.WriteLine("Quantos produtos gostaria de cadastrar?");
                    Console.WriteLine("Lembrando que só é possivel cadastrar 10 produtos por vez");
                    maximo = int.Parse(Console.ReadLine());
                    for (var i = 0; i < maximo; i++)
                    {
                        Console.WriteLine("Escreva o nome do produto:");
                        nome[i] = Console.ReadLine();
                        Console.WriteLine("Escreva o valor do produto");
                        preco[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe se o produto está em promoção");
                        Console.WriteLine("[True] ou [False]");
                        promo[i] = bool.Parse(Console.ReadLine());
                    }
                        break;

                    case 1:
                    //Listar produtos
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Aqui esta uma lista de itens cadastrados:");
                        Console.WriteLine("Nome: "+nome[i]);
                        Console.WriteLine("Preço: "+preco[i]);
                        Console.Write("Está em promoção: ");
                                
                        if (promo[i] == true)
                        {
                            Console.WriteLine("Sim");
                        }
                        else
                        {
                            Console.WriteLine("Não");
                        }
                            
                        }
                        break;

                    case 2:
                    //sair
                    Environment.Exit(1);
                        break;

                    default:
                    //erro
                        break;
                }
            }
            
            
        }
    }
}
