using Microsoft.EntityFrameworkCore.Migrations;

namespace Shawn.AbpProject.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_fromPool",
                schema: "dbo",
                table: "CenterCostUse",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_orderNum",
                schema: "dbo",
                table: "CenterCostUse",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_state",
                schema: "dbo",
                table: "CenterCostUse",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "_sumQuota",
                schema: "dbo",
                table: "CenterCostUse",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "_targetPool",
                schema: "dbo",
                table: "CenterCostUse",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_CenterCostBehaviorRecordsId",
                schema: "dbo",
                table: "CenterCost",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_CenterCostUsesId",
                schema: "dbo",
                table: "CenterCost",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CenterCost__CenterCostBehaviorRecordsId",
                schema: "dbo",
                table: "CenterCost",
                column: "_CenterCostBehaviorRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_CenterCost__CenterCostUsesId",
                schema: "dbo",
                table: "CenterCost",
                column: "_CenterCostUsesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CenterCost_CenterCostBehaviorRecord__CenterCostBehaviorRecordsId",
                schema: "dbo",
                table: "CenterCost",
                column: "_CenterCostBehaviorRecordsId",
                principalSchema: "dbo",
                principalTable: "CenterCostBehaviorRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CenterCost_CenterCostUse__CenterCostUsesId",
                schema: "dbo",
                table: "CenterCost",
                column: "_CenterCostUsesId",
                principalSchema: "dbo",
                principalTable: "CenterCostUse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CenterCost_CenterCostBehaviorRecord__CenterCostBehaviorRecordsId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropForeignKey(
                name: "FK_CenterCost_CenterCostUse__CenterCostUsesId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropIndex(
                name: "IX_CenterCost__CenterCostBehaviorRecordsId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropIndex(
                name: "IX_CenterCost__CenterCostUsesId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropColumn(
                name: "_fromPool",
                schema: "dbo",
                table: "CenterCostUse");

            migrationBuilder.DropColumn(
                name: "_orderNum",
                schema: "dbo",
                table: "CenterCostUse");

            migrationBuilder.DropColumn(
                name: "_state",
                schema: "dbo",
                table: "CenterCostUse");

            migrationBuilder.DropColumn(
                name: "_sumQuota",
                schema: "dbo",
                table: "CenterCostUse");

            migrationBuilder.DropColumn(
                name: "_targetPool",
                schema: "dbo",
                table: "CenterCostUse");

            migrationBuilder.DropColumn(
                name: "_CenterCostBehaviorRecordsId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropColumn(
                name: "_CenterCostUsesId",
                schema: "dbo",
                table: "CenterCost");
        }
    }
}
