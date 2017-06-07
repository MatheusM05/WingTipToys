using System.ComponentModel.DataAnnotations;

namespace WingTipToys.Models {
    public class Cliente {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(150)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefone { get; set; }
    }
}