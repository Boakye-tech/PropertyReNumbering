using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class Locality
	{
        [Key]
        public int LocalityId { get; set; }

        [Required]
        //[MaxLength(3)]
        [MaxLength(10)]
        public string? LocalityInitial { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LocalityName { get; set; }
    }
}

