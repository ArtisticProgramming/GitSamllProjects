using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeNet.API.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammingLanguage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralSubject",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralSubject_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NoteType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NoteType_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecificSubject",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralSubjectId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificSubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificSubject_GeneralSubject_GeneralSubjectId",
                        column: x => x.GeneralSubjectId,
                        principalTable: "GeneralSubject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CodeNote",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    NoteTypeId = table.Column<long>(type: "bigint", nullable: false),
                    GeneralSubjectId = table.Column<long>(type: "bigint", nullable: false),
                    SpecificSubjectId = table.Column<long>(type: "bigint", nullable: true),
                    IsBookMarked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodeNote_GeneralSubject_GeneralSubjectId",
                        column: x => x.GeneralSubjectId,
                        principalTable: "GeneralSubject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CodeNote_NoteType_NoteTypeId",
                        column: x => x.NoteTypeId,
                        principalTable: "NoteType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CodeNote_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CodeNote_SpecificSubject_SpecificSubjectId",
                        column: x => x.SpecificSubjectId,
                        principalTable: "SpecificSubject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CodeNote_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CodeNoteDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeSyntax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgrammingLanguageId = table.Column<long>(type: "bigint", nullable: false),
                    CodeNoteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeNoteDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodeNoteDetail_CodeNote_CodeNoteId",
                        column: x => x.CodeNoteId,
                        principalTable: "CodeNote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CodeNoteDetail_ProgrammingLanguage_ProgrammingLanguageId",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodeNote_GeneralSubjectId",
                table: "CodeNote",
                column: "GeneralSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeNote_NoteTypeId",
                table: "CodeNote",
                column: "NoteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeNote_ProjectId",
                table: "CodeNote",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeNote_SpecificSubjectId",
                table: "CodeNote",
                column: "SpecificSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeNote_UserId",
                table: "CodeNote",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeNoteDetail_CodeNoteId",
                table: "CodeNoteDetail",
                column: "CodeNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeNoteDetail_ProgrammingLanguageId",
                table: "CodeNoteDetail",
                column: "ProgrammingLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralSubject_UserId",
                table: "GeneralSubject",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteType_UserId",
                table: "NoteType",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_UserId",
                table: "Project",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificSubject_GeneralSubjectId",
                table: "SpecificSubject",
                column: "GeneralSubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeNoteDetail");

            migrationBuilder.DropTable(
                name: "CodeNote");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguage");

            migrationBuilder.DropTable(
                name: "NoteType");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "SpecificSubject");

            migrationBuilder.DropTable(
                name: "GeneralSubject");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
