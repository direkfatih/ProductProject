using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductProject.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Ürün adı zorunludur")]
        [StringLength(100)]
        [Display(Name="Ürün Adı")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ürün fiyatı zorunludur")]
        [Range(0,100000)]
        [Display(Name="Ürün Fiyatı")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Ürün fotoğrafı zorunludur")]
        [Display(Name="Ürün Resmi")]
        public string? Image { get; set; }
        [Display(Name="Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name="Kategori")]
        public int CategoryId { get; set; }

        public IFormFile? ImageFile { get; set; }
    }
}