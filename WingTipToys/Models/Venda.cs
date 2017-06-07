using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingTipToys.Models {
    public class Venda {
        [Key]
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public string CarrinhoId { get; set; }
        public DateTime Data { get; set; }
    }
}