using System.ComponentModel.DataAnnotations;

namespace ConstructionPrototype.Data.Entities
{
    public enum JobType
    {
        FullTime,
        PartTime,
        Contract
    }
    public class JobOffer
    {
        [Key]
        [Required]

        public string JobId { get; set; }

    }
}
