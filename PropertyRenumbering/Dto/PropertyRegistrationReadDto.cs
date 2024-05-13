using System.ComponentModel.DataAnnotations;

namespace PropertyRenumbering.Dto
{
    public record class PropertyRegistrationReadDto
    {
        public string? PropertyType { get; set; }
        public string? NewPropertyNumber { get; set; }
        public string? OldPropertyNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? Locality { get; set; }
        public string? LandUse { get; set; }
        public string? LandUseType { get; set; }
        public string? AllocationType { get; set; }
        public string? BlockNumber { get; set; }
        public string? PlotNumber { get; set; }

    }
}
