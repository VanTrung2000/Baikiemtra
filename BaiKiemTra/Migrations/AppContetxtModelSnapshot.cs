﻿// <auto-generated />
using System;
using BaiKiemTra.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaiKiemTra.Migrations
{
    [DbContext(typeof(AppContetxt))]
    partial class AppContetxtModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BaiKiemTra.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Tin Tuc"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Van Hoa"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Am Thuc"
                        });
                });

            modelBuilder.Entity("BaiKiemTra.Models.Pogtag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int?>("PostsId")
                        .HasColumnType("int");

                    b.Property<int?>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("PostsId");

                    b.HasIndex("TagsId");

                    b.ToTable("Pogtag");
                });

            modelBuilder.Entity("BaiKiemTra.Models.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int?>("TagsId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("TagsId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BaiKiemTra.Models.Tags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Tin Nong"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Con nguoi"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Mon Ngon"
                        });
                });

            modelBuilder.Entity("BaiKiemTra.Models.Pogtag", b =>
                {
                    b.HasOne("BaiKiemTra.Models.Posts", "Posts")
                        .WithMany("Pogtags")
                        .HasForeignKey("PostsId");

                    b.HasOne("BaiKiemTra.Models.Tags", "Tags")
                        .WithMany("pogtags")
                        .HasForeignKey("TagsId");
                });

            modelBuilder.Entity("BaiKiemTra.Models.Posts", b =>
                {
                    b.HasOne("BaiKiemTra.Models.Categories", "Categories")
                        .WithMany("Posts")
                        .HasForeignKey("CategoriesId");

                    b.HasOne("BaiKiemTra.Models.Tags", "Tags")
                        .WithMany("posts")
                        .HasForeignKey("TagsId");
                });
#pragma warning restore 612, 618
        }
    }
}
