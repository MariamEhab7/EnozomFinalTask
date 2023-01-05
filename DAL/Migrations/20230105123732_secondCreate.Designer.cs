﻿// <auto-generated />
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(CountryDbContext))]
    [Migration("20230105123732_secondCreate")]
    partial class secondCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CountryHoliday", b =>
                {
                    b.Property<string>("CountriesCode")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("itemsetag")
                        .HasColumnType("varchar(255)");

                    b.HasKey("CountriesCode", "itemsetag");

                    b.HasIndex("itemsetag");

                    b.ToTable("CountryHoliday");
                });

            modelBuilder.Entity("DAL.Country", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Iso3")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Code");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DAL.creator", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("displayName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("self")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("email");

                    b.ToTable("creator");
                });

            modelBuilder.Entity("DAL.Holiday", b =>
                {
                    b.Property<string>("etag")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("created")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("creatoremail")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("end")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("eventType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("htmlLink")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("iCalUID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("kind")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("organizeremail")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("sequence")
                        .HasColumnType("int");

                    b.Property<string>("start")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("summary")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("transparency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("updated")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("visibility")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("etag");

                    b.HasIndex("creatoremail");

                    b.HasIndex("organizeremail");

                    b.ToTable("Holidays");
                });

            modelBuilder.Entity("DAL.organizer", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("displayName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("self")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("email");

                    b.ToTable("organizer");
                });

            modelBuilder.Entity("DAL.PopulationCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(255)");

                    b.Property<ulong>("Value")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryCode");

                    b.ToTable("Populations");
                });

            modelBuilder.Entity("CountryHoliday", b =>
                {
                    b.HasOne("DAL.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Holiday", null)
                        .WithMany()
                        .HasForeignKey("itemsetag")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Holiday", b =>
                {
                    b.HasOne("DAL.creator", "creator")
                        .WithMany()
                        .HasForeignKey("creatoremail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.organizer", "organizer")
                        .WithMany()
                        .HasForeignKey("organizeremail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("creator");

                    b.Navigation("organizer");
                });

            modelBuilder.Entity("DAL.PopulationCount", b =>
                {
                    b.HasOne("DAL.Country", "Country")
                        .WithMany("PopulationCounts")
                        .HasForeignKey("CountryCode");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DAL.Country", b =>
                {
                    b.Navigation("PopulationCounts");
                });
#pragma warning restore 612, 618
        }
    }
}