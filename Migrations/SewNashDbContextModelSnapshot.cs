﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SewNash.Data;

#nullable disable

namespace sewnash.Migrations
{
    [DbContext(typeof(SewNashDbContext))]
    partial class SewNashDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DayForAvailabilityTime", b =>
                {
                    b.Property<int>("DayForAvailabilitiesId")
                        .HasColumnType("integer");

                    b.Property<int>("TimesId")
                        .HasColumnType("integer");

                    b.HasKey("DayForAvailabilitiesId", "TimesId");

                    b.HasIndex("TimesId");

                    b.ToTable("DayForAvailabilityTime");

                    b.HasData(
                        new
                        {
                            DayForAvailabilitiesId = 1,
                            TimesId = 1
                        },
                        new
                        {
                            DayForAvailabilitiesId = 2,
                            TimesId = 1
                        },
                        new
                        {
                            DayForAvailabilitiesId = 3,
                            TimesId = 2
                        },
                        new
                        {
                            DayForAvailabilitiesId = 4,
                            TimesId = 3
                        },
                        new
                        {
                            DayForAvailabilitiesId = 5,
                            TimesId = 3
                        });
                });

            modelBuilder.Entity("EmployeeSession", b =>
                {
                    b.Property<int>("EmployeesId")
                        .HasColumnType("integer");

                    b.Property<int>("SessionsId")
                        .HasColumnType("integer");

                    b.HasKey("EmployeesId", "SessionsId");

                    b.HasIndex("SessionsId");

                    b.ToTable("EmployeeSession");

                    b.HasData(
                        new
                        {
                            EmployeesId = 1,
                            SessionsId = 1
                        },
                        new
                        {
                            EmployeesId = 2,
                            SessionsId = 2
                        },
                        new
                        {
                            EmployeesId = 1,
                            SessionsId = 3
                        },
                        new
                        {
                            EmployeesId = 1,
                            SessionsId = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                            Name = "Admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a995700b-78bf-409b-8adf-1303b93b4591",
                            Email = "admina@strator.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEKjKVbkdcEL/LKPeM3Rf7t7RltTk1hcGgvS6f1ZvDer1a4pnkxajrFyGnXtKtEXnNg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eadc1757-a869-40b3-b7e1-7fd2c3897287",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        },
                        new
                        {
                            Id = "a4b9c99e-87ab-4c5a-9d53-1e3f5248a1b0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a41be096-c14d-4caf-895c-f2cddbb909a9",
                            Email = "johndoe@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEAgsoKBiApNc8bjerg5QvH0qsZwWExZ3r+s+0vniNAflAgigtHM7DoK8V+lEEKQ6dA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fc23d1ab-b65f-47c2-8a43-40e3aee363ed",
                            TwoFactorEnabled = false,
                            UserName = "JohnDoe"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SewNash.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("SewClassId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("SewClassId");

                    b.ToTable("Availabilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SewClassId = 1,
                            StartDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SewClassId = 2,
                            StartDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SewClassId = 3,
                            StartDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SewNash.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateBooked")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Occupancy")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SessionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateBooked = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test@test.com",
                            Name = "Carly Olds",
                            Occupancy = 2,
                            PhoneNumber = "123-456-7890",
                            SessionId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateBooked = new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test2@test.com",
                            Name = "Jane Smith",
                            Occupancy = 3,
                            PhoneNumber = "987-654-3210",
                            SessionId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateBooked = new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test3@test.com",
                            Name = "Alice Johnson",
                            Occupancy = 1,
                            PhoneNumber = "555-123-4567",
                            SessionId = 3
                        });
                });

            modelBuilder.Entity("SewNash.Models.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Days");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DayOfWeek = "Monday"
                        },
                        new
                        {
                            Id = 2,
                            DayOfWeek = "Tuesday"
                        },
                        new
                        {
                            Id = 3,
                            DayOfWeek = "Wednesday"
                        },
                        new
                        {
                            Id = 4,
                            DayOfWeek = "Thursday"
                        },
                        new
                        {
                            Id = 5,
                            DayOfWeek = "Friday"
                        },
                        new
                        {
                            Id = 6,
                            DayOfWeek = "Saturday"
                        },
                        new
                        {
                            Id = 7,
                            DayOfWeek = "Sunday"
                        });
                });

            modelBuilder.Entity("SewNash.Models.DayForAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailabilityId")
                        .HasColumnType("integer");

                    b.Property<int>("DayId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AvailabilityId");

                    b.HasIndex("DayId");

                    b.ToTable("DayForAvailabilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailabilityId = 1,
                            DayId = 1
                        },
                        new
                        {
                            Id = 2,
                            AvailabilityId = 1,
                            DayId = 3
                        },
                        new
                        {
                            Id = 3,
                            AvailabilityId = 2,
                            DayId = 5
                        },
                        new
                        {
                            Id = 4,
                            AvailabilityId = 3,
                            DayId = 6
                        },
                        new
                        {
                            Id = 5,
                            AvailabilityId = 3,
                            DayId = 7
                        });
                });

            modelBuilder.Entity("SewNash.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IdentityUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admina@strator.comx",
                            FirstName = "Admina",
                            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            LastName = "Strator",
                            PhoneNumber = "123-123-1234"
                        },
                        new
                        {
                            Id = 2,
                            Email = "johndoe@example.com",
                            FirstName = "John",
                            IdentityUserId = "a4b9c99e-87ab-4c5a-9d53-1e3f5248a1b0",
                            LastName = "Doe",
                            PhoneNumber = "222-222-2222"
                        });
                });

            modelBuilder.Entity("SewNash.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FileKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("MainPhoto")
                        .HasColumnType("boolean");

                    b.Property<int?>("SewClassId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SewClassId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("SewNash.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DayId")
                        .HasColumnType("integer");

                    b.Property<bool>("Open")
                        .HasColumnType("boolean");

                    b.Property<int>("SewClassId")
                        .HasColumnType("integer");

                    b.Property<int>("TimeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.HasIndex("SewClassId");

                    b.HasIndex("TimeId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Utc),
                            DayId = 1,
                            Open = true,
                            SewClassId = 1,
                            TimeId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateTime = new DateTime(2025, 1, 16, 20, 0, 0, 0, DateTimeKind.Utc),
                            DayId = 2,
                            Open = true,
                            SewClassId = 2,
                            TimeId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateTime = new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc),
                            DayId = 5,
                            Open = true,
                            SewClassId = 3,
                            TimeId = 3
                        });
                });

            modelBuilder.Entity("SewNash.Models.SewClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<int>("MaxPeople")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PricePerPerson")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("SewClasses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Learn to build a bag.",
                            Duration = 2,
                            MaxPeople = 8,
                            Name = "Bag class",
                            PricePerPerson = 50.00m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Learn to build a Dog Bandana.",
                            Duration = 2,
                            MaxPeople = 6,
                            Name = "Dog Bandana",
                            PricePerPerson = 75.00m
                        });
                });

            modelBuilder.Entity("SewNash.Models.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Times");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StartTime = "10:00 AM"
                        },
                        new
                        {
                            Id = 2,
                            StartTime = "11:00 AM"
                        },
                        new
                        {
                            Id = 3,
                            StartTime = "12:00 PM"
                        },
                        new
                        {
                            Id = 4,
                            StartTime = "01:00 PM"
                        },
                        new
                        {
                            Id = 5,
                            StartTime = "02:00 PM"
                        },
                        new
                        {
                            Id = 6,
                            StartTime = "03:00 PM"
                        },
                        new
                        {
                            Id = 7,
                            StartTime = "04:00 PM"
                        },
                        new
                        {
                            Id = 8,
                            StartTime = "05:00 PM"
                        },
                        new
                        {
                            Id = 9,
                            StartTime = "06:00 PM"
                        },
                        new
                        {
                            Id = 10,
                            StartTime = "07:00 PM"
                        },
                        new
                        {
                            Id = 11,
                            StartTime = "08:00 PM"
                        });
                });

            modelBuilder.Entity("DayForAvailabilityTime", b =>
                {
                    b.HasOne("SewNash.Models.DayForAvailability", null)
                        .WithMany()
                        .HasForeignKey("DayForAvailabilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SewNash.Models.Time", null)
                        .WithMany()
                        .HasForeignKey("TimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeSession", b =>
                {
                    b.HasOne("SewNash.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SewNash.Models.Session", null)
                        .WithMany()
                        .HasForeignKey("SessionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SewNash.Models.Availability", b =>
                {
                    b.HasOne("SewNash.Models.SewClass", "SewClass")
                        .WithMany("Availabilities")
                        .HasForeignKey("SewClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SewClass");
                });

            modelBuilder.Entity("SewNash.Models.Booking", b =>
                {
                    b.HasOne("SewNash.Models.Session", "Session")
                        .WithMany("Bookings")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");
                });

            modelBuilder.Entity("SewNash.Models.DayForAvailability", b =>
                {
                    b.HasOne("SewNash.Models.Availability", "Availability")
                        .WithMany("DaysAndTimes")
                        .HasForeignKey("AvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SewNash.Models.Day", "Day")
                        .WithMany()
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Availability");

                    b.Navigation("Day");
                });

            modelBuilder.Entity("SewNash.Models.Employee", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("SewNash.Models.Photo", b =>
                {
                    b.HasOne("SewNash.Models.SewClass", "SewClass")
                        .WithMany("Photos")
                        .HasForeignKey("SewClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("SewClass");
                });

            modelBuilder.Entity("SewNash.Models.Session", b =>
                {
                    b.HasOne("SewNash.Models.Day", "Day")
                        .WithMany()
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SewNash.Models.SewClass", "SewClass")
                        .WithMany("Sessions")
                        .HasForeignKey("SewClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SewNash.Models.Time", "Time")
                        .WithMany()
                        .HasForeignKey("TimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("SewClass");

                    b.Navigation("Time");
                });

            modelBuilder.Entity("SewNash.Models.Availability", b =>
                {
                    b.Navigation("DaysAndTimes");
                });

            modelBuilder.Entity("SewNash.Models.Session", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("SewNash.Models.SewClass", b =>
                {
                    b.Navigation("Availabilities");

                    b.Navigation("Photos");

                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
