using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class LandUseType
	{
        [Key]
        public int LandUseTypeId { get; set; }

        [Required]
        [MaxLength(3)]
        public string? LandUseTypeInitial { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LandUseTypeName { get; set; }

        //foreign key
        public int LandUseId { get; set; }

        //navigation property
        public LandUse? LandUse { get; set; }

    }
}

