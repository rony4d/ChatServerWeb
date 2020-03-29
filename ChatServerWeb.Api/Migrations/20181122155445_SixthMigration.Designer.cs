﻿// <auto-generated />
using System;
using ChatServerWeb.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace ChatServerWeb.Api.Migrations
{
    [DbContext(typeof(ChatServerDbContext))]
    [Migration("20181122155445_SixthMigration")]
    partial class SixthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChatServerWeb.Model.Entity.ChatApplication", b =>
                {
                    b.Property<string>("AppId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppName");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsActive");

                    b.HasKey("AppId");

                    b.ToTable("ChatApplications");
                });

            modelBuilder.Entity("ChatServerWeb.Model.Entity.ChatApplicationUser", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("AppId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<string>("GroupId");

                    b.Property<int>("Status");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.HasIndex("AppId");

                    b.HasIndex("GroupId");

                    b.ToTable("ChatApplicationUsers");
                });

            modelBuilder.Entity("ChatServerWeb.Model.Entity.ChatGroup", b =>
                {
                    b.Property<string>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppId");

                    b.Property<string>("CreatedByUser");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("GroupName");

                    b.Property<int>("NumberOfMembers");

                    b.HasKey("GroupId");

                    b.HasIndex("AppId");

                    b.ToTable("ChatGroups");
                });

            modelBuilder.Entity("ChatServerWeb.Model.Entity.ChatMessage", b =>
                {
                    b.Property<string>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("GroupId");

                    b.Property<int>("GroupType");

                    b.Property<string>("Message");

                    b.Property<int>("Status");

                    b.Property<string>("UserEmail");

                    b.Property<string>("Username");

                    b.HasKey("MessageId");

                    b.HasIndex("AppId");

                    b.HasIndex("GroupId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("ChatServerWeb.Model.Entity.ChatSettings", b =>
                {
                    b.Property<string>("SettingsId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("Language");

                    b.HasKey("SettingsId");

                    b.ToTable("ChatSettings");
                });

            modelBuilder.Entity("ChatServerWeb.Model.Entity.ChatApplicationUser", b =>
                {
                    b.HasOne("ChatServerWeb.Model.Entity.ChatApplication", "ChatApplication")
                        .WithMany()
                        .HasForeignKey("AppId");

                    b.HasOne("ChatServerWeb.Model.Entity.ChatGroup", "ChatGroup")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("ChatServerWeb.Model.Entity.ChatGroup", b =>
                {
                    b.HasOne("ChatServerWeb.Model.Entity.ChatApplication", "ChatApplication")
                        .WithMany()
                        .HasForeignKey("AppId");
                });

            modelBuilder.Entity("ChatServerWeb.Model.Entity.ChatMessage", b =>
                {
                    b.HasOne("ChatServerWeb.Model.Entity.ChatApplication", "ChatApplication")
                        .WithMany()
                        .HasForeignKey("AppId");

                    b.HasOne("ChatServerWeb.Model.Entity.ChatGroup", "ChatGroup")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
