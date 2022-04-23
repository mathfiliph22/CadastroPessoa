using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string ?cpf { get; set; }

        public DateTime ?dataNascimento { get; set; }

        
        
        
        
        

  
        
        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if (DateTime.tryParse(dataNasc, out dataConvertida))
            {
                
                Console.WriteLine($"{dataConvertida}");

                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataNasc).totalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }
            
                   return false;
        
            }







            

        }

        public override float PagarImposto(float rendimento){
            throw new NotImplementedException();
          
            
        }






        
    }
}