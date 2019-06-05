﻿// <auto-generated />
using System;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreEntitity.Migrations
{
    [DbContext(typeof(IdnDBContext))]
    partial class IdnDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasMaxLength(100);

                    b.Property<string>("PrivilegeTypeid")
                        .HasColumnName("PRIVILEGETYPE_ID");

                    b.Property<string>("Privilegeid")
                        .HasColumnName("PRIVILEGE_ID");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATED_DATE");

                    b.Property<string>("VersionNumber")
                        .HasColumnName("VERSION_NUMBER")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.HasIndex("PrivilegeTypeid");

                    b.HasIndex("Privilegeid");

                    b.ToTable("IDN_MST_CLAIMS");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasMaxLength(100);

                    b.Property<bool>("Status")
                        .HasColumnName("Status");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATED_DATE");

                    b.Property<DateTime?>("ValidateFrom")
                        .HasColumnName("VALID_FROM");

                    b.Property<DateTime?>("ValidateTo")
                        .HasColumnName("VALID_TO");

                    b.Property<string>("VersionNumber")
                        .HasColumnName("VERSION_NUMBER")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.ToTable("IDN_MST_GROUP");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClaimsId")
                        .HasColumnName("CLAIMS_ID");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATEDBY");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATEDDATE");

                    b.Property<string>("RoleId")
                        .HasColumnName("ROLE_ID");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATEDBY");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATEDDATE");

                    b.Property<string>("VersionNo")
                        .HasColumnName("VERSIONNO");

                    b.HasKey("Id");

                    b.HasIndex("ClaimsId");

                    b.ToTable("IDN_TRN_CLAIMS");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+Privilege", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasMaxLength(100);

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATED_DATE");

                    b.Property<string>("VersionNumber")
                        .HasColumnName("VERSION_NUMBER")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.ToTable("IDN_MST_PRIVILEGE");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+PrivilegeType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasMaxLength(100);

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATED_DATE");

                    b.Property<string>("VersionNumber")
                        .HasColumnName("VERSION_NUMBER")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.ToTable("IDN_MST_PRIVILEGE_TYPE");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+RoleDetail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasMaxLength(1000);

                    b.Property<int>("ROLE_TYPEID");

                    b.Property<int>("RoleCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ROLE_CODE")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role_Id")
                        .HasColumnName("ROLE_ID");

                    b.Property<int?>("RolesTypeIdId");

                    b.Property<bool>("Status")
                        .HasColumnName("Status");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATED_DATE");

                    b.Property<DateTime?>("ValidateFrom")
                        .HasColumnName("VALID_FROM");

                    b.Property<DateTime?>("ValidateTo")
                        .HasColumnName("VALID_TO");

                    b.Property<string>("VersionNumber")
                        .HasColumnName("VERSION_NUMBER")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.HasIndex("RolesTypeIdId");

                    b.ToTable("IDN_TRN_ROLEDETAILS");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+RolePrivilegeType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("PrivilegeTypesId");

                    b.Property<int>("Privilege_Id");

                    b.Property<int>("Privilege_Type_Id");

                    b.Property<string>("PrivilegesId");

                    b.Property<string>("Role_Id");

                    b.Property<string>("RolesId");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATED_DATE");

                    b.Property<string>("VersionNumber")
                        .HasColumnName("VERSION_NUMBER")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.HasIndex("PrivilegeTypesId");

                    b.HasIndex("PrivilegesId");

                    b.HasIndex("RolesId");

                    b.ToTable("IDN_TRN_ROLE_PRIVILEGE_TYPE");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+RoleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATED_DATE");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasMaxLength(1000);

                    b.Property<string>("RoleTypeName")
                        .HasColumnName("ROLE_TYPE")
                        .HasMaxLength(100);

                    b.Property<bool>("Status")
                        .HasColumnName("STATUS");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATED_DATE");

                    b.Property<string>("VersionNumber")
                        .HasColumnName("VERSION_NUMBER")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.ToTable("IDN_MST_ROLE_TYPE");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+Status", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("IDN_MST_USER_STATUS");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId")
                        .HasColumnName("GROUP_ID");

                    b.Property<int>("UserCode")
                        .HasColumnName("USER_CODE");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("IDN_TRN_USER_GROUP");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("IDN_MST_ROLE");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

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

                    b.ToTable("IDN_TRN_USER");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("IDN_TRN_ROLE");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("CREATED_DATE");

                    b.Property<int>("RoleCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ROLE_CODE")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UPDATED_BY")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("UPDATED_DATE");

                    b.Property<DateTime?>("ValidateFrom")
                        .HasColumnName("VALID_FROM");

                    b.Property<DateTime?>("ValidateTo")
                        .HasColumnName("VALID_TO");

                    b.Property<string>("VersionNumber")
                        .HasColumnName("VERSION_NUMBER")
                        .HasMaxLength(11);

                    b.ToTable("IDN_MST_ROLE");

                    b.HasDiscriminator().HasValue("Role");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Mobile")
                        .HasColumnName("Mobile");

                    b.Property<int>("PrimaryGroupId");

                    b.Property<string>("ProfileImgName")
                        .HasColumnName("ProfileImageName");

                    b.Property<string>("RefreshToken");

                    b.Property<string>("SessionId");

                    b.Property<string>("Status_Id")
                        .HasColumnName("Status_Id");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int>("UserCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("USER_CODE")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ValidateFrom")
                        .HasColumnName("VALID_FROM");

                    b.Property<DateTime?>("ValidateTo")
                        .HasColumnName("VALID_TO");

                    b.HasIndex("Status_Id");

                    b.ToTable("IDN_TRN_USER");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+Claim", b =>
                {
                    b.HasOne("EFCore.Entities.IdnDBContext+PrivilegeType", "PrivilegeType")
                        .WithMany()
                        .HasForeignKey("PrivilegeTypeid");

                    b.HasOne("EFCore.Entities.IdnDBContext+Privilege", "Privilege")
                        .WithMany()
                        .HasForeignKey("Privilegeid");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+Permission", b =>
                {
                    b.HasOne("EFCore.Entities.IdnDBContext+Claim", "Claims")
                        .WithMany()
                        .HasForeignKey("ClaimsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+RoleDetail", b =>
                {
                    b.HasOne("EFCore.Entities.IdnDBContext+RoleType", "RolesTypeId")
                        .WithMany()
                        .HasForeignKey("RolesTypeIdId");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+RolePrivilegeType", b =>
                {
                    b.HasOne("EFCore.Entities.IdnDBContext+PrivilegeType", "PrivilegeTypes")
                        .WithMany("RolePrivilegeType")
                        .HasForeignKey("PrivilegeTypesId");

                    b.HasOne("EFCore.Entities.IdnDBContext+Privilege", "Privileges")
                        .WithMany("RolePrivilegeType")
                        .HasForeignKey("PrivilegesId");

                    b.HasOne("EFCore.Entities.IdnDBContext+Role", "Roles")
                        .WithMany()
                        .HasForeignKey("RolesId");
                });

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+UserGroup", b =>
                {
                    b.HasOne("EFCore.Entities.IdnDBContext+Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFCore.Entities.IdnDBContext+User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId");
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

            modelBuilder.Entity("EFCore.Entities.IdnDBContext+User", b =>
                {
                    b.HasOne("EFCore.Entities.IdnDBContext+Status", "Status")
                        .WithMany()
                        .HasForeignKey("Status_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
