using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealTimeProducts.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Imagen")]
        public string Imagen { get; set; }

        [Required]
        [StringLength(5000)]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        public int Price { get; set; }

        [Display(Name = "Fecha")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Stock")]
        public byte Stock { get; set; }
    }
}