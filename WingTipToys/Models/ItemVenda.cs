using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingTipToys.Models {
    public class ItemVenda {
        [Key]
        public int ItemVendaId { get; set; }

        [Required]
        public virtual Produto Produto { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public DateTime Data { get; set; }

        public string CarrinhoId { get; set; }
    }
}