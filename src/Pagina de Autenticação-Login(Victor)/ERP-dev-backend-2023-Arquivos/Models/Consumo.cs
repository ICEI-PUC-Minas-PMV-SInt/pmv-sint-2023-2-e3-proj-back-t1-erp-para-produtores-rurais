using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_dev_backend_2023.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a descrição!")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Data { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o veículo!")]
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo veiculo { get; set; }

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Diesel,
        Alcool
    }
}
