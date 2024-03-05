using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class PlotSize
	{
        [Key]
        public int PlotSizeId { get; set; }

        [Required]
        [MaxLength(10)]
        public string? PlotSizes { get; set; }
    }
}

