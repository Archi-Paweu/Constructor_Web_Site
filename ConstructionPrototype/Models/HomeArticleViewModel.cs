namespace ConstructionPrototype.Models
{
    public class HomeArticleViewModel
    {

        private string Id { get; set; }


        public string Title { get; set; }


        public string ShortDescription { get; set; }


        public string? Description { get; set; }


        public byte[]? Image { get; set; }

        public string? displayImage { get; set; }
    };


}
