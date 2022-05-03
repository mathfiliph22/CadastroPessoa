using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica 
    {

        public string? cpf { get; set; }

        public string? dataNascimento { get; set; }

        
        
        
        
        

  
        
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

        public override float PagarImposto(float rendimento)
       {
            if (rendimento <= 1500) 
            {
                return 0;

            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento / 100) * 2;

            }
            else if (rendimento > 3500 && rendimento < 6000 )
            {
                return (rendimento / 100) * 3.5f;


            }
            else
            {
                return (rendimento / 100) * 5;

            }


           
          
            
        }






        
    }
}