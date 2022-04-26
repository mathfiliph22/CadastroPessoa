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


Console.WriteLine(@$"
Nome: {novaPf.Nome} 
Endereco: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}
Maior de Idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}");


novaPf.Endereco = novoEnd;

novaPj.nome = "Nome Pj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Razao Social Pj";
novaPj.rendimento = 8000.5f;

Console.WriteLine($"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaosocial}
CNPJ: {novaPj.cnpj}
CNPJ válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");





PessoaJuridica metodoPj = new PessoaJuridica();

PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();



Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");





