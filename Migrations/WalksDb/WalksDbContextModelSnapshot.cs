﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using auth_jwt_token_asp_net_core_web_api_with_sameer.Data;

#nullable disable

namespace auth_jwt_token_asp_net_core_web_api_with_sameer.Migrations.WalksDb
{
    [DbContext(typeof(WalksDbContext))]
    partial class WalksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("auth_jwt_token_asp_net_core_web_api_with_sameer.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("70cc45a7-fd24-4df7-aa30-0585cbabaaef"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("54d6af36-1448-4721-ac33-e1d241230e55"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("8c8d3b4d-80b2-4030-bae3-c5bc26f6aa13"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("auth_jwt_token_asp_net_core_web_api_with_sameer.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bff68585-2cd9-4a88-8e08-56e79c7ccf2d"),
                            Code = "AUC",
                            Name = "Auckland",
                            RegionImageUrl = ""
                        },
                        new
                        {
                            Id = new Guid("da0404b6-8afb-437f-ade3-9c028bbf624a"),
                            Code = "NOR",
                            Name = "Northland",
                            RegionImageUrl = ""
                        },
                        new
                        {
                            Id = new Guid("792319ea-0c5e-4556-a4ee-4f75134f41af"),
                            Code = "BOP",
                            Name = "Bay Of Plenty",
                            RegionImageUrl = ""
                        },
                        new
                        {
                            Id = new Guid("f70bbae4-f1c9-4506-9edc-a24bf8d3e629"),
                            Code = "WELL",
                            Name = "Wellinton",
                            RegionImageUrl = ""
                        });
                });

            modelBuilder.Entity("auth_jwt_token_asp_net_core_web_api_with_sameer.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uuid");

                    b.Property<double>("LengtInKm")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uuid");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("auth_jwt_token_asp_net_core_web_api_with_sameer.Models.Domain.Walk", b =>
                {
                    b.HasOne("auth_jwt_token_asp_net_core_web_api_with_sameer.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("auth_jwt_token_asp_net_core_web_api_with_sameer.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
