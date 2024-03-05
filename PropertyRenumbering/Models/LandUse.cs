using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PropertyRenumbering.Models
{
	public class LandUse
	{
		[Key]
		public int LandUseId { get; set; }

        [Required]
        [MaxLength(3)]
        public string? LandUseInitial { get; set; }

        [Required]
		[MaxLength(50)]
		public string? LandUseName { get; set; }

		//navigation property
		public ICollection<LandUseType>? LandUseTypes { get; set; }
	}
}

