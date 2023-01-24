﻿using System.ComponentModel.DataAnnotations;

namespace ConstructionPrototype.Data.Entities
{
    public enum EJobType
    {
        FullTime,
        PartTime,
        Contract
    }
    public class JobOffer
    {
        [Key]
        [Required]
        public string Id { get; set; }

        public string Name { get; set; }

        public EJobType Type { get; set; }

        public int Salary { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }
    }
}
