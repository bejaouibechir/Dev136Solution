using System.ComponentModel.DataAnnotations;

namespace WebMVCCodeFirst.Models.ViewModels
{
    public class ModelViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ce champ ne doit pas être vide")]
        public string Label { get; set; }
    }
}
