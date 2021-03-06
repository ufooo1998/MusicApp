﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApp.Data;

namespace MusicApp.Migrations
{
    [DbContext(typeof(MusicAppContext))]
    partial class MusicAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Decription");

                    b.Property<string>("Name");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MusicApp.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Singer");

                    b.Property<string>("Url");

                    b.HasKey("SongID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("MusicApp.Models.SongCategory", b =>
                {
                    b.Property<int>("SongID");

                    b.Property<int>("CategoryID");

                    b.HasKey("SongID", "CategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("SongCategory");
                });

            modelBuilder.Entity("MusicApp.Models.SongCategory", b =>
                {
                    b.HasOne("MusicApp.Models.Category", "category")
                        .WithMany("SongCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MusicApp.Models.Song", "song")
                        .WithMany("SongCategories")
                        .HasForeignKey("SongID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
