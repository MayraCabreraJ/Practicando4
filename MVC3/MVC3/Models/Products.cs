using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC3.Models
{
    public enum UniType
    {
        Botella,
        Litro,
        Galon,
        Metro,
        Tonelada,
        Kg
    }
    public enum StatusType
    { Activo,
      Inactivo
    }
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [Required]
        public UniType Unit{ get; set; }
        public StatusType Status { get; set; }
    }
}