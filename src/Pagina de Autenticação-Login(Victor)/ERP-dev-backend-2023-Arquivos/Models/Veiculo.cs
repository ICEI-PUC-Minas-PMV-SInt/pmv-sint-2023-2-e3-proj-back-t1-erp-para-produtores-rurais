using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_dev_backend_2023.Models
{

    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigátorio informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar a Placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar o ano de Fabricação!")]
        [Display(Name ="Ano de Fabricação")]
        public int AnoFabricacao { get; set; }


        [Required(ErrorMessage = "Obrigátorio informar o Ano do Modelo!")]
        [Display(Name ="Ano do Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
