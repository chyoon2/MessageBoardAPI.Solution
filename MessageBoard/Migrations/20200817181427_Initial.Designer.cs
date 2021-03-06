﻿// <auto-generated />
using System;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    [Migration("20200817181427_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoard.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("BoardId");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("MessageBoard.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<int?>("ParentThreadThreadId");

                    b.Property<string>("PostBody");

                    b.Property<string>("Title");

                    b.Property<int?>("UserId");

                    b.HasKey("PostId");

                    b.HasIndex("ParentThreadThreadId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("MessageBoard.Models.Thread", b =>
                {
                    b.Property<int>("ThreadId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<int?>("ParentBoardBoardId");

                    b.Property<string>("Title");

                    b.Property<int?>("UserId");

                    b.HasKey("ThreadId");

                    b.HasIndex("ParentBoardBoardId");

                    b.HasIndex("UserId");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("MessageBoard.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MessageBoard.Models.Post", b =>
                {
                    b.HasOne("MessageBoard.Models.Thread", "ParentThread")
                        .WithMany("Posts")
                        .HasForeignKey("ParentThreadThreadId");

                    b.HasOne("MessageBoard.Models.User", "User")
                        .WithMany("UserPosts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MessageBoard.Models.Thread", b =>
                {
                    b.HasOne("MessageBoard.Models.Board", "ParentBoard")
                        .WithMany("Threads")
                        .HasForeignKey("ParentBoardBoardId");

                    b.HasOne("MessageBoard.Models.User", "User")
                        .WithMany("UserThreads")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
