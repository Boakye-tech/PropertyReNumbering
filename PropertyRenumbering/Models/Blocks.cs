using System;
using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Models
{
	public class Blocks
	{
		[Key]
		public int BlockId { get; set; }
		public string? Block { get; set; }
	}
}

