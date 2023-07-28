using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lawyer.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    Case_Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Costumer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Case_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Which_C_House = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Which_Court = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.Case_Number);
                });

            migrationBuilder.CreateTable(
                name: "Courts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Court_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourtsHouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourtHouse_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtHouse_Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtsHouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Judges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lawyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lawyer_D_Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sgk_No = table.Column<int>(type: "int", nullable: false),
                    B_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresss = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_Number = table.Column<int>(type: "int", nullable: false),
                    H_Phone_Number = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Witness",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    W_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    W_Lname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Witness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourtCourtHouse",
                columns: table => new
                {
                    CourtsId = table.Column<int>(type: "int", nullable: false),
                    courtHousesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtCourtHouse", x => new { x.CourtsId, x.courtHousesId });
                    table.ForeignKey(
                        name: "FK_CourtCourtHouse_CourtsHouse_courtHousesId",
                        column: x => x.courtHousesId,
                        principalTable: "CourtsHouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourtCourtHouse_Courts_CourtsId",
                        column: x => x.CourtsId,
                        principalTable: "Courts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Case_File_Number = table.Column<int>(type: "int", nullable: false),
                    Case_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case_Defendent_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case_PlaintiffsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case_Court_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case_CourtHouse_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JudgeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Case_Judges_Case_File_Number",
                        column: x => x.Case_File_Number,
                        principalTable: "Judges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourtJudge",
                columns: table => new
                {
                    CourtId = table.Column<int>(type: "int", nullable: false),
                    JudgesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtJudge", x => new { x.CourtId, x.JudgesId });
                    table.ForeignKey(
                        name: "FK_CourtJudge_Courts_CourtId",
                        column: x => x.CourtId,
                        principalTable: "Courts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourtJudge_Judges_JudgesId",
                        column: x => x.JudgesId,
                        principalTable: "Judges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Session_Date = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Session_C_Room = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Witness_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Session_Date);
                    table.ForeignKey(
                        name: "FK_Session_Witness_Witness_Id",
                        column: x => x.Witness_Id,
                        principalTable: "Witness",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaseCostumerRef",
                columns: table => new
                {
                    Case_Id = table.Column<int>(type: "int", nullable: false),
                    Costumer_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseCostumerRef", x => new { x.Case_Id, x.Costumer_Id });
                    table.ForeignKey(
                        name: "FK__CaseId",
                        column: x => x.Case_Id,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__CostumerId",
                        column: x => x.Costumer_Id,
                        principalTable: "Costumers",
                        principalColumn: "Case_Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaseLawyers",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    LawyersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseLawyers", x => new { x.CaseId, x.LawyersId });
                    table.ForeignKey(
                        name: "FK_CaseLawyers_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseLawyers_Lawyers_LawyersId",
                        column: x => x.LawyersId,
                        principalTable: "Lawyers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Case_Case_File_Number",
                table: "Case",
                column: "Case_File_Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CaseCostumerRef_Costumer_Id",
                table: "CaseCostumerRef",
                column: "Costumer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CaseLawyers_LawyersId",
                table: "CaseLawyers",
                column: "LawyersId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtCourtHouse_courtHousesId",
                table: "CourtCourtHouse",
                column: "courtHousesId");

            migrationBuilder.CreateIndex(
                name: "IX_CourtJudge_JudgesId",
                table: "CourtJudge",
                column: "JudgesId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_Witness_Id",
                table: "Session",
                column: "Witness_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseCostumerRef");

            migrationBuilder.DropTable(
                name: "CaseLawyers");

            migrationBuilder.DropTable(
                name: "CourtCourtHouse");

            migrationBuilder.DropTable(
                name: "CourtJudge");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Costumers");

            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "Lawyers");

            migrationBuilder.DropTable(
                name: "CourtsHouse");

            migrationBuilder.DropTable(
                name: "Courts");

            migrationBuilder.DropTable(
                name: "Witness");

            migrationBuilder.DropTable(
                name: "Judges");
        }
    }
}
