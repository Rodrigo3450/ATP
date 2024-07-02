using System.Text;

namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {
                    Console.Clear();
                    menu();
                }
            }

        }
        public static void menu()
        {
            int escolhaMenu = 0;
            bool inicio = true;
            string[,] vendasMes = new string[0, 0];
            do
            {
                Console.WriteLine("\nEscolha uma opção do menu: ");
                Console.WriteLine(@"
                    ----------------------- MENU -----------------------
                    1 - Importar arquivo de produtos
                    2 - Registrar venda
                    3 - Relatório de venda
                    4 - Relatório de estoque
                    5 - Criar arquivo de vendas
                    6 - Sair
                    ----------------------- MENU -----------------------");
                Console.WriteLine();
                escolhaMenu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolhaMenu)
                {
                    case 1:
                        importarArquivo();
                        break;
                    case 2:
                        vendasMes = registrarVenda(vendasMes, inicio);
                        relatorioVenda(vendasMes);
                        inicio = false;
                        break;
                    case 3:
                        relatorioVenda(vendasMes);
                        break;
                    case 4:
                        relatorioEstoque();
                        break;
                    case 5:
                        criarArquivoVendas(vendasMes);
                        break;
                    case 6:
                        sair();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção não encontrada. Digite novamente. ");
                        menu();
                        break;
                }
                Console.WriteLine("\n\nPrescione qlqr tecla para voltar ao menu");
                Console.ReadKey();


                Console.Clear();
            } while (escolhaMenu != 6);
        }
        private static void criarArquivoVendas(string[,] vendasMes)
        {
            string cabecalho;
            string diaMes;
            string dadosVendas;
            int linhas = 31;
            int colunas = defineQuantidadeLinhas();

            if (vendasMes.Length == 0)
            {
                Console.WriteLine("Registro nao encontrado, faça uma venda para gerarmos um relatório");
            }
            else
            {
                StreamWriter docVendas = new StreamWriter("RelatorioVendas.txt");
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (i == 0)
                        {
                            cabecalho = vendasMes[i, j] + ";";
                            docVendas.Write(cabecalho);
                        }

                        else if (j == 0 && i > 0)
                        {
                            docVendas.WriteLine();
                            diaMes = vendasMes[i, j] + ";";
                            docVendas.Write(diaMes);

                        }

                        else
                        {
                            dadosVendas = vendasMes[i, j] + ";";
                            docVendas.Write(dadosVendas);
                        }
                    }
                }
                docVendas.Close();
                Console.WriteLine("Relatório gerado com sucesso. Arquivo criado");
            }
        }

        private static void relatorioVenda(string[,] registroVendas)
        {
            int diasdoMes = 31;
            int colunas = (defineQuantidadeLinhas());
            string[,] estoqueImport = relatorioEstoque();
            Console.Clear();
            if (registroVendas.Length == 0)
            {
                Console.WriteLine("Registro nao encontrado, faça uma venda para gerarmos um relatório");
            }
            else
            {
                for (int i = 0; i < diasdoMes; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            registroVendas[i, j] = "Dias";
                            Console.Write(registroVendas[i, j]);
                        }

                        else if (i == 0 && j > 0)
                        {
                            registroVendas[i, j] = estoqueImport[j, i];
                            Console.Write("\t|" + registroVendas[i, j]);
                        }

                        else if (j == 0 && i != 0)
                        {
                            if (i == 1)
                            {
                                Console.WriteLine();
                            }
                            registroVendas[i, j] = "Dia " + i;
                            Console.Write(registroVendas[i, j] + "\t|");
                        }
                        else
                        {
                            if (registroVendas[i, j] == null)
                            {
                                registroVendas[i, j] = "null";
                            }
                            Console.Write(registroVendas[i, j] + "\t|");
                            if (j == 4)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
        public static string[,] registrarVenda(string[,] vendasMes, bool inicio)
        {
            string[,] estoqueImport;
            string[,] registroVendas;
            estoqueImport = relatorioEstoque();
            int diasdoMes = 31;
            int colunas = (defineQuantidadeLinhas());


            if (inicio == true)
            {
                registroVendas = new string[diasdoMes, colunas];
            }
            else
            {
                registroVendas = vendasMes;
            }
            int mouse = int.Parse(estoqueImport[1, 1]);
            int teclado = int.Parse(estoqueImport[2, 1]);
            int microfone = int.Parse(estoqueImport[3, 1]);
            int headset = int.Parse(estoqueImport[4, 1]);
            Console.Clear();

            string Concluido;
            int posicaoJ;
            int quantidade;
            do
            {
                Console.WriteLine("Insira o dia da venda");
                int dia = int.Parse(Console.ReadLine());
                Console.WriteLine("\nQual foi o produto vendido: ");
                Console.WriteLine(@"
                    ----------------------- PRODUTOS -----------------------
                    1 - Mouse
                    2 - Teclado
                    3 - Microfone
                    4 - Headset
                    ----------------------- PRODUTOS -----------------------");
                int produto = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (produto)
                {
                    case 1:
                        posicaoJ = 1;
                        Console.WriteLine("Insira a quantidade de mouse vendidos");

                        do
                        {
                            quantidade = int.Parse(Console.ReadLine());
                            if (quantidade > mouse) {
                            Console.WriteLine("Opa apenas " + mouse + " Disponiveis.\nInsira outra quantidade");
                            Console.WriteLine("Insira a quantidade de mouse vendidos");
                            }
                        } while (quantidade > mouse);
                        registroVendas[dia, posicaoJ] = quantidade.ToString();
                        atualizarestoque(estoqueImport, quantidade, produto);

                        break;
                    case 2:
                        posicaoJ = 2;
                        Console.WriteLine("Insira a quantidade de teclados vendidos");
                        
                        do
                        {
                            quantidade = int.Parse(Console.ReadLine());
                            if (quantidade > teclado)
                            {
                                Console.WriteLine("Opa apenas " + teclado + " Disponiveis.\nInsira outra quantidade");
                                Console.WriteLine("Insira a quantidade de teclados vendidos");
                            }
                            
                        } while (quantidade > teclado);
                        registroVendas[dia, posicaoJ] = quantidade.ToString();
                        atualizarestoque(estoqueImport, quantidade, produto);
                        break;
                    case 3:
                        posicaoJ = 3;
                        Console.WriteLine("Insira a quantidade de microfone vendidos");
                        
                        do
                        {
                            quantidade = int.Parse(Console.ReadLine());
                            if (quantidade > microfone)
                            {
                                Console.WriteLine("Opa apenas " + microfone + " Disponiveis.\nInsira outra quantidade");
                                Console.WriteLine("Insira a quantidade de microfones vendidos");
                            }
                        } while (quantidade > microfone);
                        registroVendas[dia, posicaoJ] = quantidade.ToString();
                        atualizarestoque(estoqueImport, quantidade, produto);
                        break;
                    case 4:
                        posicaoJ = 4;
                        Console.WriteLine("Insira a quantidade de headset vendidos");
                        
                        do
                        {
                            quantidade = int.Parse(Console.ReadLine());
                            if (quantidade > headset)
                            {
                                Console.WriteLine("Opa apenas " + headset + " Disponiveis.\nInsira outra quantidade");
                                Console.WriteLine("Insira a quantidade de headsets vendidos");
                            }
                        } while (quantidade > headset);
                        registroVendas[dia, posicaoJ] = quantidade.ToString();
                        atualizarestoque(estoqueImport, quantidade, produto);
                        break;
                }
                Console.WriteLine("Y/N Adicionar novo produto");
                Concluido = Console.ReadLine();
            } while (Concluido != "N");
            Console.WriteLine("\nVendas registradas com sucesso");
            return registroVendas;
        }

        public static string[,] atualizarestoque(string[,] estoqueImport, int quantidade, int produto)
        {
            string[,] estoqueAtualizado = estoqueImport;
            int qtdAtual = int.Parse(estoqueAtualizado[produto, 1]);
            int qtdAtuallizada = qtdAtual - quantidade;
            estoqueAtualizado[produto, 1] = qtdAtuallizada.ToString();
            atualizaArquivoEstoque(estoqueImport);
            return estoqueAtualizado;
        }

        public static void atualizaArquivoEstoque(string[,] estoqueImport)
        {
            string cabecalho;
            string produtos;
            string qtdprodutos;
            int linhas = defineQuantidadeLinhas();
            int colunas = defineQuantidadeColunas();

            StreamWriter sr = new StreamWriter("estoque.txt");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            cabecalho = estoqueImport[i, j] + ";";

                        }
                        else
                        {
                            cabecalho = estoqueImport[i, j];
                        }
                        sr.Write(cabecalho);
                    }

                    else if (j == 0 && i > 0)
                    {
                        sr.WriteLine();
                        produtos = estoqueImport[i, j] + ";";
                        sr.Write(produtos);

                    }

                    else
                    {
                        qtdprodutos = estoqueImport[i, j];
                        sr.Write(qtdprodutos);
                    }
                }
            }
            sr.Close();
            Console.WriteLine("estoque atualizado com sucesso");
        }

        static void sair()
        {
            Console.Clear();
            Console.WriteLine("saiu");
        }

        public static string[,] importarArquivo()
        {
            int linhas = defineQuantidadeLinhas();
            int colunas = defineQuantidadeColunas();
            string[,] estoque = new string[linhas, colunas];
            StreamReader sr = new StreamReader("estoque.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (line == null)
                        {
                            i = linhas;
                            j = colunas;
                        }
                        else
                        {
                            string[] sub = line.Split(';');
                            estoque[i, j] = sub[j];
                        }
                    }
                    line = sr.ReadLine();
                }
            }
            Console.WriteLine("Arquivo importado com sucesso");
            sr.Close();
            return estoque;
        }
        private static int defineQuantidadeColunas()
        {
            int cont = 0;
            StreamReader sr = new StreamReader("estoque.txt");
            string line = sr.ReadLine();
            string[] colunas = line.Split(';');
            int tam = colunas.Length;
            sr.Close();
            return tam;
        }

        private static int defineQuantidadeLinhas()
        {
            int cont = 0;
            StreamReader sr = new StreamReader("estoque.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                cont++;
                line = sr.ReadLine();
            }
            sr.Close();
            return cont;
        }
        public static string[,] relatorioEstoque()
        {
            string[,] estoqueImport = importarArquivo();
            int linhas = defineQuantidadeLinhas();
            int colunas = defineQuantidadeColunas();
            Console.WriteLine("PRODUTOS");
            Console.WriteLine("Conteúdo\t    Quantidade");
            {
                for (int i = 1; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        Console.Write(estoqueImport[i, j] + "\t\t\t");
                    }
                    Console.WriteLine();
                }
            }
            return estoqueImport;
        }


    }
}