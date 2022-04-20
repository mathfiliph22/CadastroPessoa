using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string ?cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        
        
        
        
        

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        public override float PagarImposto(float rendimento){
            throw new NotImplementedException();
          
            
        }






        
    }
}