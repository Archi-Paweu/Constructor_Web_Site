using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConstructionPrototype.Models
{
    public class Item
    {

        [Key]
        public int Id { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        [DisplayName("Building Name")]
        public string BuildingName { get; set; }



    }
}
