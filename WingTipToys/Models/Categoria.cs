using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WingTipToys.Models {
    [Table("Categorias")]
    public class Categoria {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoriaNome { get; set; }
    }
}