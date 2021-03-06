﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookup.Models;

namespace ParksLookup.Migrations
{
    [DbContext(typeof(ParksLookupContext))]
    partial class ParksLookupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksLookup.Models.Landmark", b =>
                {
                    b.Property<int>("LandmarkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ParkId");

                    b.HasKey("LandmarkId");

                    b.HasIndex("ParkId");

                    b.ToTable("Landmarks");

                    b.HasData(
                        new
                        {
                            LandmarkId = 1,
                            Name = "Yosemite Valley",
                            ParkId = 1
                        },
                        new
                        {
                            LandmarkId = 2,
                            Name = "Half Dome",
                            ParkId = 1
                        },
                        new
                        {
                            LandmarkId = 3,
                            Name = "YosemiteFalls",
                            ParkId = 1
                        },
                        new
                        {
                            LandmarkId = 4,
                            Name = "Mystery Shack",
                            ParkId = 2
                        },
                        new
                        {
                            LandmarkId = 5,
                            Name = "Gravity Falls Forest",
                            ParkId = 2
                        },
                        new
                        {
                            LandmarkId = 6,
                            Name = "Lake Gravity falls",
                            ParkId = 2
                        },
                        new
                        {
                            LandmarkId = 7,
                            Name = "The Narrows",
                            ParkId = 3
                        },
                        new
                        {
                            LandmarkId = 8,
                            Name = "Angels Landing",
                            ParkId = 3
                        },
                        new
                        {
                            LandmarkId = 9,
                            Name = "Emerald Pools Trail",
                            ParkId = 3
                        });
                });

            modelBuilder.Entity("ParksLookup.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Hours");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhotoUrl");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Classification = "National",
                            Hours = "24/7",
                            Name = "Yosemite",
                            PhotoUrl = "https://www.nationalgeographic.com/content/dam/expeditions/destinations/north-america/private/Yosemite/Hero-Yosemite.ngsversion.1524840074980.adapt.1900.1.jpg",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 2,
                            Classification = "State",
                            Hours = "25/8 (if you can find it)",
                            Name = "Gravity Falls",
                            PhotoUrl = "https://vignette.wikia.nocookie.net/gravityfalls/images/2/22/Opening_Bigfoot.png/revision/latest?cb=20160119145704",
                            State = "Oregon"
                        },
                        new
                        {
                            ParkId = 3,
                            Classification = "National",
                            Hours = "24/7",
                            Name = "Zion",
                            PhotoUrl = "https://www.nps.gov/npgallery/GetAsset/988A495E-155D-451F-67EE640C7B3812F6/proxy/hires?",
                            State = "Utah"
                        },
                        new
                        {
                            ParkId = 4,
                            Classification = "National",
                            Hours = "24/7",
                            Name = "Everglades",
                            PhotoUrl = "https://www.nps.gov/common/uploads/banner_image/akr/homepage/510DA558-1DD8-B71B-0BF2DBBE49B06F9F.jpg",
                            State = "Florida"
                        },
                        new
                        {
                            ParkId = 5,
                            Classification = "State",
                            Hours = "24/7",
                            Name = "Saint Edward",
                            PhotoUrl = "na",
                            State = "Washington"
                        },
                        new
                        {
                            ParkId = 6,
                            Classification = "State",
                            Hours = "24/7",
                            Name = "Britle Trails",
                            PhotoUrl = "na",
                            State = "Washington"
                        },
                        new
                        {
                            ParkId = 7,
                            Classification = "National",
                            Hours = "24/7",
                            Name = "Olympic",
                            PhotoUrl = "na",
                            State = "Washington"
                        },
                        new
                        {
                            ParkId = 8,
                            Classification = "State",
                            Hours = "24/7",
                            Name = "Unknown Forest",
                            PhotoUrl = "na",
                            State = "Over the Garden Wall"
                        },
                        new
                        {
                            ParkId = 9,
                            Classification = "National",
                            Hours = "24/7",
                            Name = "Lothlorien",
                            PhotoUrl = "na",
                            State = "Wilderland"
                        });
                });

            modelBuilder.Entity("ParksLookup.Models.Landmark", b =>
                {
                    b.HasOne("ParksLookup.Models.Park", "Park")
                        .WithMany("Landmarks")
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
