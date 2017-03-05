using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClarkNetWebPortal.Migrations
{
    public partial class myfirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discriminator = table.Column<string>(nullable: false),
                    DisplayName = table.Column<string>(nullable: false),
                    NameOrIpAddress = table.Column<string>(nullable: false),
                    Type = table.Column<byte>(nullable: false),
                    AtHost = table.Column<string>(nullable: true),
                    HomePath = table.Column<string>(nullable: true),
                    PortNumber = table.Column<int>(nullable: true),
                    Protocol = table.Column<byte>(nullable: true),
                    TestPath = table.Column<string>(nullable: true),
                    VideoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hosts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hosts");
        }
    }
}
