using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class Currency
	{
        [Key]
        public int CurrencyId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? CurrencyName { get; set; }
    }
}

