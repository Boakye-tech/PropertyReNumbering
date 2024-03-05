using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class AllocationType
	{
        [Key]
        public int AllocationTypeId { get; set; }

        [Required]
        [MaxLength(3)]
        public string? AllocationTypeInitial { get; set; }

        [Required]
        [MaxLength(75)]
        public string? AllocationTypes { get; set; }
    }
}

