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

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.Nome = "Matheus"; 
            novaPf.dataNascimento = "01/01/2000";
            novaPf.cpf = "1234567890";
            novaPf.rendimento = 15000.5f;


            novaPf.Endereco = novoEnd;

            Console.Clear();
            Console.WriteLine(@$"
            Nome: {novaPf.Nome} 
            Endereco: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}
            Maior de Idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}");
            


            Console.WriteLine($"Aperte 'Enter' ");
            Console.ReadLine();
            

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





