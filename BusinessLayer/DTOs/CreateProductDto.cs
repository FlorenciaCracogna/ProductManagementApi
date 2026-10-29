using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer.DTOs
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre del producto debe tener entre 3 y 100 caracteres")]
        public string Name { get; set; } = "";
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a $0")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Category { get; set; } = "";
    }
}
