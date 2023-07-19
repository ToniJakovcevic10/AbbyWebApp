using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model
{
    public class Category
    {
        [Key]   //odreduje primary key, ako nema ovog, onda Id automatski postavlja,
                //ostalo ne moze
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        [Range(1,100, ErrorMessage ="Display Order must be in range 1-100!!!")]
        public int DisplayOrder { get; set; }

    }
}
