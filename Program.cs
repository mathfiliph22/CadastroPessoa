// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CadastroPessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPf.Nome = "Matheus"; 
novaPf.dataNascimento = "01/01/2000";
novaPf.cpf = "1234567890";
novaPf.rendimento = 15000.5f;

novoEnd.Logradouro = "Alameda Barão de Limeira";
novoEnd.Numero = 539;
novoEnd.Complemento = "Senai Informartica";
novoEnd.EndCOmercial = true;

novaPf.Endereco = novoEnd;



Console.WriteLine(@$"
Nome: {novaPf.Nome} 
Endereco: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}
Maior de Idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}");





