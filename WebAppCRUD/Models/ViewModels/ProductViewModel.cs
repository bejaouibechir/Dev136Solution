using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD.Models.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [Required(ErrorMessage ="Le champ Id ne doit pas être laissé vide")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le champ Label ne doit pas être laissé vide")]
        public string Label { get; set; }

        [Required(ErrorMessage = "Le champ Category ne doit pas être laissé vide")]
        public string Category { get; set; }

        [Range(0,100000,ErrorMessage ="Le prix doit être entre 0 et 100000")]
        public decimal? Price { get; set; }
    }
}