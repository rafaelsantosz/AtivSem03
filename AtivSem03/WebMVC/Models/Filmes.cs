
namespace WebMVC.Models
{
    using System.ComponentModel.DataAnnotations;

    //Classe da Tabela 'Filmes' do Banco de Dados, gerada atrav�s do Database First
    public partial class Filmes
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Digite o nome do filme!")]
        public string nomeFilme { get; set; }

        [Required(ErrorMessage = "Digite o g�nero do filme!")]
        public string generoFilme { get; set; }

        [Required(ErrorMessage = "Digite uma idade ou a Classifica��o: 'Livre'!")]
        [StringLength(5, ErrorMessage = "Digite uma idade ou a Classifica��o: 'Livre'!")]
        public string classificacaoFilme { get; set; }
    }
}
