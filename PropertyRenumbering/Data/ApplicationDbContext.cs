using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PropertyRenumbering.Models;

namespace PropertyRenumbering.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<AllocationType> AllocationTypes { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<LandUse> LandUses { get; set; }
    public DbSet<LandUseType> LandUseTypes { get; set; }
    public DbSet<Locality> Localities { get; set; }
    public DbSet<PlotSize> PlotSizes { get; set; }
    public DbSet<PropertyType> PropertyTypes { get; set; }
    public DbSet<Blocks> Blocks { get; set; }
    public DbSet<ExistingDetails> ExistingDetails { get; set; }
    public DbSet<PropertyRegistration> PropertyRegistration { get; set; } = default!;


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AllocationType>()
            .HasIndex(at => new { at.AllocationTypeInitial, at.AllocationTypes })
            .IsUnique(true);

        builder.Entity<LandUse>()
            .HasIndex(l => new { l.LandUseInitial, l.LandUseName })
            .IsUnique(true);

        builder.Entity<LandUseType>()
            .HasIndex(lt => new { lt.LandUseTypeInitial, lt.LandUseTypeName })
            .IsUnique(true);

        builder.Entity<Locality>()
            .HasIndex(c => new { c.LocalityInitial, c.LocalityName })
            .IsUnique(true);

        builder.Entity<PropertyType>()
            .HasIndex(pt => new { pt.PropertyTypes })
            .IsUnique(true);



        builder.Entity<AllocationType>().HasData(
            new AllocationType() { AllocationTypeId = 1, AllocationTypeInitial = "DTA", AllocationTypes = "DIRECT ALLOCATION" },
            new AllocationType() { AllocationTypeId = 2, AllocationTypeInitial = "DTR", AllocationTypes = "DIRECT RENT" },
            new AllocationType() { AllocationTypeId = 3, AllocationTypeInitial = "RGU", AllocationTypes = "REGULARIZATION" },
            new AllocationType() { AllocationTypeId = 4, AllocationTypeInitial = "DPA", AllocationTypes = "DUTY POST ALLOCATION" },
            new AllocationType() { AllocationTypeId = 5, AllocationTypeInitial = "TTC", AllocationTypes = "TEMA TRADITIONAL COUNCIL" },
            new AllocationType() { AllocationTypeId = 6, AllocationTypeInitial = "NTC", AllocationTypes = "NUNGUA TRADITIONAL COUNCIL" },
            new AllocationType() { AllocationTypeId = 7, AllocationTypeInitial = "KTC", AllocationTypes = "KPONE TRADITIONAL COUNCIL" }
        );

        builder.Entity<PropertyType>().HasData(
            new PropertyType { PropertyTypeId = 1, PropertyTypes ="SERVICED PLOT" },
            new PropertyType { PropertyTypeId = 2, PropertyTypes = "PARTIALLY SERVICED PLOT" },
            new PropertyType { PropertyTypeId = 3, PropertyTypes = "UNSERVICED PLOT" },
            new PropertyType { PropertyTypeId = 4, PropertyTypes = "H.O.S HOUSE" },
            new PropertyType { PropertyTypeId = 5, PropertyTypes = "SHOPS/OFFICES" },
            new PropertyType { PropertyTypeId = 6, PropertyTypes = "RENTAL HOUSE" },
            new PropertyType { PropertyTypeId = 7, PropertyTypes = "APARTMENTS" }
            );

        builder.Entity<LandUse>().HasData(
            new LandUse() { LandUseId = 1, LandUseInitial = "RPL", LandUseName = "RESIDENTIAL" },
            new LandUse() { LandUseId = 2, LandUseInitial = "HOS", LandUseName = "HOUSE OWNERSHIP SCHEME" },
            new LandUse() { LandUseId = 3, LandUseInitial = "LSD", LandUseName = "LARGE SCALE DEVELOPMENT" },
            new LandUse() { LandUseId = 4, LandUseInitial = "HSE", LandUseName = "HOUSE" },
            new LandUse() { LandUseId = 5, LandUseInitial = "FLT", LandUseName = "FLAT" },
            new LandUse() { LandUseId = 6, LandUseInitial = "CPL", LandUseName = "COMMERCIAL" },
            new LandUse() { LandUseId = 7, LandUseInitial = "SHP", LandUseName = "SHOPS & OFFICES" },
            new LandUse() { LandUseId = 8, LandUseInitial = "LIC", LandUseName = "LICENSE" },
            new LandUse() { LandUseId = 9, LandUseInitial = "IND", LandUseName = "INDUSTRIAL" },
            new LandUse() { LandUseId = 10, LandUseInitial = "EMT", LandUseName = "EASEMENT" },
            new LandUse() { LandUseId = 11, LandUseInitial = "INS", LandUseName = "INSTITUTIONAL" },
            new LandUse() { LandUseId = 12, LandUseInitial = "REC", LandUseName = "RECREATIONAL" }
            );

        builder.Entity<LandUseType>().HasData(
            new LandUseType() { LandUseId = 1, LandUseTypeId = 1, LandUseTypeInitial = "", LandUseTypeName = "TDC BUILT HOUSES (HOS)" },
            new LandUseType() { LandUseId = 1, LandUseTypeId = 2, LandUseTypeInitial = "", LandUseTypeName = "LESSEE BUILT HOUSES" },
            new LandUseType() { LandUseId = 1, LandUseTypeId = 3, LandUseTypeInitial = "", LandUseTypeName = "APARTMENTS" },
            new LandUseType() { LandUseId = 1, LandUseTypeId = 4, LandUseTypeInitial = "", LandUseTypeName = "HOUSES BY ESTATE DEVELOPERS" },

            new LandUseType() { LandUseId = 6, LandUseTypeId = 5, LandUseTypeInitial = "SHP", LandUseTypeName = "SHOPS & OFFICES" },
            new LandUseType() { LandUseId = 6, LandUseTypeId = 6, LandUseTypeInitial = "RES", LandUseTypeName = "RESTAURANTS & PUS" },
            new LandUseType() { LandUseId = 6, LandUseTypeId = 7, LandUseTypeInitial = "HTL", LandUseTypeName = "GUEST HOUSE & HOTELS" },
            new LandUseType() { LandUseId = 6, LandUseTypeId = 8, LandUseTypeInitial = "PFS", LandUseTypeName = "PETROL FILLING STATION" },
            new LandUseType() { LandUseId = 6, LandUseTypeId = 9, LandUseTypeInitial = "EVT", LandUseTypeName = "EVENT CENTRES" },
            new LandUseType() { LandUseId = 6, LandUseTypeId = 10, LandUseTypeInitial = "CLH", LandUseTypeName = "CLUB HOUSES" },
            new LandUseType() { LandUseId = 6, LandUseTypeId = 11, LandUseTypeInitial = "WHB", LandUseTypeName = "WASHING BAY" },
            new LandUseType() { LandUseId = 6, LandUseTypeId = 12, LandUseTypeInitial = "CMS", LandUseTypeName = "CORN MILL SITE" },
            new LandUseType() { LandUseId = 6, LandUseTypeId = 13, LandUseTypeInitial = "LIC", LandUseTypeName = "LICENSE" },

            new LandUseType() { LandUseId = 9, LandUseTypeId = 14, LandUseTypeInitial = "HIA", LandUseTypeName = "HEAVY INDUSTRIAL ACTIVITIES" },
            new LandUseType() { LandUseId = 9, LandUseTypeId = 15, LandUseTypeInitial = "LIA", LandUseTypeName = "LIGHT INDUSTRIAL ACTIVITIES" },
            new LandUseType() { LandUseId = 9, LandUseTypeId = 16, LandUseTypeInitial = "AGR", LandUseTypeName = "AGRO INDUSTRIAL ACTIVITIES" },
            new LandUseType() { LandUseId = 9, LandUseTypeId = 17, LandUseTypeInitial = "EMT", LandUseTypeName = "EASEMENT" },

            new LandUseType() { LandUseId = 11, LandUseTypeId = 18, LandUseTypeInitial = "SCH", LandUseTypeName = "SCHOOLS" },
            new LandUseType() { LandUseId = 11, LandUseTypeId = 19, LandUseTypeInitial = "CHU", LandUseTypeName = "CHURCHES" },
            new LandUseType() { LandUseId = 11, LandUseTypeId = 20, LandUseTypeInitial = "MOS", LandUseTypeName = "MOSQUES" },
            new LandUseType() { LandUseId = 11, LandUseTypeId = 21, LandUseTypeInitial = "LIB", LandUseTypeName = "LIBRARY" },
            new LandUseType() { LandUseId = 11, LandUseTypeId = 22, LandUseTypeInitial = "PUB", LandUseTypeName = "PUBLIC INSTITUTIONS" },
            new LandUseType() { LandUseId = 11, LandUseTypeId = 23, LandUseTypeInitial = "CLI", LandUseTypeName = "CLINICS & HOSPITALS" },

            new LandUseType() { LandUseId = 12, LandUseTypeId = 24, LandUseTypeInitial = "GOC", LandUseTypeName = "GOLF COURSE" },
            new LandUseType() { LandUseId = 12, LandUseTypeId = 25, LandUseTypeInitial = "PLG", LandUseTypeName = "PLAYGROUND" },
            new LandUseType() { LandUseId = 12, LandUseTypeId = 26, LandUseTypeInitial = "HOR", LandUseTypeName = "HORTICULTURE" }
            );

        builder.Entity<Locality>().HasData(
                new Locality { LocalityId = 1, LocalityInitial = "C01", LocalityName = "COMMUNITY 1" },
                new Locality { LocalityId = 2, LocalityInitial = "C02", LocalityName = "COMMUNITY 2" },
                new Locality { LocalityId = 3, LocalityInitial = "C03", LocalityName = "COMMUNITY 3" },
                new Locality { LocalityId = 4, LocalityInitial = "C04", LocalityName = "COMMUNITY 4" },
                new Locality { LocalityId = 5, LocalityInitial = "C05", LocalityName = "COMMUNITY 5" },
                new Locality { LocalityId = 6, LocalityInitial = "C06", LocalityName = "COMMUNITY 6" },
                new Locality { LocalityId = 7, LocalityInitial = "C07", LocalityName = "COMMUNITY 7" },
                new Locality { LocalityId = 8, LocalityInitial = "C08", LocalityName = "COMMUNITY 8" },
                new Locality { LocalityId = 9, LocalityInitial = "C09", LocalityName = "COMMUNITY 9" },
                new Locality { LocalityId = 10, LocalityInitial = "C10", LocalityName = "COMMUNITY 10" },
                new Locality { LocalityId = 11, LocalityInitial = "C11", LocalityName = "COMMUNITY 11" },
                new Locality { LocalityId = 12, LocalityInitial = "C12", LocalityName = "COMMUNITY 12" },
                new Locality { LocalityId = 13, LocalityInitial = "C13", LocalityName = "COMMUNITY 13" },
                new Locality { LocalityId = 14, LocalityInitial = "C14", LocalityName = "COMMUNITY 14" },
                new Locality { LocalityId = 15, LocalityInitial = "C15", LocalityName = "COMMUNITY 15" },
                new Locality { LocalityId = 16, LocalityInitial = "C16", LocalityName = "COMMUNITY 16" },
                new Locality { LocalityId = 17, LocalityInitial = "C17", LocalityName = "COMMUNITY 17" },
                new Locality { LocalityId = 18, LocalityInitial = "C18", LocalityName = "COMMUNITY 18" },
                new Locality { LocalityId = 19, LocalityInitial = "C19", LocalityName = "COMMUNITY 19" },
                new Locality { LocalityId = 20, LocalityInitial = "C20", LocalityName = "COMMUNITY 20" },
                new Locality { LocalityId = 21, LocalityInitial = "C21", LocalityName = "COMMUNITY 21" },
                new Locality { LocalityId = 22, LocalityInitial = "C22", LocalityName = "COMMUNITY 22" },
                new Locality { LocalityId = 23, LocalityInitial = "C23", LocalityName = "COMMUNITY 23" },
                new Locality { LocalityId = 24, LocalityInitial = "C24", LocalityName = "COMMUNITY 24" },
                new Locality { LocalityId = 25, LocalityInitial = "C25", LocalityName = "COMMUNITY 25" },
                new Locality { LocalityId = 26, LocalityInitial = "ASH", LocalityName = "ASHIAMAN" },
                new Locality { LocalityId = 27, LocalityInitial = "AK", LocalityName = "AGYEI KODJO" },
                new Locality { LocalityId = 28, LocalityInitial = "ZN", LocalityName = "ZENU" },
                new Locality { LocalityId = 29, LocalityInitial = "SAK", LocalityName = "SAKUMONO" },
                new Locality { LocalityId = 30, LocalityInitial = "KLNG", LocalityName = "KLANGON" },
                new Locality { LocalityId = 31, LocalityInitial = "BT", LocalityName = "BETHLEHEM" },
                new Locality { LocalityId = 32, LocalityInitial = "TB", LocalityName = "TSUI BLEOO" },
                new Locality { LocalityId = 33, LocalityInitial = "TM", LocalityName = "TEMA MANHEAN" },
                new Locality { LocalityId = 34, LocalityInitial = "HI", LocalityName = "H/INDUSTRIAL MKT" },
                new Locality { LocalityId = 35, LocalityInitial = "KPN", LocalityName = "KPONE" },
                new Locality { LocalityId = 36, LocalityInitial = "LASH", LocalityName = "LASHIBI" },
                new Locality { LocalityId = 37, LocalityInitial = "TC", LocalityName = "TOWN CENTER" },
                new Locality { LocalityId = 38, LocalityInitial = "VC", LocalityName = "VERTICAL CENTER" },
                new Locality { LocalityId = 39, LocalityInitial = "LI", LocalityName = "LIGHT INDUSTRIAL" },
                new Locality { LocalityId = 40, LocalityInitial = "IND", LocalityName = "HEAVY INDUSTRIAL" },
                new Locality { LocalityId = 41, LocalityInitial = "HI/CMKT", LocalityName = "KPONE CAR MKT" },
                new Locality { LocalityId = 42, LocalityInitial = "UA", LocalityName = "UNKNOWN AREA" },
                new Locality { LocalityId = 43, LocalityInitial = "CH", LocalityName = "CHINA TOWN" },
                new Locality { LocalityId = 44, LocalityInitial = "GC", LocalityName = "GOLF CITY" },
                new Locality { LocalityId = 45, LocalityInitial = "MI", LocalityName = "MOTORWAY INDUSTRIAL" },
                new Locality { LocalityId = 46, LocalityInitial = "SK", LocalityName = "SAKI TOWN" },
                new Locality { LocalityId = 47, LocalityInitial = "BTM", LocalityName = "BORTEYMAN" },
                new Locality { LocalityId = 48, LocalityInitial = "SBP", LocalityName = "SEBREPOR" },
                new Locality { LocalityId = 49, LocalityInitial = "MTK", LocalityName = "MLITSAKPO" }
            );


    }


}

