using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiClassicGames.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassicGames",
                columns: new[] { "Id", "Ano", "Categoria", "Descricao", "Desenvolvedor", "Foto", "Nome", "Plataforma", "Publicador", "Status" },
                values: new object[] { 1, 1991, "Luta", "This is Street Fighter", "CAPCOM", "https://game.capcom.com/manual/CFC/locale/page/101_3_1.jpg?t=202209261200", "Street Fighter II", "Arcade", "CAPCOM", "Ativo" });

            migrationBuilder.InsertData(
                table: "ClassicGames",
                columns: new[] { "Id", "Ano", "Categoria", "Descricao", "Desenvolvedor", "Foto", "Nome", "Plataforma", "Publicador", "Status" },
                values: new object[] { 2, 1992, "Luta", "Fight for your life", "Midway", "https://s2-techtudo.glbimg.com/GkH4Ha_ebZMOzoDnBJqUIwfuVnE=/0x0:695x442/1000x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_08fbf48bc0524877943fe86e43087e7a/internal_photos/bs/2021/V/T/tTvJnBQYeobx3NwcwESQ/2015-06-29-mortalkombat-1992.jpg", "Mortal Kombat", "Arcade", "Warner", "Ativo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassicGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClassicGames",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
