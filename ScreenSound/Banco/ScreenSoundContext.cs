﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;
internal class ScreenSoundContext : DbContext
{
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Musica> Musicas { get; set; }

    private string connectionString = "Data Source=(localdb)\\\\MSSQLLocalDB;Initial Catalog=ScreenSound;\" +\r\n        \"Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;\" +\r\n        \"Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }
}