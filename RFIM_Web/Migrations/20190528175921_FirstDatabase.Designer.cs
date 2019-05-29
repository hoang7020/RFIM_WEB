﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RFIM_Web.Models;

namespace RFIM_Web.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190528175921_FirstDatabase")]
    partial class FirstDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RFIM_Web.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasMaxLength(20);

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("RFIM_Web.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(50);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Fullname")
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasMaxLength(120);

                    b.Property<string>("Password")
                        .HasMaxLength(32);

                    b.Property<string>("Phone");

                    b.Property<int>("RoleId");

                    b.Property<bool>("Status");

                    b.Property<string>("Username")
                        .HasMaxLength(32);

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RFIM_Web.Models.User", b =>
                {
                    b.HasOne("RFIM_Web.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
