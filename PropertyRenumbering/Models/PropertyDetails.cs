using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PropertyRenumbering.Models
{
	public class PropertyDetails
	{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PropertyId { get; set; }

        [Required]
        public int PropertyTypeId { get; set; }

        [Key]
        [MaxLength(50)]
        public string? NewPropertyNumber { get; set; }

        [Required]
        [MaxLength(75)]
        public string? OldPropertyNumber { get; set; }

        [Required]
        public int LocalityId { get; set; }

        [Required]
        public int LandUseId { get; set; }

        [Required]
        public int LandUseTypeId { get; set; }

        [Required]
        public double Acreage { get; set; }

        public double Acreage2 { get; set; }

        [Required]
        [MaxLength(5)]
        public string? BlockNumber { get; set; }

        [Required]
        [MaxLength(10)]
        public string? PlotNumber { get; set; }

        public int PlotSizeId { get; set; }

        public string? Lane { get; set; }

        public string? Neighbourhood { get; set; }

        //[Required]
        public string? CustomerCode { get; set; }
        
        public int LargeScale { get; set; }

        public int DebtorType { get; set; }

        public int GroupNumber { get; set; }
        
        public float SellingPrice { get; set; }

        public int CurrencyId { get; set; }

        public int UnitsOccupied { get; set; }

        public float MonthlyRent { get; set; }

        public DateOnly RightOfEntry { get; set; }

        public int LeasePeriodId { get; set; }

        public int PropertyHeightId { get; set; }

        public string? UserName { get; set; }

        [ForeignKey("LocalityId")]
        public Locality? locality { get; set; }

    }



   
}

