using AlbumApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlbumApp.Entities
{
    public class AlbumsDbContext : DbContext
    {
        public AlbumsDbContext(DbContextOptions<AlbumsDbContext> options)
            : base(options)
        {
        }

        // DbSet property for accessing Album entities
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Do your initializing/seeding here...
            modelBuilder.Entity<Album>().HasData(
                
                new Album { Id = 1, Title = "African Giant", Artist = "Burna Boy", Rating = 9.6m, Songs = "Dangote, Anybody, Gbona" },
                new Album { Id = 2, Title = "Carpe Diem", Artist = "Olamide", Rating = 8.8m, Songs = "Loading, Infinity, Triumphant" },
                new Album { Id = 3, Title = "No Bad Songz", Artist = "Kizz Daniel", Rating = 9.1m, Songs = "One Ticket, Madu, Bad" },
                new Album { Id = 4, Title = "Apollo", Artist = "Fireboy DML", Rating = 8.7m, Songs = "Champion, Tattoo, Remember Me" },
                new Album { Id = 5, Title = "Carpe Diem", Artist = "Olamide", Rating = 8.8m, Songs = "Loading, Infinity, Triumphant" },
                new Album { Id = 6, Title = "No Bad Songz", Artist = "Kizz Daniel", Rating = 9.1m, Songs = "One Ticket, Madu, Bad" },
                new Album { Id = 7, Title = "Apollo", Artist = "Fireboy DML", Rating = 8.7m, Songs = "Champion, Tattoo, Remember Me" },
                new Album { Id = 8, Title = "Afro Pop Vol. 1", Artist = "Adekunle Gold", Rating = 8.9m, Songs = "Something Different, Pretty Girl" },
                new Album { Id = 9, Title = "Rave & Roses", Artist = "Rema", Rating = 9.2m, Songs = "Soundgasm, Calm Down, FYN" }
            );
        }
    }
}

