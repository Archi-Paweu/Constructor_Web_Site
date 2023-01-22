using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConstructionPrototype.Data.Entities
{
    public class Project
    {

        [Key]
        public int Id { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        [DisplayName("Building Name")]
        public string BuildingName { get; set; }



    }
}
