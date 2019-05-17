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

        [Table("IDN_MST_ROLE_TYPE")]
        public class RoleType
        {
            [Column("ID")]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Column("ROLE_TYPE")]
            [MaxLength(100)]
            public string RoleTypeName { get; set; }


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

            [Column("STATUS")]
            [Required]
            public bool Status { get; set; }

        }
        public DbSet<RoleType> RoleTypes { get; set; }

        [Table("IDN_MST_CLAIMS")]
        public class Claim
        {

            [Key]
            [Column("ID")]
            public int Id { get; set; }

            [Column("PRIVILEGE_ID")]
            [ForeignKey("FK_PRIVILEGE_ID")]
            public string Privilegeid { get; set; }
            public virtual Privilege Privilege { get; set; }

            [Column("PRIVILEGETYPE_ID")]
            [ForeignKey("FK_PRIVILEGETYPE_ID")]
            public string PrivilegeTypeid { get; set; }
            public virtual PrivilegeType PrivilegeType { get; set; }

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
        }
        [Table("IDN_TRN_CLAIMS")]
        public class Permission
        {

            [Key]
            [Column("ID")]
            public int Id { get; set; }

            //[Column("Role_Id")]
            //[ForeignKey("FK_Role_Role_ID")]
            //public string Role_Id { get; set; }


            [Column("ROLE_ID")]
            public string RoleId { get; set; }

            [Column("CLAIMS_ID")]
            [ForeignKey("FK_CLAIMS_ID")]
            public int ClaimsId { get; set; }
            public virtual Claim Claims { get; set; }

            [Column("CREATEDBY")]
            public string CreatedBy { get; set; }

            [Column("CREATEDDATE")]
            public DateTime CreatedDate { get; set; }

            [Column("UPDATEDBY")]
            public string UpdatedBy { get; set; }


            [Column("UPDATEDDATE")]
            public DateTime UpdatedDate { get; set; }

            [Column("VERSIONNO")]
            public string VersionNo { get; set; }
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

        [Table("IDN_TRN_ROLEDETAILS")]
        public class RoleDetail : IAuditable
        {
            [Column("ROLE_CODE")]
            [Required]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int RoleCode { get; set; }

            [Column("ID")]
            public string Id { get; set; }

            [Column("ROLE_ID")]
            public string Role_Id { get; set; }

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
            [Column("VALID_FROM")]
            public DateTime? ValidateFrom { get; set; }

            [Column("VALID_TO")]
            public DateTime? ValidateTo { get; set; }

            [Column("Status")]
            [Required]
            public bool Status { get; set; }

            [ForeignKey("ROLE_TYPE_ID")]
            public int ROLE_TYPEID { get; set; }
            public virtual RoleType RolesTypeId { get; set; }

        }
        public class Role : IdentityRole, IAuditable
        {

            [Column("ROLE_CODE")]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Required]
            public int RoleCode { get; set; }

            [Column("VALID_FROM")]
            public DateTime? ValidateFrom { get; set; }

            [Column("VALID_TO")]
            public DateTime? ValidateTo { get; set; }

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
        }

        [Table("IDN_TRN_ROLE_PRIVILEGE_TYPE")]
        public class RolePrivilegeType : IAuditable
        {
            [Column("ID")]
            [Key]
            public string Id { get; set; }

            [ForeignKey("ROLE_ID")]
            public string Role_Id { get; set; }
            public virtual Role Roles { get; set; }

            [ForeignKey("PRIVILEGE_ID")]
            public int Privilege_Id { get; set; }

            public virtual Privilege Privileges { get; set; }
            [ForeignKey("PRIVILEGE_TYPE_ID")]
            public int Privilege_Type_Id { get; set; }
            public virtual PrivilegeType PrivilegeTypes { get; set; }


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

        }

        [Table("IDN_MST_PRIVILEGE_TYPE")]
        public class PrivilegeType : IAuditable
        {
            [Column("ID")]
            [Key]
            public string Id { get; set; }

            [MaxLength(100)]
            [Column("NAME")]
            public string Name { get; set; }

            public ICollection<RolePrivilegeType> RolePrivilegeType { get; set; }

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
        }

        [Table("IDN_MST_PRIVILEGE")]
        public class Privilege : IAuditable
        {
            [Key]
            [Column("ID")]
            public string Id { get; set; }

            [MaxLength(100)]
            [Column("NAME")]
            public string Name { get; set; }

            public ICollection<RolePrivilegeType> RolePrivilegeType { get; set; }

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

            /* public string Role_Id { get; set; }
             [ForeignKey("Role_Id")]
             public virtual Role Role { get; set; }*/


            [Column("Status_Id")]
            public string Status_Id { get; set; }
            [ForeignKey("Status_Id")]
            public virtual Status Status { get; set; }

            //[Column("Group_ID")]
            //[ForeignKey("Group_ID")]
            //public int? GroupID { get; set; }
            //public virtual Group Group { get; set; }

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
        }
        public interface IAuditable
        {
            string CreatedBy { get; set; }
            DateTime CreatedDate { get; set; }
            string UpdatedBy { get; set; }
            DateTime UpdatedDate { get; set; }
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
}
