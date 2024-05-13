using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class ExistingDetails
	{
        [Key]
        [StringLength(75)]
        public string? OldPropertyNumber { get; set; }

        [StringLength(255)]
        public string? CustomerName { get; set; }

        public int LocalityId { get; set; }

        public int Renumbered { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }
    }
}

