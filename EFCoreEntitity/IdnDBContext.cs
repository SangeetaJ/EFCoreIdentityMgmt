using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCore.Entities
{
    public class IdnDBContext : IdentityDbContext
    {

        public IdnDBContext(DbContextOptions<IdnDBContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().ToTable("IDN_TRN_USER").Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<User>()
                .ToTable("IDN_TRN_USER").Property(p => p.Id).HasColumnName("Id");

            modelBuilder.Entity<User>().ToTable("IDN_TRN_USER").Property(p => p.UserCode).HasColumnName("USER_CODE");

            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("IDN_TRN_ROLE");
            modelBuilder.Entity<IdentityRole>().ToTable("IDN_MST_ROLE").Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<Role>()
                .ToTable("IDN_MST_ROLE").Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.Ignore<IdentityRoleClaim<string>>();
            modelBuilder.Entity<User>().Property(b => b.UserCode).Metadata.AfterSaveBehavior = PropertySaveBehavior.Ignore;
            modelBuilder.Entity<RoleDetail>().Property(b => b.RoleCode).Metadata.AfterSaveBehavior = PropertySaveBehavior.Ignore;
        }

        public DbSet<Privilege> Privileges { get; set; }

        public DbSet<PrivilegeType> PrivilegeTypes { get; set; }

        public DbSet<RolePrivilegeType> RolePrivilegeTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<IdentityUserRole<string>> UserRoles { get; set; }

        public DbSet<RoleDetail> RoleDetails { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Claim> Claims { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
    }

    [Table("IDN_MST_GROUP")]
    public class Group : IAuditable
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [MaxLength(100)]
        [Column("NAME")]
        public string Name { get; set; }

        [MaxLength(1000)]
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("CREATED_BY")]
        [MaxLength(256)]
        public string CreatedBy { get; set; }

        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

        [Column("UPDATED_BY")]
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }

        [Column("VERSION_NUMBER")]
        [MaxLength(11)]
        public string VersionNumber { get; set; }

        [Column("Status")]
        [Required]
        public bool Status { get; set; }

        [Column("VALID_FROM")]
        public DateTime? ValidateFrom { get; set; }

        [Column("VALID_TO")]
        public DateTime? ValidateTo { get; set; }
    }


    [Table("IDN_TRN_USER_GROUP")]
    public class UserGroup
    {
        [Key]
        public int Id { get; set; }

        [Column("USER_CODE")]
        [ForeignKey("FK_User_GROUP_ID")]
        public int UserCode { get; set; }
        public virtual User User { get; set; }

        [Column("GROUP_ID")]
        [ForeignKey("FK_USER_GROUPS_GROUP_ID")]
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }


    [Table("IDN_MST_USER_STATUS")]
    public class Status : IAuditable
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class User : IdentityUser, IAuditable
    {
        [Column("USER_CODE")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserCode { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        [Column("Status_Id")]
        public string Status_Id { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }

        public List<UserGroup> Groups { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Mobile")]
        public string Mobile { get; set; }

        [Column("ProfileImageName")]
        public string ProfileImgName { get; set; }

        [Column("VALID_FROM")]
        public DateTime? ValidateFrom { get; set; }

        [Column("VALID_TO")]
        public DateTime? ValidateTo { get; set; }

        public string RefreshToken { get; set; }
        public string SessionId { get; set; }

        [DefaultValue(0)]
        public int PrimaryGroupId { get; set; }

        [NotMapped]
        public virtual List<Info> Roles { get; set; }
    }

    public class Info
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CommonCol
    {
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [Column("UpdatedDate")]
        public DateTime UpdatedDate { get; set; }

        [Column("CreatedBy")]
        public string CreatedBy { get; set; }

        [Column("UpdatedBy")]
        public string UpdatedBy { get; set; }
    }

}
