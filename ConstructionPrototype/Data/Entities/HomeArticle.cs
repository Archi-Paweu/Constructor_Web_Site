using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstructionPrototype.Data.Entities
{
    public class HomeArticle
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }


        [StringLength(50, MinimumLength = 4, ErrorMessage = "{0} should be between {2} and {1} characters long.")]
        public string Title { get; set; }


        [Display(Name = "Short Description")]
        [StringLength(400, MinimumLength = 20, ErrorMessage = "{0} should be between {2} and {1} characters long.")]
        public string ShortDescription { get; set; }


        [StringLength(5000, MinimumLength = 20, ErrorMessage = "{0} should be between {2} and {1} characters long.")]
        public string? Description { get; set; }


        public byte[]? Image { get; set; }


    }
}
