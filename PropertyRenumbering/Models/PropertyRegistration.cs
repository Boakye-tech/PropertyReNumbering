using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PropertyRenumbering.Models
{
    
    public class PropertyRegistration
    {
        //[JsonConstructor]
        public PropertyRegistration()
        {
        }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PropertyId { get; set; }


        [Required]
        [Display(Name = "Property Type")]
        public int PropertyTypeId { get; set; }

        [Key]
        [MaxLength(50)]
        [Display(Name ="New Property Number")]
        public string? NewPropertyNumber { get; set; }

        //[Required]
        [MaxLength(75)]
        [Display(Name = "Old Property Number")]
        public string? OldPropertyNumber { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Customer Name")]
        public string? CustomerName { get; set; }

        [Required]
        [Display(Name = "Locality")]
        public int LocalityId { get; set; }

        [Required]
        [Display(Name = "Land User")]
        public int LandUseId { get; set; }

        [Required]
        [Display(Name = "Land User Type")]
        public int LandUseTypeId { get; set; }

        [Required]
        [Display(Name = "Allocation Type")]
        public int AllocationTypeId { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Block Number")]
        public string? BlockNumber { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Plot Number")]
        public string? PlotNumber { get; set; }
        
        //[ForeignKey("LocalityId")]
        //public Locality? locality { get; set; }
        
        //[ForeignKey("LandUseId")]
        //public LandUse? landUse { get; set; }
        
        //[ForeignKey("AllocationTypeId")]
        //public AllocationType? allocationType { get; set; }

        //[ForeignKey("PropertyTypeId")]
        //public PropertyType? propertyType { get; set; }



    }
}

