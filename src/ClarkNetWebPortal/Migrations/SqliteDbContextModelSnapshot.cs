using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ClarkNetWebPortal.DbContexts;
using ClarkNetWebPortal.Models;

namespace ClarkNetWebPortal.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("ClarkNetWebPortal.Models.Host", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("NameOrIpAddress")
                        .IsRequired();

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.ToTable("Hosts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Host");
                });

            modelBuilder.Entity("ClarkNetWebPortal.Models.Application", b =>
                {
                    b.HasBaseType("ClarkNetWebPortal.Models.Host");

                    b.Property<string>("AtHost");

                    b.Property<string>("HomePath");

                    b.Property<int?>("PortNumber");

                    b.Property<byte>("Protocol");

                    b.Property<string>("TestPath");

                    b.ToTable("Application");

                    b.HasDiscriminator().HasValue("Application");
                });

            modelBuilder.Entity("ClarkNetWebPortal.Models.IpCamera", b =>
                {
                    b.HasBaseType("ClarkNetWebPortal.Models.Application");

                    b.Property<string>("VideoPath");

                    b.ToTable("IpCamera");

                    b.HasDiscriminator().HasValue("IpCamera");
                });

            modelBuilder.Entity("ClarkNetWebPortal.Models.NetworkAppliance", b =>
                {
                    b.HasBaseType("ClarkNetWebPortal.Models.Application");


                    b.ToTable("NetworkAppliance");

                    b.HasDiscriminator().HasValue("NetworkAppliance");
                });
        }
    }
}
