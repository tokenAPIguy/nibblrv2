﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(NibblrDbContext))]
    [Migration("20250308023352_updated tags prop 2")]
    partial class updatedtagsprop2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("RecipeTag", b =>
                {
                    b.Property<int>("RecipeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecipeID", "TagsID");

                    b.HasIndex("TagsID");

                    b.ToTable("RecipeTags", (string)null);
                });

            modelBuilder.Entity("Shared.Models.Ingredients", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<int>("RecipeID")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Weight")
                        .HasColumnType("REAL");

                    b.Property<string>("WeightUnit")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("RecipeID");

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

                    b.Property<int>("RecipeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Step")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("RecipeID");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("Shared.Models.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Bookmarked")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Carbs")
                        .HasColumnType("REAL");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<double>("Fat")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Protein")
                        .HasColumnType("REAL");

                    b.Property<int>("Servings")
                        .HasColumnType("INTEGER");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Shared.Models.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("RecipeTag", b =>
                {
                    b.HasOne("Shared.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Ingredients", b =>
                {
                    b.HasOne("Shared.Models.Recipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Instructions", b =>
                {
                    b.HasOne("Shared.Models.Recipe", null)
                        .WithMany("Instructions")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Recipe", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Instructions");
                });
#pragma warning restore 612, 618
        }
    }
}
