﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Data;

namespace WebApp.Migrations
{
    [DbContext(typeof(TriumphDbContext))]
    partial class TriumphDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApp.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedToIDEmpID");

                    b.Property<string>("BusinessName");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("ClientID");

                    b.HasIndex("AssignedToIDEmpID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WebApp.Models.Client+Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientID");

                    b.Property<int?>("ClientVMClientID");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("NoteId");

                    b.HasIndex("ClientID");

                    b.HasIndex("ClientVMClientID");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("WebApp.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerID");

                    b.Property<string>("State");

                    b.Property<int>("Status");

                    b.Property<string>("Zip");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("WebApp.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientVMClientID");

                    b.Property<string>("Email");

                    b.Property<int>("EnumRoles");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Notes");

                    b.Property<string>("Phone");

                    b.HasKey("EmpID");

                    b.HasIndex("ClientVMClientID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApp.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedClientIDClientID");

                    b.Property<string>("Attributes");

                    b.Property<DateTime>("DueDate");

                    b.Property<int?>("EmpFullNameEmpID");

                    b.Property<int?>("EmployeeIDEmpID");

                    b.Property<string>("Name");

                    b.Property<string>("Priority");

                    b.HasKey("ID");

                    b.HasIndex("AssignedClientIDClientID");

                    b.HasIndex("EmpFullNameEmpID");

                    b.HasIndex("EmployeeIDEmpID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebApp.ViewModel.ClientVM", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessName");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email");

                    b.Property<int?>("EmployeeVMEmpID");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("ClientID");

                    b.HasIndex("EmployeeVMEmpID");

                    b.ToTable("ClientVMs");
                });

            modelBuilder.Entity("WebApp.ViewModel.EmployeeVM", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int>("EnumRoles");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Notes");

                    b.Property<string>("Phone");

                    b.HasKey("EmpID");

                    b.ToTable("EmployeeVMs");
                });

            modelBuilder.Entity("WebApp.ViewModel.ProjectVM", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedClientIDClientID");

                    b.Property<string>("Attributes");

                    b.Property<DateTime>("DueDate");

                    b.Property<int?>("EmpFullNameEmpID");

                    b.Property<int?>("EmployeeIDEmpID");

                    b.Property<int?>("EmployeeVMEmpID");

                    b.Property<string>("Name");

                    b.Property<string>("Priority");

                    b.HasKey("ID");

                    b.HasIndex("AssignedClientIDClientID");

                    b.HasIndex("EmpFullNameEmpID");

                    b.HasIndex("EmployeeIDEmpID");

                    b.HasIndex("EmployeeVMEmpID");

                    b.ToTable("ProjectVMs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApp.Models.Client", b =>
                {
                    b.HasOne("WebApp.Models.Employee", "AssignedToID")
                        .WithMany()
                        .HasForeignKey("AssignedToIDEmpID");
                });

            modelBuilder.Entity("WebApp.Models.Client+Note", b =>
                {
                    b.HasOne("WebApp.Models.Client")
                        .WithMany("Notes")
                        .HasForeignKey("ClientID");

                    b.HasOne("WebApp.ViewModel.ClientVM")
                        .WithMany("Notes")
                        .HasForeignKey("ClientVMClientID");
                });

            modelBuilder.Entity("WebApp.Models.Employee", b =>
                {
                    b.HasOne("WebApp.ViewModel.ClientVM")
                        .WithMany("Assigned")
                        .HasForeignKey("ClientVMClientID");
                });

            modelBuilder.Entity("WebApp.Models.Project", b =>
                {
                    b.HasOne("WebApp.Models.Client", "AssignedClientID")
                        .WithMany()
                        .HasForeignKey("AssignedClientIDClientID");

                    b.HasOne("WebApp.Models.Employee", "EmpFullName")
                        .WithMany()
                        .HasForeignKey("EmpFullNameEmpID");

                    b.HasOne("WebApp.Models.Employee", "EmployeeID")
                        .WithMany()
                        .HasForeignKey("EmployeeIDEmpID");
                });

            modelBuilder.Entity("WebApp.ViewModel.ClientVM", b =>
                {
                    b.HasOne("WebApp.ViewModel.EmployeeVM")
                        .WithMany("Clients")
                        .HasForeignKey("EmployeeVMEmpID");
                });

            modelBuilder.Entity("WebApp.ViewModel.ProjectVM", b =>
                {
                    b.HasOne("WebApp.Models.Client", "AssignedClientID")
                        .WithMany()
                        .HasForeignKey("AssignedClientIDClientID");

                    b.HasOne("WebApp.Models.Employee", "EmpFullName")
                        .WithMany()
                        .HasForeignKey("EmpFullNameEmpID");

                    b.HasOne("WebApp.Models.Employee", "EmployeeID")
                        .WithMany()
                        .HasForeignKey("EmployeeIDEmpID");

                    b.HasOne("WebApp.ViewModel.EmployeeVM")
                        .WithMany("Projects")
                        .HasForeignKey("EmployeeVMEmpID");
                });
#pragma warning restore 612, 618
        }
    }
}
