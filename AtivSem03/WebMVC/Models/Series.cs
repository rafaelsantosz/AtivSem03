
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    //Classe da Tabela 'Series' do Banco de Dados, gerada atrav�s do Database First
    public partial class Series
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Digite o nome da s�rie!")]
        public string nomeSerie { get; set; }

        [Required(ErrorMessage = "Digite o g�nero da s�rie!")]
        public string generoSerie { get; set; }

        [Required(ErrorMessage = "Digite uma idade ou a Classifica��o: 'Livre'!")]
        [StringLength(5, ErrorMessage = "Digite uma idade ou a Classifica��o: 'Livre'!")]
        public string classificacaoSerie { get; set; }
    }
}
