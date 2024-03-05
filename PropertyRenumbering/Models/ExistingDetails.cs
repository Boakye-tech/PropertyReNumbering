using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class ExistingDetails
	{
        [Key]
        [MaxLength(75)]
        public string? PropertyNumber { get; set; }

        [MaxLength(255)]
        public string? CustomerName { get; set; }

        public int Renumbered { get; set; }
    }
}

