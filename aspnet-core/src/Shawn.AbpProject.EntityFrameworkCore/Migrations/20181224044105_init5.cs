using Microsoft.EntityFrameworkCore.Migrations;

namespace Shawn.AbpProject.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "_actionId",
                schema: "dbo",
                table: "CenterCostBehaviorRecord",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "_actionType",
                schema: "dbo",
                table: "CenterCostBehaviorRecord",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_createuser",
                schema: "dbo",
                table: "CenterCostBehaviorRecord",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_eventid",
                schema: "dbo",
                table: "CenterCostBehaviorRecord",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "_eventsource",
                schema: "dbo",
                table: "CenterCostBehaviorRecord",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_eventversion",
                schema: "dbo",
                table: "CenterCostBehaviorRecord",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "_money",
                schema: "dbo",
                table: "CenterCostBehaviorRecord",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "_remark",
                schema: "dbo",
                table: "CenterCostBehaviorRecord",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_actionId",
                schema: "dbo",
                table: "CenterCostBehaviorRecord");

            migrationBuilder.DropColumn(
                name: "_actionType",
                schema: "dbo",
                table: "CenterCostBehaviorRecord");

            migrationBuilder.DropColumn(
                name: "_createuser",
                schema: "dbo",
                table: "CenterCostBehaviorRecord");

            migrationBuilder.DropColumn(
                name: "_eventid",
                schema: "dbo",
                table: "CenterCostBehaviorRecord");

            migrationBuilder.DropColumn(
                name: "_eventsource",
                schema: "dbo",
                table: "CenterCostBehaviorRecord");

            migrationBuilder.DropColumn(
                name: "_eventversion",
                schema: "dbo",
                table: "CenterCostBehaviorRecord");

            migrationBuilder.DropColumn(
                name: "_money",
                schema: "dbo",
                table: "CenterCostBehaviorRecord");

            migrationBuilder.DropColumn(
                name: "_remark",
                schema: "dbo",
                table: "CenterCostBehaviorRecord");
        }
    }
}
