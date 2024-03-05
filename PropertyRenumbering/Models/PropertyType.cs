using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class PropertyType
	{
        [Key]
        public int PropertyTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? PropertyTypes { get; set; }
    }
}

