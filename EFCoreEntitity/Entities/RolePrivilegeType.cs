/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		1/22/2019
** CREATED BY:		TruBot
** Description:   
** 
** Revision History:
**
** Date     Author      Description   
*******************************************************************************************************************************/

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Entities
{
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
}
