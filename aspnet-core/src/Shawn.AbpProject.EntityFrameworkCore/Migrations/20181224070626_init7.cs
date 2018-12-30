using Microsoft.EntityFrameworkCore.Migrations;

namespace Shawn.AbpProject.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CenterCost_CenterCostBehaviorRecord_BehaviorRecordId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropForeignKey(
                name: "FK_CenterCost_CenterCostUse_CostUseId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropIndex(
                name: "IX_CenterCost_BehaviorRecordId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropIndex(
                name: "IX_CenterCost_CostUseId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropColumn(
                name: "BehaviorRecordId",
                schema: "dbo",
                table: "CenterCost");

            migrationBuilder.DropColumn(
                name: "CostUseId",
                schema: "dbo",
                table: "CenterCost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BehaviorRecordId",
                schema: "dbo",
                table: "CenterCost",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CostUseId",
                schema: "dbo",
                table: "CenterCost",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CenterCost_BehaviorRecordId",
                schema: "dbo",
                table: "CenterCost",
                column: "BehaviorRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_CenterCost_CostUseId",
                schema: "dbo",
                table: "CenterCost",
                column: "CostUseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CenterCost_CenterCostBehaviorRecord_BehaviorRecordId",
                schema: "dbo",
                table: "CenterCost",
                column: "BehaviorRecordId",
                principalSchema: "dbo",
                principalTable: "CenterCostBehaviorRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CenterCost_CenterCostUse_CostUseId",
                schema: "dbo",
                table: "CenterCost",
                column: "CostUseId",
                principalSchema: "dbo",
                principalTable: "CenterCostUse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
