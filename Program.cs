using System;

namespace Sistema_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [2];
            float[] preco = new float [2];
            bool [] promocao = new bool [2];


            Console.WriteLine("----------------------------");
            Console.WriteLine("--Menu sistema de produtos--");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("[1] Cadastrar produtos");
            Console.WriteLine("[2] Listar produtos");
            Console.WriteLine("[3] Sair");
            string opcao = Console.ReadLine();

            
            switch(opcao){
                case "1":
                        int contador = 0;
                        while(contador<2){
                            if( contador<2 ){
                            Console.WriteLine($"Digite o nome do {contador + 1}º produto");
                            nomes [contador] = Console.ReadLine();
                            Console.WriteLine($"Digite o preço do {contador +1}º produto");
                            preco [contador] = float.Parse(Console.ReadLine());
                            Console.WriteLine($"Digite o se o {contador +1}º produto tem desconto (true/false)");
                            promocao [contador] = bool.Parse(Console.ReadLine());

                            contador++;
                            }
                            else{
                            }
                        }
                            Console.WriteLine("Limite de produtos a cadastrar atingido");
                    break;
                
                case "2":
                    for(var i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"{i + 1}º Produto. Nome {nomes[i]}. Preço {preco[i]}. Está na promoção? {promocao}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Obrigado, volte sempre!");
                    break;
            }
        }
    }
}
