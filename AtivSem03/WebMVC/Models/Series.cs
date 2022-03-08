
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    //Classe da Tabela 'Series' do Banco de Dados, gerada através do Database First
    public partial class Series
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Digite o nome da série!")]
        public string nomeSerie { get; set; }

        [Required(ErrorMessage = "Digite o gênero da série!")]
        public string generoSerie { get; set; }

        [Required(ErrorMessage = "Digite uma idade ou a Classificação: 'Livre'!")]
        [StringLength(5, ErrorMessage = "Digite uma idade ou a Classificação: 'Livre'!")]
        public string classificacaoSerie { get; set; }
    }
}
