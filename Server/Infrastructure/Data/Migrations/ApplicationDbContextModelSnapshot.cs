﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Infrastructure.Data;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Shared.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("RecipeId")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Shared.Models.Ingredients", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double?>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Weight")
                        .HasColumnType("REAL");

                    b.Property<string>("WeightUnit")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Shared.Models.Instructions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Step")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("RecipeId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("Shared.Models.Macros", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Carbs")
                        .HasColumnType("REAL");

                    b.Property<double>("Fat")
                        .HasColumnType("REAL");

                    b.Property<double>("Protein")
                        .HasColumnType("REAL");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("RecipeId")
                        .IsUnique();

                    b.ToTable("Macros");
                });

            modelBuilder.Entity("Shared.Models.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Bookmarked")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("URL")
                        .IsUnique();

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Shared.Models.Category", b =>
                {
                    b.HasOne("Shared.Models.Recipe", "Recipe")
                        .WithOne("Category")
                        .HasForeignKey("Shared.Models.Category", "RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Shared.Models.Ingredients", b =>
                {
                    b.HasOne("Shared.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Shared.Models.Instructions", b =>
                {
                    b.HasOne("Shared.Models.Recipe", "Recipe")
                        .WithMany("Instructions")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Shared.Models.Macros", b =>
                {
                    b.HasOne("Shared.Models.Recipe", "Recipe")
                        .WithOne("Macros")
                        .HasForeignKey("Shared.Models.Macros", "RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Shared.Models.Recipe", b =>
                {
                    b.Navigation("Category")
                        .IsRequired();

                    b.Navigation("Ingredients");

                    b.Navigation("Instructions");

                    b.Navigation("Macros")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
