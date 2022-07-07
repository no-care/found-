﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using found.Data;

namespace found.Migrations
{
    [DbContext(typeof(DBContent))]
    [Migration("20220517104059_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("found.Data.Models.Advert", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.Property<string>("desc_long")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("desc_short")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isApprove")
                        .HasColumnType("bit");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("time")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("id");

                    b.HasIndex("Usersid");

                    b.ToTable("adv");
                });

            modelBuilder.Entity("found.Data.Models.Dialogs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Usersid")
                        .HasColumnType("int");

                    b.Property<int>("user1_id")
                        .HasColumnType("int");

                    b.Property<int>("user2_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Usersid");

                    b.ToTable("dialogs");
                });

            modelBuilder.Entity("found.Data.Models.Messages", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("datetime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dialogsid")
                        .HasColumnType("int");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("usersid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("dialogsid");

                    b.HasIndex("usersid");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("found.Data.Models.Roles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("found.Data.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("roleid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("roleid");

                    b.ToTable("users");
                });

            modelBuilder.Entity("found.Data.Models.Advert", b =>
                {
                    b.HasOne("found.Data.Models.Users", "Users")
                        .WithMany("Advert")
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("found.Data.Models.Dialogs", b =>
                {
                    b.HasOne("found.Data.Models.Users", "Users")
                        .WithMany("Dialogs")
                        .HasForeignKey("Usersid");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("found.Data.Models.Messages", b =>
                {
                    b.HasOne("found.Data.Models.Dialogs", "Dialogs")
                        .WithMany("Messages")
                        .HasForeignKey("dialogsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("found.Data.Models.Users", "Users")
                        .WithMany("Messages")
                        .HasForeignKey("usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialogs");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("found.Data.Models.Users", b =>
                {
                    b.HasOne("found.Data.Models.Roles", "Role")
                        .WithMany("Users")
                        .HasForeignKey("roleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("found.Data.Models.Dialogs", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("found.Data.Models.Roles", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("found.Data.Models.Users", b =>
                {
                    b.Navigation("Advert");

                    b.Navigation("Dialogs");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
