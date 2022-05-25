﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TennisApp;

#nullable disable

namespace TennisApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220525111939_all2")]
    partial class all2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("TennisApp.Court", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Club")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CourtNumber")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Lights")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surface")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Courts");
                });

            modelBuilder.Entity("TennisApp.Match", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isFinished")
                        .HasColumnType("INTEGER");

                    b.Property<string>("score")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("TennisApp.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CourtID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Match")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MatchID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TournamentID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CourtID");

                    b.HasIndex("MatchID");

                    b.HasIndex("TournamentID");

                    b.HasIndex("UserID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("TennisApp.Tournament", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("TEXT");

                    b.Property<int>("minSkillLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("winnerRewards")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("TennisApp.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FavClub")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FavSurface")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Racket")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("RightHanded")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TournamentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("TournamentID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TennisApp.Match", b =>
                {
                    b.HasOne("TennisApp.User", null)
                        .WithMany("Matches")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("TennisApp.Reservation", b =>
                {
                    b.HasOne("TennisApp.Court", null)
                        .WithMany("Reservations")
                        .HasForeignKey("CourtID");

                    b.HasOne("TennisApp.Match", null)
                        .WithMany("Reservations")
                        .HasForeignKey("MatchID");

                    b.HasOne("TennisApp.Tournament", null)
                        .WithMany("Reservations")
                        .HasForeignKey("TournamentID");

                    b.HasOne("TennisApp.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TennisApp.User", b =>
                {
                    b.HasOne("TennisApp.Tournament", null)
                        .WithMany("Players")
                        .HasForeignKey("TournamentID");
                });

            modelBuilder.Entity("TennisApp.Court", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("TennisApp.Match", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("TennisApp.Tournament", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("TennisApp.User", b =>
                {
                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}