using System.ComponentModel.DataAnnotations;

namespace ConstructionPrototype.Data.Entities
{
    public enum eJobType
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

        public string JobName { get; set; }

        public eJobType JobType { get; set; }

        public int Salary { get; set; }

        public string JobLocation { get; set; }
    }
}
