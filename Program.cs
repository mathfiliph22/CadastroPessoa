// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CadastroPessoa.Classes;

Console.WriteLine(@$"
=======================================
| Bem vindo ao sistema de cadastro de |
| Pessoas Físicas e Jurídicas         |
=======================================
");

BarraCarregamento($"Carregando  ", 500);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;
do
{
  Console.Clear();
  Console.WriteLine(@$"
  ====================================
  |  Escolha uma das opções abaixo   |                            |
  |----------------------------------|                                  |
  |           1 - Pessoa Fisica      |
  |           2 - Pessoa Jurídica    |
  |                                  |
  |           0 - Sair               |
  |===================================
   ");
  opcao = Console.ReadLine();

  switch (opcao)
   {
      case "1":PessoaFisica metodoPf = new PessoaFisica();
               

            string? opcaoPf;
            do
            {
               Console.Clear();
               Console.WriteLine(@$"
               ======================================
               |    Escolha uma das opções abaixo   |                              |
               |------------------------------------|                                    |
               |     1 - Cadastrar Pessoa Física    |
               |     2 - Mostrar Pessoas Físicas    | 
               |                                    |
               |     0 - Voltar ao menu anterior    |                               |
               ======================================


               ");

               
            opcaoPf = Console.ReadLine();

            switch (opcaoPf)
            {
               case "1":

               PessoaFisica novaPf = new PessoaFisica();
               Endereco novoEnd = new Endereco();

               
               Console.WriteLine(@$"Digite o nome da pessoa física que deseja cadastrar");
               novaPf.nome = Console.ReadLine();
               
               bool dataValida;
               do
               {
                  Console.WriteLine($"Digita a data de nascimento");
                  string dataNasc = Console.ReadLine();

                  dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                  if(dataValida)
                  {
                     novaPf.dataNascimento = dataNasc;
                  }else
                  {
                     Console.ForegroundColor = ConsoleColor.DarkRed;
                     Console.WriteLine($"Data inválida");
                     Console.ResetColor();
                     
                  }
                  
                  
               } while (dataValida == false);


               
               
               



               Console.WriteLine($"Digite o numero do CPF");
               novaPf.cpf = Console.Readline();

               Console.WriteLine($"Digite o rendimento mensal (digite somente numeros)");
               novaPf.rendimento = float.Parse(Console.ReadLine());

               Console.WriteLine($"Digite o Logradouro");
               novaEnd.Logradouro = Console.ReadLine();

               Console.WriteLine($"Digite o numero");
               novoEnd.numero = int.Parse(Console.ReadLine());

               Console.WriteLine($"Digite o complemento (Aperte enter para vazio");
               novoEnd.Complemento = Console.ReadLine();


               Console.WriteLine($"Este endereço é comercial ? Sim/Não");
               string endCom = Console.ReadLine().toUpper();

               if (endCom == "Sim")
               {
                  novoEnd.EndCOmercial = true;

               }else
               {
                   novoEnd.EndCOmercial = false;
               }

               novaPf.Endereco = novoEnd;

               listaPf.Add(novaPf);



               Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.WriteLine($"Cadastro realizado com sucesso");
               Console.ResetColor();
               
                  break;

               case "2":
               Console.Clear();
            
               if (listaPf.count > 0)
               {

                  foreach (PessoaFisica cadaPessoa in listaPf)
                  {
                      Console.Clear();
                      Console.WriteLine(@$"
                      Nome: {novaPf.Nome} 
                      Endereco: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}
                      Maior de Idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento)
                      ? "Sim" : "Não")}
                      Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).toString("C")}");

                     
                  }
                  
               }else
               {
                  Console.WriteLine($"Lista Vazia");
                  Thread.Sleep(3000);
                  
               } 

  
   
               Console.WriteLine($"Aperte 'Enter' para continuar ");
               Console.ReadLine();


                  break;

               case "0":
                  break;
               default:
                  Console.Clear();
                  Console.WriteLine($"opção inválida, por favor digite outra opção");
                  Thread.Sleep(500);
                  break;         
            }
            
               

                                                               

            }while (opcaoPf != "0" );          

         break;
      case "2":PessoaJuridica metodoPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "Razao Social Pj";
            novaPj.rendimento = 8000.5f;

            
            novoEnd.Logradouro = "Alameda Barão de Limeira";
            novoEnd.Numero = 539;
            novoEnd.Complemento = "Senai Informartica";
            novoEnd.EndCOmercial = true;

            novoPj.Endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaosocial}
            CNPJ: {novaPj.cnpj}
            CNPJ válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");
         break;
      case "0":
        Console.Clear();
        Console.WriteLine($"Obrigado por utilizar nosso sistema");

        
       
        BarraCarregamento("Finalizando  ", 300);

           
         break;

      default:
         Console.Clear();
         Console.WriteLine($"opção inválida, por favor digite outra opção");
         Thread.Sleep(500);
         break;
    }

   
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo){
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Red;


        Console.Write($"{texto}");

        for (var contador = 0; contador < 10; contador++)
        {
        Console.Write(".");
        Thread.Sleep(500);
    
        }

        Console.ResetColor();

}





Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");





