using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PropertyRenumbering.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllocationTypes",
                columns: table => new
                {
                    AllocationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllocationTypeInitial = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    AllocationTypes = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllocationTypes", x => x.AllocationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    BlockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.BlockId);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "ExistingDetails",
                columns: table => new
                {
                    OldPropertyNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Renumbered = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExistingDetails", x => x.OldPropertyNumber);
                });

            migrationBuilder.CreateTable(
                name: "LandUses",
                columns: table => new
                {
                    LandUseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandUseInitial = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LandUseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandUses", x => x.LandUseId);
                });

            migrationBuilder.CreateTable(
                name: "Localities",
                columns: table => new
                {
                    LocalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalityInitial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LocalityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localities", x => x.LocalityId);
                });

            migrationBuilder.CreateTable(
                name: "PlotSizes",
                columns: table => new
                {
                    PlotSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlotSizes = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlotSizes", x => x.PlotSizeId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyRegistration",
                columns: table => new
                {
                    NewPropertyNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false),
                    OldPropertyNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LocalityId = table.Column<int>(type: "int", nullable: false),
                    LandUseId = table.Column<int>(type: "int", nullable: false),
                    LandUseTypeId = table.Column<int>(type: "int", nullable: false),
                    AllocationTypeId = table.Column<int>(type: "int", nullable: false),
                    BlockNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PlotNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRegistration", x => x.NewPropertyNumber);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.PropertyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LandUseTypes",
                columns: table => new
                {
                    LandUseTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandUseTypeInitial = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LandUseTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LandUseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandUseTypes", x => x.LandUseTypeId);
                    table.ForeignKey(
                        name: "FK_LandUseTypes_LandUses_LandUseId",
                        column: x => x.LandUseId,
                        principalTable: "LandUses",
                        principalColumn: "LandUseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                columns: table => new
                {
                    NewPropertyNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false),
                    OldPropertyNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    LocalityId = table.Column<int>(type: "int", nullable: false),
                    LandUseId = table.Column<int>(type: "int", nullable: false),
                    LandUseTypeId = table.Column<int>(type: "int", nullable: false),
                    Acreage = table.Column<double>(type: "float", nullable: false),
                    Acreage2 = table.Column<double>(type: "float", nullable: false),
                    BlockNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PlotNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PlotSizeId = table.Column<int>(type: "int", nullable: false),
                    Lane = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Neighbourhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LargeScale = table.Column<int>(type: "int", nullable: false),
                    DebtorType = table.Column<int>(type: "int", nullable: false),
                    GroupNumber = table.Column<int>(type: "int", nullable: false),
                    SellingPrice = table.Column<float>(type: "real", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    UnitsOccupied = table.Column<int>(type: "int", nullable: false),
                    MonthlyRent = table.Column<float>(type: "real", nullable: false),
                    RightOfEntry = table.Column<DateOnly>(type: "date", nullable: false),
                    LeasePeriodId = table.Column<int>(type: "int", nullable: false),
                    PropertyHeightId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.NewPropertyNumber);
                    table.ForeignKey(
                        name: "FK_PropertyDetails_Localities_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Localities",
                        principalColumn: "LocalityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AllocationTypes",
                columns: new[] { "AllocationTypeId", "AllocationTypeInitial", "AllocationTypes" },
                values: new object[,]
                {
                    { 1, "DTA", "DIRECT ALLOCATION" },
                    { 2, "DTR", "DIRECT RENT" },
                    { 3, "RGU", "REGULARIZATION" },
                    { 4, "DPA", "DUTY POST ALLOCATION" },
                    { 5, "TTC", "TEMA TRADITIONAL COUNCIL" },
                    { 6, "NTC", "NUNGUA TRADITIONAL COUNCIL" },
                    { 7, "KTC", "KPONE TRADITIONAL COUNCIL" }
                });

            migrationBuilder.InsertData(
                table: "LandUses",
                columns: new[] { "LandUseId", "LandUseInitial", "LandUseName" },
                values: new object[,]
                {
                    { 1, "RPL", "RESIDENTIAL" },
                    { 2, "HOS", "HOUSE OWNERSHIP SCHEME" },
                    { 3, "LSD", "LARGE SCALE DEVELOPMENT" },
                    { 4, "HSE", "HOUSE" },
                    { 5, "FLT", "FLAT" },
                    { 6, "CPL", "COMMERCIAL" },
                    { 7, "SHP", "SHOPS & OFFICES" },
                    { 8, "LIC", "LICENSE" },
                    { 9, "IND", "INDUSTRIAL" },
                    { 10, "EMT", "EASEMENT" },
                    { 11, "INS", "INSTITUTIONAL" },
                    { 12, "REC", "RECREATIONAL" }
                });

            migrationBuilder.InsertData(
                table: "Localities",
                columns: new[] { "LocalityId", "LocalityInitial", "LocalityName" },
                values: new object[,]
                {
                    { 1, "C01", "COMMUNITY 1" },
                    { 2, "C02", "COMMUNITY 2" },
                    { 3, "C03", "COMMUNITY 3" },
                    { 4, "C04", "COMMUNITY 4" },
                    { 5, "C05", "COMMUNITY 5" },
                    { 6, "C06", "COMMUNITY 6" },
                    { 7, "C07", "COMMUNITY 7" },
                    { 8, "C08", "COMMUNITY 8" },
                    { 9, "C09", "COMMUNITY 9" },
                    { 10, "C10", "COMMUNITY 10" },
                    { 11, "C11", "COMMUNITY 11" },
                    { 12, "C12", "COMMUNITY 12" },
                    { 13, "C13", "COMMUNITY 13" },
                    { 14, "C14", "COMMUNITY 14" },
                    { 15, "C15", "COMMUNITY 15" },
                    { 16, "C16", "COMMUNITY 16" },
                    { 17, "C17", "COMMUNITY 17" },
                    { 18, "C18", "COMMUNITY 18" },
                    { 19, "C19", "COMMUNITY 19" },
                    { 20, "C20", "COMMUNITY 20" },
                    { 21, "C21", "COMMUNITY 21" },
                    { 22, "C22", "COMMUNITY 22" },
                    { 23, "C23", "COMMUNITY 23" },
                    { 24, "C24", "COMMUNITY 24" },
                    { 25, "C25", "COMMUNITY 25" },
                    { 26, "ASH", "ASHIAMAN" },
                    { 27, "AK", "AGYEI KODJO" },
                    { 28, "ZN", "ZENU" },
                    { 29, "SAK", "SAKUMONO" },
                    { 30, "KLNG", "KLANGON" },
                    { 31, "BT", "BETHLEHEM" },
                    { 32, "TB", "TSUI BLEOO" },
                    { 33, "TM", "TEMA MANHEAN" },
                    { 34, "HI", "H/INDUSTRIAL MKT" },
                    { 35, "KPN", "KPONE" },
                    { 36, "LASH", "LASHIBI" },
                    { 37, "TC", "TOWN CENTER" },
                    { 38, "VC", "VERTICAL CENTER" },
                    { 39, "LI", "LIGHT INDUSTRIAL" },
                    { 40, "IND", "HEAVY INDUSTRIAL" },
                    { 41, "HI/CMKT", "KPONE CAR MKT" },
                    { 42, "UA", "UNKNOWN AREA" },
                    { 43, "CH", "CHINA TOWN" },
                    { 44, "GC", "GOLF CITY" },
                    { 45, "MI", "MOTORWAY INDUSTRIAL" },
                    { 46, "SK", "SAKI TOWN" },
                    { 47, "BTM", "BORTEYMAN" },
                    { 48, "SBP", "SEBREPOR" },
                    { 49, "MTK", "MLITSAKPO" }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "PropertyTypeId", "PropertyTypes" },
                values: new object[,]
                {
                    { 1, "SERVICED PLOT" },
                    { 2, "PARTIALLY SERVICED PLOT" },
                    { 3, "UNSERVICED PLOT" },
                    { 4, "H.O.S HOUSE" },
                    { 5, "SHOPS/OFFICES" },
                    { 6, "RENTAL HOUSE" },
                    { 7, "APARTMENTS" }
                });

            migrationBuilder.InsertData(
                table: "LandUseTypes",
                columns: new[] { "LandUseTypeId", "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[,]
                {
                    { 1, 1, "", "TDC BUILT HOUSES (HOS)" },
                    { 2, 1, "", "LESSEE BUILT HOUSES" },
                    { 3, 1, "", "APARTMENTS" },
                    { 4, 1, "", "HOUSES BY ESTATE DEVELOPERS" },
                    { 5, 6, "SHP", "SHOPS & OFFICES" },
                    { 6, 6, "RES", "RESTAURANTS & PUS" },
                    { 7, 6, "HTL", "GUEST HOUSE & HOTELS" },
                    { 8, 6, "PFS", "PETROL FILLING STATION" },
                    { 9, 6, "EVT", "EVENT CENTRES" },
                    { 10, 6, "CLH", "CLUB HOUSES" },
                    { 11, 6, "WHB", "WASHING BAY" },
                    { 12, 6, "CMS", "CORN MILL SITE" },
                    { 13, 6, "LIC", "LICENSE" },
                    { 14, 9, "HIA", "HEAVY INDUSTRIAL ACTIVITIES" },
                    { 15, 9, "LIA", "LIGHT INDUSTRIAL ACTIVITIES" },
                    { 16, 9, "AGR", "AGRO INDUSTRIAL ACTIVITIES" },
                    { 17, 9, "EMT", "EASEMENT" },
                    { 18, 11, "SCH", "SCHOOLS" },
                    { 19, 11, "CHU", "CHURCHES" },
                    { 20, 11, "MOS", "MOSQUES" },
                    { 21, 11, "LIB", "LIBRARY" },
                    { 22, 11, "PUB", "PUBLIC INSTITUTIONS" },
                    { 23, 11, "CLI", "CLINICS & HOSPITALS" },
                    { 24, 12, "GOC", "GOLF COURSE" },
                    { 25, 12, "PLG", "PLAYGROUND" },
                    { 26, 12, "HOR", "HORTICULTURE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllocationTypes_AllocationTypeInitial_AllocationTypes",
                table: "AllocationTypes",
                columns: new[] { "AllocationTypeInitial", "AllocationTypes" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LandUses_LandUseInitial_LandUseName",
                table: "LandUses",
                columns: new[] { "LandUseInitial", "LandUseName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandUseTypes_LandUseId",
                table: "LandUseTypes",
                column: "LandUseId");

            migrationBuilder.CreateIndex(
                name: "IX_LandUseTypes_LandUseTypeInitial_LandUseTypeName",
                table: "LandUseTypes",
                columns: new[] { "LandUseTypeInitial", "LandUseTypeName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Localities_LocalityInitial_LocalityName",
                table: "Localities",
                columns: new[] { "LocalityInitial", "LocalityName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_LocalityId",
                table: "PropertyDetails",
                column: "LocalityId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypes_PropertyTypes",
                table: "PropertyTypes",
                column: "PropertyTypes",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllocationTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "ExistingDetails");

            migrationBuilder.DropTable(
                name: "LandUseTypes");

            migrationBuilder.DropTable(
                name: "PlotSizes");

            migrationBuilder.DropTable(
                name: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "PropertyRegistration");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LandUses");

            migrationBuilder.DropTable(
                name: "Localities");
        }
    }
}
