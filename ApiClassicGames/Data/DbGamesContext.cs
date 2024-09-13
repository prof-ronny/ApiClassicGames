using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiClassicGames.Models;

namespace ApiClassicGames.Data
{
    public class DbGamesContext : DbContext
    {
        public DbGamesContext (DbContextOptions<DbGamesContext> options)
            : base(options)
        {
        }

        public DbSet<ApiClassicGames.Models.ClassicGame> ClassicGame { get; set; } = default!;

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassicGame>().HasData(
                new ClassicGame { 
                    Id=1, 
                    Ano = 1991, 
                    Categoria = "Luta",
                    Descricao="This is Street Fighter",
                    Nome = "Street Fighter II", Desenvolvedor = "CAPCOM",
                    Foto = "https://game.capcom.com/manual/CFC/locale/page/101_3_1.jpg?t=202209261200",
                    Plataforma = "Arcade", Publicador="CAPCOM",
                    Status="Ativo"
                },
                new ClassicGame
                {
                    Id = 2,
                    Ano = 1992,
                    Categoria = "Luta",
                    Descricao = "Fight for your life",
                    Nome = "Mortal Kombat",
                    Desenvolvedor = "Midway",
                    Foto = "https://s2-techtudo.glbimg.com/GkH4Ha_ebZMOzoDnBJqUIwfuVnE=/0x0:695x442/1000x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_08fbf48bc0524877943fe86e43087e7a/internal_photos/bs/2021/V/T/tTvJnBQYeobx3NwcwESQ/2015-06-29-mortalkombat-1992.jpg",
                    Plataforma = "Arcade",
                    Publicador = "Warner",
                    Status = "Ativo"
                }

            );
        }
    }
}
