using System.ComponentModel.DataAnnotations;

namespace ConstructionPrototype.Models
{
    public class HomeArticleCreateForm
    {
        public string Title { get; set; }


        [Display(Name = "Short Description")]
        [StringLength(100, MinimumLength = 20, ErrorMessage = "{0} should be between {2} and {1} characters long.")]
        public string ShortDescription { get; set; }


        [StringLength(500, MinimumLength = 20, ErrorMessage = "{0} should be between {2} and {1} characters long.")]
        public string? Description { get; set; }


        public IFormFile? Image { get; set; }
    }

    public class HomeArticleCreateViewModel
    {
        public string ActionPath { get; set; }

        public HomeArticleCreateForm CreateForm { get; set; }
    }
}

