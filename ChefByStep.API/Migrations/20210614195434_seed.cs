using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefByStep.API.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedRecipe_Recipes_RecipeId",
                table: "CompletedRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_CompletedRecipe_Users_UserId",
                table: "CompletedRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_FavouritedRecipe_Recipes_RecipeId",
                table: "FavouritedRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_FavouritedRecipe_Users_UserId",
                table: "FavouritedRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Ingredients_IngredientId",
                table: "RecipeIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Recipes_RecipeId",
                table: "RecipeIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredient",
                table: "RecipeIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavouritedRecipe",
                table: "FavouritedRecipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompletedRecipe",
                table: "CompletedRecipe");

            migrationBuilder.RenameTable(
                name: "RecipeIngredient",
                newName: "RecipeIngredients");

            migrationBuilder.RenameTable(
                name: "FavouritedRecipe",
                newName: "FavouritedRecipes");

            migrationBuilder.RenameTable(
                name: "CompletedRecipe",
                newName: "CompletedRecipes");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredient_IngredientId",
                table: "RecipeIngredients",
                newName: "IX_RecipeIngredients_IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_FavouritedRecipe_UserId",
                table: "FavouritedRecipes",
                newName: "IX_FavouritedRecipes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CompletedRecipe_UserId",
                table: "CompletedRecipes",
                newName: "IX_CompletedRecipes_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients",
                columns: new[] { "RecipeId", "IngredientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavouritedRecipes",
                table: "FavouritedRecipes",
                columns: new[] { "RecipeId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompletedRecipes",
                table: "CompletedRecipes",
                columns: new[] { "RecipeId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedRecipes_Recipes_RecipeId",
                table: "CompletedRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedRecipes_Users_UserId",
                table: "CompletedRecipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavouritedRecipes_Recipes_RecipeId",
                table: "FavouritedRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavouritedRecipes_Users_UserId",
                table: "FavouritedRecipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedRecipes_Recipes_RecipeId",
                table: "CompletedRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_CompletedRecipes_Users_UserId",
                table: "CompletedRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_FavouritedRecipes_Recipes_RecipeId",
                table: "FavouritedRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_FavouritedRecipes_Users_UserId",
                table: "FavouritedRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavouritedRecipes",
                table: "FavouritedRecipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompletedRecipes",
                table: "CompletedRecipes");

            migrationBuilder.RenameTable(
                name: "RecipeIngredients",
                newName: "RecipeIngredient");

            migrationBuilder.RenameTable(
                name: "FavouritedRecipes",
                newName: "FavouritedRecipe");

            migrationBuilder.RenameTable(
                name: "CompletedRecipes",
                newName: "CompletedRecipe");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredient",
                newName: "IX_RecipeIngredient_IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_FavouritedRecipes_UserId",
                table: "FavouritedRecipe",
                newName: "IX_FavouritedRecipe_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CompletedRecipes_UserId",
                table: "CompletedRecipe",
                newName: "IX_CompletedRecipe_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredient",
                table: "RecipeIngredient",
                columns: new[] { "RecipeId", "IngredientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavouritedRecipe",
                table: "FavouritedRecipe",
                columns: new[] { "RecipeId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompletedRecipe",
                table: "CompletedRecipe",
                columns: new[] { "RecipeId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedRecipe_Recipes_RecipeId",
                table: "CompletedRecipe",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedRecipe_Users_UserId",
                table: "CompletedRecipe",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavouritedRecipe_Recipes_RecipeId",
                table: "FavouritedRecipe",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavouritedRecipe_Users_UserId",
                table: "FavouritedRecipe",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Ingredients_IngredientId",
                table: "RecipeIngredient",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Recipes_RecipeId",
                table: "RecipeIngredient",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
