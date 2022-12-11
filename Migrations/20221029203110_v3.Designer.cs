﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp2.models;

#nullable disable

namespace WinFormsApp2.Migrations
{
    [DbContext(typeof(ITIDbcontext))]
    [Migration("20221029203110_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WinFormsApp2.models.Author", b =>
                {
                    b.Property<int>("author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("author_id"), 1L, 1);

                    b.Property<int>("author_age")
                        .HasColumnType("int");

                    b.Property<string>("author_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("author_isBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("author_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("author_id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("WinFormsApp2.models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("blog_desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blog_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ownerid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ownerid")
                        .IsUnique();

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("WinFormsApp2.models.Owner", b =>
                {
                    b.Property<int>("owner_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("owner_id"), 1L, 1);

                    b.Property<int>("owner_age")
                        .HasColumnType("int");

                    b.Property<string>("owner_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("owner_id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("WinFormsApp2.models.Post", b =>
                {
                    b.Property<int>("post_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("post_id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("post_brief")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("post_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("post_desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("post_media")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("post_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("post_id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WinFormsApp2.models.Blog", b =>
                {
                    b.HasOne("WinFormsApp2.models.Owner", "owner")
                        .WithOne("blog")
                        .HasForeignKey("WinFormsApp2.models.Blog", "ownerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");
                });

            modelBuilder.Entity("WinFormsApp2.models.Post", b =>
                {
                    b.HasOne("WinFormsApp2.models.Author", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp2.models.Blog", "blog")
                        .WithMany("posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("blog");
                });

            modelBuilder.Entity("WinFormsApp2.models.Author", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("WinFormsApp2.models.Blog", b =>
                {
                    b.Navigation("posts");
                });

            modelBuilder.Entity("WinFormsApp2.models.Owner", b =>
                {
                    b.Navigation("blog")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
