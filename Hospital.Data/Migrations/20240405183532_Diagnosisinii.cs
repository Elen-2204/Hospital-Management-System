using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Data.Migrations
{
    public partial class Diagnosisinii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiagnosisRecords",
                columns: table => new
                {
                    DiagnosisRecordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(nullable: false),
                    PatientName = table.Column<string>(maxLength: 100, nullable: false),
                    Diagnosis = table.Column<string>(maxLength: 255, nullable: false),
                    Medicine = table.Column<string>(maxLength: 255, nullable: false),
                    DiagnosisDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisRecords", x => x.DiagnosisRecordID);
                    table.ForeignKey(
                        name: "FK_DiagnosisRecords_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisRecords_PatientID",
                table: "DiagnosisRecords",
                column: "PatientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiagnosisRecords");
        }
    }
}

