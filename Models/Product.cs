using System.ComponentModel.DataAnnotations;

namespace BlazorAppProductHomework.Models
{
    public class Product
    {

        [Required(ErrorMessage ="El código es requerido")]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es requerido")]
        [StringLength(50,ErrorMessage ="El nombre del producto no puede tener más de 50 carácteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        [Range(0.01,double.MaxValue,ErrorMessage = "El precio debe ser mayor que 0")] //con Range hacemos verificamos un rango de valor, ya sea de 0 a x número.
        //en este caso lo usamos con mayor a 0 y double.max me verifica cualquier valor mayor
        public decimal Price { get; set; }

        [Required(ErrorMessage = "La descripción es requerido")]
        public string Description { get; set; }

        

    }
}
